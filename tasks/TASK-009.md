# TASK-009 — Banco como fonte da verdade

## Objetivo

Implementar persistência local para os registros exigidos pelo Playbook, com política de retenção.

## Contexto

O banco próprio é fonte da verdade e deve registrar medições, falhas, rotas, OTA, IA, justificativas e diagnósticos com prioridades explícitas.

## Dependências

TASK-002, TASK-008, TASK-017 e TASK-030 validadas; ADR de tecnologia de banco aprovada.

## Escopo

Implementar modelo, migrações e acesso a dados para os contratos aprovados, incluindo retenção.

## Arquivos permitidos

`server/`, `docs/`, `adr/`, `tasks/TASK-009.md`, `CHANGELOG.md`.

## Arquivos proibidos

API pública, IA decisória, OTA, Home Assistant, dados reais e credenciais.

## Critérios de aceite

- Todos os tipos de registro obrigatórios persistem.
- A ordem de retenção e os critérios operacionais de capacidade/recuperação aprovados são aplicados e testados.
- O banco permanece fonte da verdade independente de clientes.

## Testes obrigatórios

Testes de migração, persistência, consulta e retenção por prioridade.

## Resultado esperado

Camada de dados local confiável e verificável.
