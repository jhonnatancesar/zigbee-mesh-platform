# TASK-008 — Fundação do servidor local

## Objetivo

Implementar a fundação modular e orientada a eventos do servidor local.

## Contexto

O MVP inclui servidor local; tecnologias só podem ser escolhidas com justificativa e decisão aprovada.

## Dependências

TASK-001, TASK-002, TASK-029, TASK-030 e TASK-034 validadas e ADR de tecnologia do servidor aprovada.

## Escopo

Criar módulos mínimos, configuração não sensível, inicialização e fronteiras para eventos, dados, administração, segurança e operação local conforme os requisitos aprovados nas TASKs 002, 029 e 030, sem redefinir seus contratos ou requisitos operacionais.

## Arquivos permitidos

`server/`, `docs/`, `adr/`, `tasks/TASK-008.md`, `CHANGELOG.md`.

## Arquivos proibidos

Banco definitivo, API de negócio, IA, OTA, Home Assistant, credenciais.

## Critérios de aceite

- Módulos respeitam os limites arquiteturais aprovados.
- Inicialização e configuração são documentadas e testáveis.
- Não há segredo versionado.

## Testes obrigatórios

Build/lint aprovados e testes de inicialização isolada.

## Resultado esperado

Servidor local mínimo pronto para receber os módulos subsequentes.
