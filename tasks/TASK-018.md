# TASK-018 — Implementação da pré-análise de IA

## Objetivo

Implementar pré-análise local e o fluxo de decisão de IA conforme a política aprovada.

## Contexto

IA é requisito do MVP, com execução automática somente em baixo risco e registro integral de decisões.

## Dependências

TASK-009, TASK-010, TASK-012, TASK-014 e TASK-017 validadas.

## Escopo

Implementar o mecanismo de pré-análise, classificação, encaminhamento e auditoria estritamente conforme a política aprovada na TASK-017; consulta externa apenas se autorizada e sem redefinir níveis de risco ou critérios de decisão.

## Arquivos permitidos

`server/`, `docs/`, `tasks/TASK-018.md`, `CHANGELOG.md`.

## Arquivos proibidos

Automação de médio/alto risco, credenciais, IA distribuída, alterações de firmware fora do contrato.

## Critérios de aceite

- Decisões são classificadas e justificadas.
- Apenas baixo risco pode executar automaticamente quando permitido.
- Dados e justificativas são persistidos e auditáveis.

## Testes obrigatórios

Testes de classificação, bloqueio de risco, auditoria e indisponibilidade de consulta externa.

## Resultado esperado

Pré-análise de IA controlada, auditável e limitada à política do MVP.
