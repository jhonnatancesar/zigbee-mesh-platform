# TASK-001 — Baseline arquitetural e decisões pendentes

## Objetivo

Transformar as diretrizes do Playbook em arquitetura verificável e registrar decisões pendentes como RFC/ADR conforme validação.

## Contexto

O MVP exige modularidade, eventos, banco como fonte da verdade, Home Assistant como cliente e segurança progressiva; o Playbook não fixa tecnologias.

## Dependências

TASK-000 validada.

## Escopo

Documentar limites de módulos, fluxos de eventos, responsabilidades e critérios para decisões de tecnologia, sem implementar componentes.

## Arquivos permitidos

`docs/`, `adr/`, `rfc/`, `tasks/TASK-001.md`, `README.md`, `CHANGELOG.md`.

## Arquivos proibidos

`firmware/`, `server/`, dependências, código funcional, credenciais.

## Critérios de aceite

- Limites e fluxos do MVP estão documentados.
- Toda escolha ainda não validada está explicitamente pendente.
- ADRs só registram decisões aprovadas.

## Testes obrigatórios

Revisão de rastreabilidade contra as seções 5, 7, 8, 9, 10, 11 e 12 do Playbook.

## Resultado esperado

Base arquitetural documental aprovada para orientar as TASKs de implementação.
