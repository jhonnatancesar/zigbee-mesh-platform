# TASK-013 — Integração com Home Assistant

## Objetivo

Integrar Home Assistant como cliente da plataforma.

## Contexto

O Playbook inclui Home Assistant no MVP e o define como cliente, não como fonte da verdade.

## Dependências

TASK-010, TASK-011 e TASK-012 validadas; contrato de integração aprovado.

## Escopo

Implementar somente a integração aprovada para consumo e administração permitidos, mantendo o banco local como autoridade.

## Arquivos permitidos

`server/`, `docs/`, `adr/`, `rfc/`, `tasks/TASK-013.md`, `CHANGELOG.md`.

## Arquivos proibidos

Interface própria, banco do Home Assistant como fonte da verdade, nuvem comercial, IA, OTA.

## Critérios de aceite

- Home Assistant consome os contratos aprovados.
- Estado persistido permanece controlado pela plataforma.
- Falhas de integração são diagnosticáveis.

## Testes obrigatórios

Teste de integração em ambiente isolado, contrato e recuperação de indisponibilidade.

## Resultado esperado

Home Assistant conectado como cliente interoperável.
