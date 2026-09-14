# Contratos de eventos, dados e API administrativa do MVP

## Regras comuns

Todo evento e resposta administrativa usa versao de contrato, identificador unico, instante de ocorrencia, origem, correlacao e resultado. Campos desconhecidos sao rejeitados ou preservados somente conforme versao compativel; alteracoes incompativeis exigem nova versao. A identidade e os dados sensiveis obedecem `SECURITY_ARCHITECTURE.md`; segredos nunca integram eventos ou logs.

| Campo conceitual | Regra |
| --- | --- |
| `event_id` / `request_id` | Unico e usado para idempotencia e correlacao. |
| `contract_version` | Explicito em todo payload. |
| `occurred_at` | Instante da origem, com instante de recebimento registrado separadamente. |
| `source` | Dispositivo, coordenador, servico ou cliente administrativo identificavel. |
| `correlation_id` | Liga comando, evento, auditoria e resposta quando aplicavel. |
| `payload` | Campos do tipo de registro; sem chaves, tokens ou certificados. |

Reenvio com o mesmo identificador e mesmo conteudo retorna o resultado original; com conteudo diferente falha por conflito. Payload invalido, versao nao suportada, origem nao autorizada e falha de persistencia sao recusados de modo observavel e auditavel.

## Registros obrigatorios

| Tipo | Campos conceituais adicionais | Produtor e consumidor | Retencao |
| --- | --- | --- | --- |
| Medicao | dispositivo, metrica, valor, unidade, qualidade, contexto de leitura | dispositivo/coordenador -> ingestao, persistencia, API | Conforme politica operacional; nunca abaixo do necessario para rastreabilidade |
| Falha | componente, codigo, severidade, descricao segura, impacto, recuperacao | qualquer modulo -> persistencia, observabilidade | Prioridade maxima |
| Rota | dispositivo, rota anterior/atual quando conhecida, causa, qualidade do enlace | coordenador/router -> persistencia, diagnostico | Alta prioridade |
| OTA | artefato identificado, alvo, elegibilidade, assinatura/integridade resultado, rollback | OTA -> persistencia, auditoria | Alta prioridade e auditavel |
| Decisao de IA | classificacao de risco, dados minimos, decisao, justificativa, aprovador quando aplicavel | pre-analise -> persistencia, auditoria | Alta prioridade |
| Diagnostico | componente, estado, indicadores, correlacao e recomendacao segura | qualquer modulo -> observabilidade/API | Conforme politica operacional |
| Auditoria | ator, acao, alvo, autorizacao, resultado, motivo de recusa e correlacao | API/seguranca -> persistencia | Alta prioridade |

Os valores concretos, limites de capacidade e duracoes de retencao dependem da TASK-030; nenhum consumidor pode assumir exclusao silenciosa.

## Interoperabilidade Zigbee

O contrato preserva identidade de fabricante/modelo quando disponivel, capacidade ou perfil anunciado, estado de comissionamento e diagnostico de incompatibilidade. Um dispositivo de terceiros nao recebe privilegio administrativo por compatibilidade; eventos desconhecidos sao registrados como nao suportados ou rejeitados de forma rastreavel.

## API administrativa

As operacoes sao versionadas, locais e administrativas. Cada requisicao exige autenticacao, autorizacao de privilegio minimo e auditoria. Categorias permitidas: consulta de dispositivos/estado/medicoes/diagnosticos; consulta de falhas, rotas, OTA e auditoria; e comandos administrativos explicitamente autorizados por contrato posterior.

| Resultado | Regra |
| --- | --- |
| Sucesso | Inclui `request_id`, versao, dado ou confirmacao e correlacao. |
| Validacao | Informa campo/regra sem expor dado sensivel. |
| Autenticacao/autorizacao | Nega sem revelar credencial ou privilegios. |
| Conflito/idempotencia | Retorna resultado anterior ou conflito de conteudo. |
| Indisponibilidade | Nao mascara falha; registra correlacao e orienta nova tentativa segura. |

Home Assistant consome somente contratos aprovados e nunca altera diretamente a fonte da verdade. Endpoints, formatos de transporte e esquemas fisicos permanecem fora desta TASK.
