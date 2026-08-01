# TASK-014 — Observabilidade e diagnósticos operacionais

## Objetivo

Consolidar consulta e rastreabilidade de falhas, rotas, eventos e diagnósticos do MVP.

## Contexto

O Playbook exige registrar falhas, mudanças de rota, eventos e diagnósticos, com alta prioridade de retenção para falhas e rotas.

## Dependências

TASK-009, TASK-010, TASK-011 e TASK-012 validadas.

## Escopo

Implementar as consultas administrativas e a documentação operacional para os registros já definidos.

## Arquivos permitidos

`server/`, `docs/`, `tasks/TASK-014.md`, `CHANGELOG.md`.

## Arquivos proibidos

IA de ação, OTA, interface própria, nuvem comercial.

## Critérios de aceite

- Falhas e rotas são localizáveis por meio da API aprovada.
- Diagnósticos preservam rastreabilidade até o evento de origem.
- Retenção não viola a prioridade definida.

## Testes obrigatórios

Testes de consulta, rastreabilidade e retenção sob carga representativa aprovada.

## Resultado esperado

Operação local capaz de diagnosticar a malha e a plataforma.
