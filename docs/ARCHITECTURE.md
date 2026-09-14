# Arquitetura - baseline verificavel do MVP

## Baseline da TASK-001

Esta baseline define os limites, responsabilidades e fluxos logicos do MVP. Ela nao aprova tecnologias, protocolos internos, esquemas fisicos, contratos de API ou fornecedores. Essas escolhas permanecem pendentes e sao rastreadas em [RFC-001](../rfc/RFC-001.md); somente uma decisao explicitamente aprovada pode ser registrada como ADR.

### Fluxos logicos obrigatorios

#### Telemetria, estado e falhas

```text
Dispositivo Zigbee
  -> integracao do coordenador
  -> ingestao e validacao contratual
  -> persistencia local (fonte da verdade)
  -> processamento interno e observabilidade
  -> API administrativa e/ou adaptador Home Assistant
```

Falhas de transporte, validacao ou persistencia devem produzir evidencia rastreavel; nenhum modulo pode descartar silenciosamente um evento que recebeu. A definicao de envelope, identificacao, idempotencia, erros e retencao pertence a TASK-002.

#### Comando administrativo

```text
Cliente administrativo
  -> API administrativa (autenticacao, autorizacao e auditoria)
  -> servico interno autorizado
  -> integracao do coordenador ou modulo de dominio
  -> dispositivo Zigbee
  -> evento de resultado, persistencia e consulta posterior
```

Todo comando precisa permanecer correlacionavel ao solicitante, autorizacao, resultado e evento correspondente. O conjunto de operacoes e seus contratos nao e definido por esta TASK.

#### OTA e pre-analise de IA

OTA percorre a operacao autorizada, controles de seguranca e elegibilidade, distribuicao aprovada, verificacao de integridade e assinatura pelo dispositivo, e persistencia do resultado, falha ou rollback. A especificacao depende das TASKs 015 e 029; esta baseline nao autoriza formato de pacote, chaves, certificados ou implementacao.

A pre-analise de IA percorre evento ou solicitacao elegivel, dados minimos autorizados, classificacao de risco, decisao humana, consulta externa autorizada ou acao automatica de baixo risco, e persistencia de decisao, justificativa e evidencia. Seus limites pertencem a TASK-017; ate a aprovacao, IA nao pode criar decisao implicita nem executar acoes.

### Regras de fronteira e rastreabilidade

- A integracao do coordenador, os dispositivos, a API e o Home Assistant nao escrevem diretamente no banco fora dos servicos de persistencia aprovados.
- Cada evento e operacao administrativa deve poder ser relacionado, quando aplicavel, a origem, instante, identidade, resultado e registro persistido.
- Mudancas de rota, falhas, medicoes, eventos OTA, decisoes e justificativas de IA e diagnosticos devem ser representados pelos contratos posteriores.
- A camada de seguranca e transversal, mas nao elimina as responsabilidades dos modulos que ela protege.
- Uma falha em integracao externa nao concede a ela autoridade sobre o estado local; deve ser observavel e recuperavel conforme requisitos operacionais aprovados.

### Decisoes pendentes e criterios de aprovacao

Nenhuma tecnologia esta aprovada nesta baseline. As questoes abaixo devem ser resolvidas por RFC e, se aprovadas, ADR antes que uma TASK consumidora escolha ou implemente uma solucao:

| Assunto | Criterios minimos de decisao | TASKs que dependem do resultado |
| --- | --- | --- |
| Coordenador e fronteira Zigbee | Compatibilidade de terceiros, comissionamento, observabilidade, seguranca e integracao local | 002, 007, 019, 029 |
| SDK/toolchain e HAL ESP32-C6 | Baixo consumo, testabilidade, isolamento de hardware, OTA e manutencao | 003, 004, 005, 006, 015, 031 |
| Servidor, banco e mecanismo de eventos | Fonte da verdade, recuperacao, retencao, operacao local, seguranca e capacidade | 002, 008, 009, 010, 014, 030 |
| API e integracao Home Assistant | Versionamento, autenticacao, autorizacao, idempotencia, erros e preservacao da autoridade local | 002, 011, 013 |
| Seguranca, identidades e OTA | Limites de confianca, TLS/tokens, evolucao mTLS, auditoria, chaves, assinatura e rollback | 012, 015, 016, 029 |
| Politica de IA | Classificacao de risco, aprovacao humana, dados minimos, auditoria e indisponibilidade externa | 017, 018 |

### Fora de escopo desta baseline

Nao sao definidos por este documento: framework ou runtime, banco ou esquema fisico, SDK, protocolo interno, formato de eventos, endpoints, hardware de producao, fornecedor de IA, chaves, certificados, implementacao de OTA, interface propria, LoRa, nuvem comercial, V2 ou itens futuros.

### Limites de modulos

| Modulo logico | Responsabilidade | Entradas e saidas logicas | Nao e responsavel por |
| --- | --- | --- | --- |
| Dispositivo Zigbee | Medicao ou roteamento, participacao na malha e emissao de telemetria, estado e falhas | Produz eventos Zigbee; recebe comandos e artefatos OTA autorizados | Persistencia central, API administrativa, decisoes de IA |
| Firmware e HAL | Isolar hardware, energia, interfaces e funcoes de plataforma da logica do papel Zigbee | Expoe capacidades da HAL ao firmware; produz diagnosticos locais | Escolher contratos do servidor, armazenar a verdade do sistema |
| Integracao do coordenador | Fazer a fronteira entre a malha Zigbee e a plataforma local | Recebe eventos da malha; encaminha comandos autorizados | Redefinir contratos, persistir diretamente ou expor API publica |
| Ingestao e processamento de eventos | Validar, normalizar, correlacionar e encaminhar eventos conforme contratos aprovados | Consome eventos de borda; entrega registros e eventos internos rastreaveis | Definir regras de negocio fora dos contratos, ocultar falhas |
| Persistencia local | Guardar registros exigidos, retencao, recuperacao e consulta consistente | Recebe registros validados; atende consultas internas autorizadas | Tornar clientes externos fonte da verdade |
| API administrativa | Expor operacoes administrativas aprovadas, autenticar, autorizar e registrar auditoria | Consome servicos internos; responde conforme contrato versionado | Acessar a malha ou banco sem suas fronteiras |
| Adaptador Home Assistant | Traduzir a integracao aprovada para consumo pelo Home Assistant | Consome API ou eventos autorizados; informa falhas de integracao | Controlar a verdade do estado ou criar uma interface propria |
| Seguranca e auditoria | Aplicar identidade, limites de confianca, TLS/tokens, evolucao para mTLS e evidencia auditavel conforme decisoes aprovadas | Protege fluxos e produz registros de auditoria | Armazenar segredos versionados ou decidir politicas sem RFC/ADR |
| OTA | Orquestrar distribuicao, verificacao, elegibilidade, registro e rollback conforme especificacao aprovada | Consome artefato autorizado e estado do dispositivo; produz eventos de ciclo de vida | Distribuir atualizacao nao assinada ou redefinir chaves/politicas |
| Pre-analise de IA | Classificar risco, encaminhar decisao e registrar justificativas conforme politica aprovada | Consome dados minimos autorizados; produz decisao e auditoria | Executar automaticamente acoes de medio ou alto risco |
| Operacao e observabilidade | Tornar falhas, rotas, eventos, retencao e recuperacao consultaveis e verificaveis | Consome registros e evidencias; expoe diagnosticos autorizados | Alterar regras de dominio de forma implicita |

Este documento estabelece os limites, responsabilidades e fluxos logicos do MVP. Ele nao aprova tecnologias, protocolos internos, esquemas fisicos, contratos de API ou fornecedores. Essas escolhas permanecem pendentes e sao rastreadas em [RFC-001](../rfc/RFC-001.md); somente uma decisao explicitamente aprovada pode ser registrada como ADR.

## Principios e invariantes

- A arquitetura e modular e orientada a eventos.
- O banco proprio local e a fonte da verdade para o estado e os registros da plataforma.
- Home Assistant e cliente e integracao externa; nunca e a autoridade do estado persistido.
- As APIs sao administrativas e devem refletir os contratos aprovados, nao defini-los implicitamente.
- O firmware proprietario mantem a HAL desacoplada da logica de dominio; ESP32-C6 e a plataforma prevista para o MVP.
- A plataforma preserva compatibilidade com dispositivos Zigbee de terceiros dentro dos contratos e perfis aprovados.
- Seguranca, auditoria, retencao, rastreabilidade e recuperacao sao responsabilidades explicitas; nao sao detalhes opcionais de implementacao.
- Baixo consumo, simplicidade, manutencao, escalabilidade e desacoplamento sao criterios de avaliacao de toda decisao posterior.

## Limites iniciais preservados

| Dominio | Responsabilidade estabelecida | Nao estabelecido nesta TASK |
| --- | --- | --- |
| Malha Zigbee | Coordenador, routers e end devices do MVP | Tecnologia concreta do coordenador e contratos detalhados |
| Firmware | Firmware proprietario e HAL desacoplada | SDK, toolchain e implementacao |
| Servidor local | Processamento da plataforma, APIs administrativas e dados | Framework, runtime e desenho de modulos |
| Dados | Fonte da verdade e retencao prioritaria | Tecnologia, esquema fisico e migracoes |
| Home Assistant | Cliente da plataforma | Metodo e contrato de integracao |
| IA | Pre-analise local e decisao controlada por risco | Modelo, fornecedor e mecanismo de execucao |
| OTA | Assinada, com verificacoes e rollback | Formato, distribuicao e gestao de chaves |

## Registro historico do refinamento

Status: concluido pela TASK-001 nesta baseline e em RFC-001. ADRs continuam reservados exclusivamente para decisoes aprovadas.

O enunciado historico a seguir esta atendido pela baseline e RFC-001 acima; ele e mantido apenas como contexto da TASK original.

A TASK-001 deve produzir a arquitetura detalhada, os limites de modulos e os fluxos de eventos, usando RFCs para questoes pendentes e ADRs somente para decisoes aprovadas.
