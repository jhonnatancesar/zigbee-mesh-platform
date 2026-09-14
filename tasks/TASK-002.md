# TASK-002 — Contratos de eventos, dados e API administrativa

## Status

Concluida e validada em 2026-09-14. Os contratos permanecem conceituais; nenhuma interface, persistencia, firmware ou esquema executavel foi implementado.

## Objetivo

Especificar contratos verificáveis para dispositivos, telemetria, eventos, dados, diagnósticos, retenção e API administrativa do MVP.

## Contexto

O Playbook determina registros obrigatórios e prioridade de retenção, além de compatibilidade Zigbee de terceiros.

## Dependências

TASK-001 e TASK-029 validadas.

## Escopo

Definir contratos documentais para medições, falhas, rotas, OTA, decisões de IA, justificativas, diagnósticos, interoperabilidade e API administrativa. Definir versionamento, validação, erros, idempotência e rastreabilidade necessários; não implementar interfaces, persistência ou firmware. As TASKs consumidoras executarão os contratos aprovados.

## Arquivos permitidos

`docs/`, `adr/`, `rfc/`, `tasks/TASK-002.md`, `CHANGELOG.md`.

## Arquivos proibidos

`server/`, `firmware/`, migrações, esquemas executáveis, API funcional.

## Critérios de aceite

- Cada registro obrigatório possui campos conceituais e prioridade de retenção.
- Eventos possuem produtor, consumidor e propósito documentados.
- Requisitos de compatibilidade são verificáveis.
- Operações administrativas possuem contratos, versão, erros e regras de autorização definidos ou bloqueios explícitos registrados.

## Testes obrigatórios

Revisão do inventário contra as seções 10 e 18 do Playbook.

## Resultado esperado

Especificação aprovada que permita implementar dados e eventos sem ampliar escopo.
