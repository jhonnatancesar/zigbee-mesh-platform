# TASK-016 — Implementação de OTA segura

## Objetivo

Implementar OTA assinado e rollback conforme a especificação aprovada.

## Contexto

OTA é requisito do MVP para coordenador, router e end device.

## Dependências

TASK-005, TASK-006, TASK-007, TASK-009, TASK-012 e TASK-015 validadas.

## Escopo

Implementar distribuição, verificação, elegibilidade, registro e rollback estritamente conforme a especificação aprovada na TASK-015, sem redefinir seus requisitos de segurança ou critérios de elegibilidade.

## Arquivos permitidos

`firmware/`, `server/`, `docs/`, `tasks/TASK-016.md`, `CHANGELOG.md`.

## Arquivos proibidos

Chaves privadas versionadas, OTA não assinada, IA, Home Assistant fora do contrato.

## Critérios de aceite

- Atualizações inválidas são recusadas.
- Bateria, enlace e integridade são verificados.
- Falha produz rollback e registros auditáveis.

## Testes obrigatórios

Testes de assinatura, atualização por papel, corte de enlace, bateria insuficiente, corrupção e rollback.

## Resultado esperado

OTA segura e rastreável para os componentes Zigbee do MVP.
