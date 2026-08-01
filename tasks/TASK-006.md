# TASK-006 — Firmware de router Zigbee

## Objetivo

Implementar o firmware do router Zigbee do MVP.

## Contexto

Routers são componentes explícitos da malha Zigbee e mudanças de rota devem ser registráveis.

## Dependências

TASK-002 e TASK-004 validadas.

## Escopo

Implementar o papel de router e a emissão dos eventos/diagnósticos de rota aprovados.

## Arquivos permitidos

`firmware/`, `docs/`, `tasks/TASK-006.md`, `CHANGELOG.md`.

## Arquivos proibidos

`server/`, OTA, IA, Home Assistant, recursos fora do papel de router.

## Critérios de aceite

- Router ingressa e mantém a malha no ambiente de teste.
- Eventos de rota e falhas seguem o contrato.
- Não há acoplamento com servidor ou cliente Home Assistant.

## Testes obrigatórios

Compilação, testes unitários e ensaio de encaminhamento/mudança de rota.

## Resultado esperado

Router Zigbee funcional e observável conforme requisitos aprovados.
