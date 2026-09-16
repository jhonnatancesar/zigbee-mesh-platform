# Changelog

Todas as mudanças relevantes deste projeto serão registradas aqui.

## [Não lançado]

### Alterado

- TASK-008 validada formalmente; fundação do servidor local pronta para consumidores posteriores.
- TASK-034 validada formalmente; ADR-001 e ADR-002 registram plataforma do servidor e fronteira coordenador-servidor.
- TASK-033 validada formalmente; ADRs do coordenador pendem de registro antes da implementação.
- TASK-032 suspensa por repriorização, sem descarte das análises acumuladas e sem bloqueio da cadeia do coordenador; TASK-033 registrada como próxima prioridade.

### Adicionado
- Fundação .NET do servidor local, fronteiras de eventos/coordenador/persistência, configuração não sensível e smoke test isolado.
- Avaliação da plataforma do servidor local e RFC-008, com recomendações pendentes de validação.
- TASK-034 para decisão da plataforma do servidor local antes da fundação da TASK-008.
- Proposta arquitetural do coordenador Zigbee e RFC-007 para interoperabilidade baseada em capacidades anunciadas, pendentes de validação.
- TASK-033 para decisao do coordenador Zigbee e interoperabilidade baseada em capacidades anunciadas.
- Avaliacao comparativa da plataforma fisica e RFC-006 com recomendacoes pendentes de validacao.
- TASK-032 para resolver decisoes da plataforma fisica e liberar a validacao da TASK-031.
- Requisitos operacionais documentais para servidor local, backup, recuperacao, tempo e retencao.
- Politica documental de pre-analise de IA, risco, aprovacao humana e consulta externa controlada.
- Especificacao documental de OTA segura, elegibilidade, telemetria e rollback.
- Especificacao documental do sensor MVP e metodologia de validacao fisica futura.
- Contratos documentais de eventos, dados, retencao e API administrativa do MVP.
- Arquitetura documental de seguranca do MVP e RFCs para identidade, canal seguro e ciclo de vida de credenciais/OTA.

- Índice documental, roadmap, arquitetura de princípios, rastreabilidade, glossário, estratégia de testes e modelos de documentos.
- Guia de contribuição e navegação de governança documental.
- Reorganização documental do backlog: segurança, contratos, OTA, IA, operação local e validação física passaram a preceder seus consumidores.
- Processo permanente de triagem de ideias e backlog futuro controlado, sem alteração do escopo do MVP.
- Separação explícita entre definição documental e execução prática para validação física, OTA, IA, segurança, operação e contratos.
- Gate de Qualidade obrigatório antes do início de qualquer TASK.
- Processo obrigatório de encerramento de TASK com relatório padronizado e evidências.
- Acionamento automático do fluxo completo por identificador de TASK, incluindo autoavaliação e comandos explícitos de commit/push após validação.

- Estrutura inicial de diretórios do projeto.
- Documentação inicial, regras para agentes e backlog de TASKs.

## [TASK-030] - 2026-09-14

### Adicionado

- Requisitos operacionais de instalacao, recuperacao, tempo, retencao e evidencias do servidor local.

## [TASK-017] - 2026-09-14

### Adicionado

- Politica de IA baseada em risco, aprovacao humana, auditoria e consulta externa controlada.

## [TASK-015] - 2026-09-14

### Adicionado

- Especificacao de OTA segura com elegibilidade, verificacao, telemetria e rollback.

## [TASK-003] - 2026-09-14

### Adicionado

- Especificacao do sensor MVP, fronteiras de HAL e metodologia de validacao fisica futura.

## [TASK-002] - 2026-09-14

### Adicionado

- Contratos conceituais de eventos, dados, retencao, interoperabilidade e API administrativa.

## [TASK-029] - 2026-09-14

### Adicionado

- Requisitos documentais de seguranca, identidade, TLS, tokens, auditoria, ciclo de credenciais e fronteira OTA.
- RFCs para comissionamento Zigbee, canal coordenador-servidor e ciclo de vida de credenciais.

## [TASK-001] - 2026-09-14

### Adicionado

- Baseline arquitetural verificavel do MVP, com limites de modulos, fluxos logicos e regras de fronteira.
- RFC-001 para registrar pendencias tecnicas sem aprovar tecnologias ou fornecedores.
- Rastreabilidade da baseline contra as secoes aplicaveis do Playbook.

## [TASK-000] - 2026-08-01

### Adicionado

- Inicialização documental do repositório, sem código funcional.
