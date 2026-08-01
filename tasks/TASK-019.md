# TASK-019 — Interoperabilidade Zigbee de terceiros

## Objetivo

Validar e corrigir a compatibilidade do MVP com dispositivos Zigbee de terceiros aprovados.

## Contexto

O Playbook exige compatibilidade com dispositivos Zigbee de terceiros.

## Dependências

TASK-007, TASK-010, TASK-011, TASK-012 e TASK-013 validadas.

## Escopo

Executar matriz de interoperabilidade aprovada, registrar resultados e implementar somente correções necessárias aos contratos do MVP.

## Arquivos permitidos

`firmware/`, `server/`, `docs/`, `tasks/TASK-019.md`, `CHANGELOG.md`.

## Arquivos proibidos

Recursos exclusivos de fabricante não aprovados, expansão para LoRa, interface própria, nuvem comercial.

## Critérios de aceite

- Casos aprovados de pareamento, telemetria e estabilidade passam.
- Incompatibilidades são documentadas e rastreáveis.
- Correções não degradam os dispositivos proprietários.

## Testes obrigatórios

Matriz de testes com dispositivos de terceiros definidos e regressão da malha própria.

## Resultado esperado

Compatibilidade Zigbee do MVP demonstrada por evidências de teste.
