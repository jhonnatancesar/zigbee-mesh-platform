# TASK-011 — API administrativa

## Objetivo

Implementar APIs para administração da plataforma conforme contratos aprovados.

## Contexto

O Playbook exige APIs administrativas; o banco próprio permanece a fonte da verdade.

## Dependências

TASK-002, TASK-009, TASK-010 e TASK-012 validadas; RFC/ADR de contratos de API aprovada.

## Escopo

Implementar e expor somente operações administrativas aprovadas para consultar e administrar recursos do MVP, estritamente conforme os contratos da TASK-002 e os controles da TASK-012, sem redefini-los.

## Arquivos permitidos

`server/`, `docs/`, `adr/`, `rfc/`, `tasks/TASK-011.md`, `CHANGELOG.md`.

## Arquivos proibidos

Interface própria, nuvem comercial, IA, OTA, credenciais.

## Critérios de aceite

- Endpoints correspondem a contratos aprovados.
- Respostas refletem o banco como fonte da verdade.
- Operações possuem validação e rastreabilidade.

## Testes obrigatórios

Testes de contrato, autenticação, autorização, validação de erros, idempotência e integração com persistência.

## Resultado esperado

API administrativa local documentada e testada.
