# TASK-012 — Segurança inicial e auditoria

## Objetivo

Implementar TLS, tokens e auditoria no perímetro aprovado do MVP.

## Contexto

O Playbook determina TLS e tokens no MVP e registra evolução para mTLS; auditoria é obrigatória.

## Dependências

TASK-008, TASK-009, TASK-010 e TASK-029 validadas; RFC/ADR de segurança aprovada.

## Escopo

Implementar os controles de TLS, tokens e auditoria definidos pela TASK-029 nas interfaces aprovadas e documentar a migração futura para mTLS, sem redefinir limites de confiança, identidade ou gestão de chaves.

## Arquivos permitidos

`server/`, `docs/`, `adr/`, `rfc/`, `tasks/TASK-012.md`, `CHANGELOG.md`.

## Arquivos proibidos

Credenciais reais, mTLS sem decisão, nuvem comercial, funcionalidades fora do MVP.

## Critérios de aceite

- Interfaces aprovadas usam TLS.
- Tokens são validados sem segredos versionados.
- Eventos de auditoria são persistidos e consultáveis.

## Testes obrigatórios

Testes de autenticação/autorização, TLS, acesso negado e auditoria.

## Resultado esperado

Perímetro do MVP protegido e auditável.
