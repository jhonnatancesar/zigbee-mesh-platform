# TASK-010 — Ingestão e processamento de eventos

## Objetivo

Implementar a ingestão e o processamento interno dos eventos definidos para a malha.

## Contexto

A arquitetura é orientada a eventos e o banco precisa registrar eventos, falhas, rotas e diagnósticos.

## Dependências

TASK-007, TASK-008 e TASK-009 validadas.

## Escopo

Receber eventos do coordenador, validar contratos, persistir os registros e disponibilizá-los internamente aos módulos autorizados.

## Arquivos permitidos

`server/`, `docs/`, `tasks/TASK-010.md`, `CHANGELOG.md`.

## Arquivos proibidos

API externa, IA de ação, OTA, Home Assistant, alteração de firmware não necessária.

## Critérios de aceite

- Eventos válidos são persistidos com rastreabilidade.
- Eventos inválidos falham de forma observável.
- Não ocorre perda silenciosa nos cenários definidos.

## Testes obrigatórios

Testes de contrato, integração coordenador-servidor, erro e persistência.

## Resultado esperado

Fluxo interno de eventos confiável entre a malha e o banco local.
