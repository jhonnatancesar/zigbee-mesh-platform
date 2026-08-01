# TASK-007 — Integração do coordenador Zigbee

## Objetivo

Integrar o coordenador Zigbee ao contrato de eventos do MVP.

## Contexto

O coordenador é componente do MVP; sua tecnologia específica depende de decisão aprovada.

## Dependências

TASK-001, TASK-002, TASK-008 e TASK-029 validadas e decisão de coordenador aprovada em ADR.

## Escopo

Implementar a integração de rede, comissionamento/pareamento permitido e publicação dos eventos aprovados para a fundação do servidor, preservando compatibilidade de terceiros.

## Arquivos permitidos

`firmware/`, `server/`, `docs/`, `adr/`, `tasks/TASK-007.md`, `CHANGELOG.md`.

## Arquivos proibidos

API administrativa, banco, OTA, IA, Home Assistant fora dos contratos necessários.

## Critérios de aceite

- Coordenador estabelece malha de teste.
- End device e router aprovados podem ingressar.
- Eventos e diagnósticos seguem a especificação.

## Testes obrigatórios

Teste de formação de rede, pareamento e interoperabilidade com dispositivo Zigbee de terceiros.

## Resultado esperado

Coordenador integrado e apto a alimentar a plataforma local.
