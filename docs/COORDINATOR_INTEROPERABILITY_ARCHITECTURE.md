# Arquitetura proposta do coordenador Zigbee e interoperabilidade

## Estado

Decisões produzidas pela TASK-033 e formalizadas em ADR-003, ADR-004 e ADR-005.

## Objetivo e limites

O coordenador cria e mantem a rede Zigbee e e a fronteira entre a malha e a plataforma local. A interoperabilidade deve resultar de Zigbee Base Device Behavior (BDB), ZDO e ZCL, mais as capacidades efetivamente anunciadas por cada dispositivo. Fabricante e modelo servem para identidade, diagnostico e suporte, nunca como lista fixa que habilita funcoes.

O servidor local e a fonte da verdade. Home Assistant sera apenas consumidor futuro de capacidades e estados aprovados; nao controla diretamente o radio Zigbee nem substitui o registro local.

## Arquitetura proposta

```text
Seeed Studio XIAO ESP32-C6 (ESP Zigbee SDK)
                 |
          coordinator_adapter
                 |
       servico de dispositivos <-> persistencia local
                 |
      auditoria/eventos e API/adaptador Home Assistant
```

`coordinator_adapter` deve encapsular inicialmente o ESP Zigbee SDK e suas APIs especificas da Espressif. Ele traduz operacoes Zigbee e eventos do XIAO ESP32-C6 para contratos normalizados dirigidos ao servico de dispositivos. Servidor, dominio, persistencia, API administrativa e futuro adaptador Home Assistant nao chamam ESP-IDF nem ESP Zigbee SDK e nunca enviam quadros Zigbee diretamente.

## Plataforma do coordenador: alternativas e recomendacao proposta

| Alternativa | Vantagens | Riscos/limites |
| --- | --- | --- |
| Seeed Studio XIAO ESP32-C6 com ESP Zigbee SDK | Plataforma definida para o coordenador inicial, radio e stack oficial Espressif na mesma unidade; reaproveita a familia ESP32-C6 ja adotada no MVP. | Exige isolar rigorosamente SDK/ESP-IDF no `coordinator_adapter` e qualificar versao do SDK, memoria e estabilidade da funcao de coordenador. |
| Adaptador USB NCP baseado em TI CC2652P/CC2652RB, com interface ZNP | Alternativa tecnica madura, radio dedicado e substituicao fisica pratica. | Nao e arquitetura principal do MVP; somente fallback futuro, com interface e firmware proprios a qualificar. |
| Adaptador NCP Silicon Labs EFR32MG21/MG24, com interface EZSP/Ember | Ecossistema consolidado e boa disponibilidade de radios. | Interface e ciclo de firmware diferentes; exige adaptador especifico e qualificacao equivalente. |
| Radio ESP32-H2/C6 em outra placa | Opcao futura para outro formato fisico. | Nao traz beneficio sobre o XIAO ESP32-C6 para o coordenador inicial. |

**Decisão vigente:** o coordenador inicial utiliza Seeed Studio XIAO ESP32-C6 com ESP Zigbee SDK, atrás de `coordinator_adapter`, conforme ADR-003. TI/ZNP permanece documentado como fallback para reavaliação futura. A fronteira permite essa troca sem reescrever domínio, persistência ou API.

## Formacao, manutencao e commissioning

- O coordenador no XIAO ESP32-C6 forma, restaura e mantem uma unica rede local persistente; PAN, canal, identidade e material sensivel permanecem fora do repositorio e sao recuperaveis por procedimento operacional aprovado.
- A rede inicia com permit-join fechado. A abertura ocorre somente por acao administrativa autorizada, possui duracao limitada, motivo, ator e auditoria; deve voltar a fechado por expiracao ou encerramento explicito.
- O ingresso BDB bem-sucedido cria o registro no estado `solicitado`. Descoberta tecnica nao equivale a autorizacao administrativa nem concede comandos privilegiados.
- O ciclo `solicitado -> verificado -> aceito | suspenso | revogado | removido` continua regido pela RFC-002. Reassociacao, troca de endereco curto e retorno apos indisponibilidade preservam a identidade estavel quando comprovada.
- Reinicio do coordenador, falha de persistencia ou estado ambiguo bloqueiam novos ingressos e produzem diagnostico/auditoria; o sistema nao libera permit-join por padrao.

## Responsabilidades Zigbee do coordenador inicial

| Responsabilidade | Papel do XIAO ESP32-C6 com ESP Zigbee SDK | Limite da responsabilidade |
| --- | --- | --- |
| Rede | Formar, restaurar e informar estado de rede. | Politica administrativa e persistencia autoritativa permanecem no servidor. |
| Commissioning | Executar network steering e controlar permit-join conforme solicitacao autorizada. | A autorizacao final do dispositivo nao e decidida pelo radio. |
| Descoberta | Executar ZDO para descritores, endpoints e topologia/informacoes de enlace disponiveis. | O dominio interpreta e persiste resultado normalizado. |
| Operacoes ZCL | Ler/escrever atributos, configurar/receber reports e enviar comandos padrao elegiveis. | Nenhuma operacao proprietaria ou nao anunciada e inferida. |
| Eventos e diagnosticos | Publicar presenca, erros, estado de rede, reports e informacoes de enlace disponiveis. | Eventos nao sao descartados silenciosamente e nao contem material sensivel. |

## Descoberta baseada em padroes

Para cada dispositivo ingressado, o coordenador deve registrar separadamente a descoberta e a autorizacao:

1. associar endereco IEEE como identidade estavel e endereco de rede como dado mutavel;
2. obter informacao ZDO disponivel, incluindo node descriptor e active endpoints;
3. para cada endpoint, obter simple descriptor: profile, device id, versao e clusters de entrada/saida;
4. ler o Basic cluster quando exposto, incluindo fabricante, modelo, versao de software e campos padrao disponiveis;
5. descobrir atributos ZCL somente nos clusters e direcoes anunciados, respeitando tipo, acesso e capacidade de resposta;
6. registrar resultado, instante, tentativa, erro seguro e versao da descoberta.

Ausencia de endpoint, cluster, atributo ou resposta nao e falha fatal: representa capacidade nao anunciada, indisponivel ou ainda nao determinada. O dispositivo permanece observavel com esse diagnostico.

## Modelo persistido de capacidade

O registro local proposto deve conter, no minimo:

| Entidade | Dados necessarios |
| --- | --- |
| Dispositivo | identificador interno, IEEE address, endereco curto atual, estado de ingresso/autorizacao, fabricante/modelo quando disponiveis, ultima presenca e diagnosticos. |
| Endpoint | numero, profile id, device id, versao e estado da descoberta. |
| Cluster | identificador, direcao servidor/cliente, origem do dado, status de suporte e metadados de descoberta. |
| Atributo | identificador, tipo, acesso quando anunciado, valor/qualidade/instante quando lido ou reportado, e erro seguro quando indisponivel. |
| Capacidade derivada | funcao padrao, evidencia (endpoint/cluster/atributo/comando), confianca e disponibilidade; nunca apenas fabricante/modelo. |

Uma capacidade derivada e valida somente enquanto sua evidencia existir. Exemplo: `switch.on_off` depende do cluster On/Off anunciado no endpoint adequado; nao depende de o modelo constar em catalogo. O servidor pode expor tanto a capacidade normalizada quanto os descritores brutos autorizados para diagnostico, sem inferir comandos proprietarios.

## Atributos, reports e comandos

- Leitura/escrita usa somente atributos anunciados, com tipo e permissao compativeis. Escrita requer operacao administrativa autorizada, correlacao e auditoria.
- Reports recebidos sao validados contra endpoint, cluster, atributo e tipo conhecidos; atualizam estado com qualidade, instante de origem/recebimento e correlacao previstos em `CONTRACTS.md`.
- O sistema pode configurar reporting apenas quando o cluster/atributo o suportar e a politica posterior permitir. Falha de configuracao nao invalida o dispositivo; fica registrada.
- O catalogo inicial de capacidades padrao deve cobrir apenas o que for anunciado: por exemplo On/Off, Level Control, Color Control, Temperature Measurement, Relative Humidity Measurement e Power Configuration. A lista e extensivel por cluster padrao, sem depender de modelos fixos.
- Um comando so e elegivel quando ha evidencia de cluster, direcao e comando suportados, alem de autorizacao do solicitante. Resultado inclui aceite pelo coordenador e, quando houver, confirmacao/estado posterior; nunca presume execucao por ausencia de erro.

## Clusters parciais, desconhecidos e proprietarios

| Situacao | Comportamento seguro |
| --- | --- |
| Capacidade parcial | Expor somente capacidades demonstradas; nao completar por heuristica de fabricante/modelo. |
| Cluster padrao desconhecido pela versao atual | Preservar id, direcao e diagnostico como metadados; nao enviar comandos ate suporte ser adicionado e validado. |
| Cluster proprietario | Registrar como opaco e observavel, sem parser, escrita ou comando implicito. |
| Dispositivo sem Basic cluster ou com leitura falha | Manter identidade de rede e descritores obtidos; indicar identificacao incompleta. |
| Dispositivo que nao responde | Registrar indisponibilidade e aplicar nova tentativa limitada; nao remover nem reabrir commissioning automaticamente. |

Assim, uma lampada comercial que exponha apenas On/Off pode entrar, ser identificada por seus descritores, ter estado consultado e receber somente o comando On/Off. Recursos nao expostos permanecem indisponiveis, sem quebrar a rede nem exigir implementacao especifica da marca.

## Requisitos para integracao futura com Home Assistant

- O adaptador Home Assistant deve consultar o catalogo local de capacidades e estados, nunca um catalogo de modelos.
- Cada entidade publicada deve carregar referencia ao dispositivo, endpoint, capacidade, estado/qualidade e correlacao suficientes para diagnostico local.
- Comandos do Home Assistant percorrem API/servico local com autenticacao, autorizacao, idempotencia e auditoria antes de chegar ao `coordinator_adapter`.
- Alteracoes de descoberta devem produzir eventos de capacidade adicionada, alterada, indisponivel ou removida; a sincronizacao posterior nao deve assumir que todos os dispositivos implementam os mesmos clusters.
- A integracao futura nao recebe chaves Zigbee, acesso serial ao adaptador ou autoridade sobre o estado persistido.

## Riscos e limites

- A interoperabilidade real depende das implementacoes e firmware dos dispositivos; a conformidade anunciada nao garante comportamento perfeito. TASK-019 conserva a matriz formal de validacao.
- Dispositivos a bateria podem responder tardiamente ou dormir durante descoberta/configuracao de reports.
- O firmware do coordenador e a versao do ESP Zigbee SDK tornam-se partes criticas de operacao: compatibilidade, recuperacao e atualizacao devem ser documentadas antes da implementacao.
- Enderecos curtos mudam; usa-los como identidade primaria causaria duplicacao ou comandos ao alvo errado.
- Interpretar clusters proprietarios sem especificacao pode gerar efeitos inseguros; por isso eles permanecem opacos.

## Referencias tecnicas de pesquisa

- Connectivity Standards Alliance, Zigbee Base Device Behavior Specification: commissioning e permit-joining.
- Connectivity Standards Alliance, Zigbee Cluster Library Specification: descriptors, clusters, atributos, reports e comandos.
- Zigbee Device Object (ZDO): node descriptor, active endpoints e simple descriptor.
- Documentacao oficial do ESP Zigbee SDK e ESP-IDF para ESP32-C6; Z-Stack ZNP e EZSP/Ember somente como alternativas futuras.

## Validacao e ADRs futuros

ADR-003 formaliza plataforma e `coordinator_adapter`; ADR-004 formaliza commissioning/autorização; ADR-005 formaliza o modelo de capacidades. A TASK-007 deve implementar exclusivamente essas decisões aprovadas.
