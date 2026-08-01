# TASK-004 — Fundação do firmware e HAL

## Objetivo

Implementar a base modular do firmware proprietário com HAL desacoplada.

## Contexto

O Playbook exige firmware proprietário e HAL desacoplada para o MVP ESP32-C6.

## Dependências

TASK-003, TASK-015 e TASK-029 validadas e decisões de SDK/toolchain aprovadas em ADR.

## Escopo

Criar estrutura de firmware, interfaces HAL e testes unitários definidos, sem funcionalidades não especificadas.

## Arquivos permitidos

`firmware/`, `docs/`, `adr/`, `tasks/TASK-004.md`, `CHANGELOG.md`.

## Arquivos proibidos

`server/`, `hardware/`, OTA, IA, Home Assistant, credenciais.

## Critérios de aceite

- HAL não depende da lógica de domínio e possui fronteiras compatíveis com segurança e OTA aprovadas.
- Estrutura é modular e compilável na plataforma aprovada.
- Decisões tecnológicas são justificadas e registradas.

## Testes obrigatórios

Compilação reprodutível e testes unitários das interfaces HAL.

## Resultado esperado

Fundação de firmware testada, pronta para dispositivos do MVP.
