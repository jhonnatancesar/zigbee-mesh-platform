# TASK-017 — Política e pré-análise de IA

## Objetivo

Definir a política de risco e os contratos de pré-análise local da IA.

## Contexto

O Playbook exige pré-análise local, consulta externa quando necessária, automação apenas em baixo risco e justificativa registrada para toda decisão.

## Dependências

TASK-001, TASK-002 e TASK-029 validadas.

## Escopo

Documentar classificação de risco, gatilhos, dados mínimos, aprovação humana, consulta externa e registros obrigatórios; não implementar modelos, executar decisões ou integrar consultas externas. A TASK-018 executará exclusivamente a política aprovada.

## Arquivos permitidos

`docs/`, `adr/`, `rfc/`, `tasks/TASK-017.md`, `CHANGELOG.md`.

## Arquivos proibidos

`server/`, modelos de IA, credenciais externas, execução automática não aprovada.

## Critérios de aceite

- Baixo, médio e alto risco possuem tratamento explícito.
- Toda decisão requer motivo, rastreabilidade e requisitos de persistência explícitos para a TASK-009.
- Consulta externa é opcional, controlada e não expõe segredos.

## Testes obrigatórios

Revisão de política com cenários de baixo, médio e alto risco.

## Resultado esperado

Política de IA aprovada e implementável sem ambiguidade.
