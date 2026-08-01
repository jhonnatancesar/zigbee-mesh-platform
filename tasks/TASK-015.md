# TASK-015 — Especificação de OTA segura

## Objetivo

Definir o processo de OTA assinado e rollback para coordenador, router e end device.

## Contexto

O Playbook exige OTA para os três papéis, verificando bateria, enlace, integridade e rollback.

## Dependências

TASK-001, TASK-002, TASK-003 e TASK-029 validadas.

## Escopo

Documentar fluxo, chaves, assinatura, critérios de elegibilidade, estados, telemetria e recuperação; não implementar OTA, distribuir artefatos ou executar atualizações. A TASK-016 executará exclusivamente a especificação aprovada.

## Arquivos permitidos

`docs/`, `adr/`, `rfc/`, `tasks/TASK-015.md`, `CHANGELOG.md`.

## Arquivos proibidos

`firmware/`, `server/`, artefatos de atualização, chaves reais.

## Critérios de aceite

- Os três papéis possuem fluxo documentado e requisitos de inicialização/armazenamento de firmware identificados.
- Bateria, enlace, integridade e rollback possuem regras verificáveis.
- Assinatura e gestão de chaves aguardam/aplicam decisão aprovada.

## Testes obrigatórios

Revisão de ameaça e simulação documental de êxito, recusa e rollback.

## Resultado esperado

Especificação OTA aprovada e segura para implementação posterior.
