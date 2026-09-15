# Rastreabilidade inicial

TASK-032 está **SUSPENSA POR REPRIORIZAÇÃO — NÃO BLOQUEANTE**; suas análises permanecem preservadas. TASK-033 e TASK-034 estão concluídas. TASK-008 é a próxima TASK válida e não há TASK ativa.

## Prioridade de interoperabilidade

`TASK-034` concluída -> ADR-001/ADR-002 aprovados -> `TASK-008` -> `TASK-007` -> cadeia de eventos/API -> `TASK-019`.

Em paralelo como pré-requisito específico da TASK-007: `TASK-033` concluída -> ADRs do coordenador. TASK-007 só inicia após a fundação do servidor e os ADRs de ambas as cadeias.

## Evidência da TASK-034

| Diretriz | Evidência |
| --- | --- |
| Servidor local e fonte da verdade | `SERVER_PLATFORM_EVALUATION.md` mantém persistência como porta local e reserva banco definitivo à TASK-009. |
| Eventos e integração do coordenador | ADR-002 define `coordinator_adapter` por contratos normalizados, USB/Serial primário e Wi-Fi/WebSocket-TLS secundário, sem SDK Espressif no servidor. |
| Segurança e operação | TLS, tokens, auditoria, serviço local, atualização e recuperação seguem TASK-029 e TASK-030. |
| Compatibilidade operacional | Linux e Windows foram comparados sem exigir suporte simultâneo antes de decisão explícita. |

Coordenador, commissioning, descoberta, capacidades, clusters padrao, atributos, comandos e tratamento seguro de clusters desconhecidos sao prioridades do MVP. O dispositivo proprio fornece apenas segundo caso de teste.

## Evidencia da TASK-033

| Diretriz | Evidencia |
| --- | --- |
| Coordenador e interoperabilidade por padrao | `COORDINATOR_INTEROPERABILITY_ARCHITECTURE.md` e RFC-007 definem BDB, ZDO, ZCL e capacidade anunciada como base. |
| Seguranca de ingresso e comandos | Permit-join limitado, autorizacao separada da descoberta, auditoria e falha fechada, alinhados a RFC-002 e `SECURITY_ARCHITECTURE.md`. |
| Home Assistant como cliente | Capacidades e estados passam pelo servidor local; o adaptador futuro nao acessa o radio ou a fonte da verdade. |
| Validacao comercial posterior | TASK-019 permanece responsavel pela matriz formal e suas evidencias. |

## Cadeia da plataforma fisica do sensor

`TASK-032` -> validacao do usuario -> ADRs aprovados -> `TASK-031` -> `TASK-004` -> `TASK-005`.

TASK-032 resolve RFC-005; TASK-031 executa somente os ensaios previamente decididos; TASK-004 e TASK-005 consomem a plataforma validada.

## Evidencia da TASK-030

| Secao | Evidencia |
| --- | --- |
| 7, 8 e 10 | Operacao local, falhas, auditoria e recuperacao em `OPERATIONS_REQUIREMENTS.md`. |
| 19 | Criterios de capacidade, manutencao e simplicidade sem escolha de ferramenta. |

## Evidencia da TASK-017

| Diretriz | Evidencia |
| --- | --- |
| IA controlada por risco | `AI_POLICY.md` define baixo, medio e alto risco. |
| Justificativa e auditoria | Registro obrigatorio de motivo, correlacao e resultado. |

## Evidencia da TASK-015

| Diretriz | Evidencia |
| --- | --- |
| OTA para tres papeis | `OTA_SPECIFICATION.md` define fluxo comum e estados. |
| Bateria, enlace, integridade e rollback | Regras de elegibilidade, verificacao e recuperacao verificaveis. |

## Evidencia da TASK-003

| Secao do Playbook | Evidencia |
| --- | --- |
| 5 - MVP | Escopo do end device temperatura/umidade. |
| 9 - HAL e ESP32-C6 | Fronteiras conceituais em `SENSOR_SPECIFICATION.md`. |
| 18 e 19 | Compatibilidade e criterios de consumo, manutencao e enlace para validacao futura. |

## Evidencia da TASK-002

| Diretriz | Evidencia |
| --- | --- |
| Registros e retencao | `docs/CONTRACTS.md` define tipos, campos conceituais e prioridades. |
| Eventos e API | Versionamento, validacao, erros, idempotencia e correlacao definidos. |
| Zigbee de terceiros | Identidade, capacidade e incompatibilidade rastreaveis. |

## Evidencia da TASK-029

| Secao do Playbook | Evidencia |
| --- | --- |
| 7 - Arquitetura | Limites de confianca e fluxos em `docs/SECURITY_ARCHITECTURE.md` |
| 8 - Seguranca | Requisitos de TLS, tokens, mTLS planejado, auditoria e credenciais |
| 10 - Registros | Requisitos de correlacao e auditoria de eventos de seguranca |
| 12 - OTA | Assinatura, integridade, elegibilidade e rollback delimitados |

## Evidencia da TASK-001

| Secao do Playbook | Evidencia produzida | Verificacao |
| --- | --- | --- |
| 5 - MVP | `docs/ARCHITECTURE.md` delimita os modulos do MVP e seus limites | Nenhum item V2 ou futuro foi incorporado |
| 7 - Arquitetura | Limites de modulos, fronteiras e fluxos logicos em `docs/ARCHITECTURE.md` | Modularidade, eventos e banco local como fonte da verdade estao explicitos |
| 8 - Dados e retencao | Fluxo de telemetria e regra de persistencia local | Contratos e retencao concreta permanecem para TASK-002 e TASK-030 |
| 9 - Firmware | Modulos Dispositivo Zigbee e Firmware/HAL | SDK/toolchain e implementacao permanecem pendentes |
| 10 - Registros | Regra de rastreabilidade e fluxo de eventos | Campos e contratos permanecem para TASK-002 |
| 11 - IA | Modulo e fluxo de pre-analise de IA | Politica de risco permanece para TASK-017 |
| 12 - OTA | Modulo e fluxo logico de OTA | Especificacao e controles permanecem para TASKs 015 e 029 |

As decisoes pendentes associadas a essas secoes estao registradas em `rfc/RFC-001.md`. Nenhum ADR foi criado porque nenhuma escolha foi aprovada.

| Diretriz do Playbook | Documentacao inicial | TASKs propostas |
| --- | --- | --- |
| Missao, MVP, V2 e futuro | `CONTEXTO.md`, `ROADMAP.md` | 001-031 |
| Fluxo, escopo e qualidade | `AGENTS.md`, `CONTRIBUTING.md`, modelos | 000-031 |
| Triagem de novas ideias e proteção de escopo | `IDEA_TRIAGE.md`, `FUTURE_BACKLOG.md` | Aplicável somente após autorização |
| Validação prévia de execução de TASK | `QUALITY_GATE.md`, `AGENTS.md`, `CONTRIBUTING.md` | Todas as TASKs |
| Evidência e encerramento de TASK | `TASK_CLOSURE.md`, `AGENTS.md`, `CONTRIBUTING.md` | Todas as TASKs |
| Modularidade e eventos | `ARCHITECTURE.md` | 001, 002, 008, 010 |
| Zigbee e compatibilidade de terceiros | `ARCHITECTURE.md`, `GLOSSARY.md` | 005-007, 019 |
| Firmware, HAL e ESP32-C6 | `ARCHITECTURE.md` | 003-006, 015, 031 |
| Banco, registros e retencao | `CONTEXTO.md`, `ARCHITECTURE.md` | 002, 009, 014, 017, 030 |
| Seguranca e auditoria | `CONTEXTO.md`, `DECISIONS.md` | 012, 015, 016, 029 |
| Home Assistant como cliente | `ARCHITECTURE.md` | 013 |
| IA controlada por risco | `ARCHITECTURE.md`, `DECISIONS.md` | 017, 018 |
| OTA assinada com rollback | `ARCHITECTURE.md`, `DECISIONS.md` | 015, 016 |

O detalhamento de arquitetura e contratos permanece fora da TASK-000 e sera produzido apenas nas TASKs autorizadas.
