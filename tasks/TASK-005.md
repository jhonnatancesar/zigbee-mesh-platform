# TASK-005 — Firmware do end device sensor

## Objetivo

Implementar o firmware do sensor proprietário de temperatura/umidade como end device Zigbee.

## Contexto

O sensor proprietário é parte explícita do MVP e deve respeitar os requisitos de consumo e HAL aprovados.

## Dependências

TASK-002, TASK-003, TASK-004 e TASK-031 validadas.

## Escopo

Implementar leitura, publicação de telemetria e diagnósticos definidos para o end device; registrar falhas previstas.

## Arquivos permitidos

`firmware/`, `docs/`, `tasks/TASK-005.md`, `CHANGELOG.md`.

## Arquivos proibidos

`server/`, `hardware/` de produção, OTA, IA, Home Assistant.

## Critérios de aceite

- Temperatura e umidade seguem o contrato aprovado e os limites de precisão/calibração definidos.
- Dispositivo opera como end device e respeita os requisitos de energia mensuráveis definidos na TASK-003.
- Falhas e diagnósticos previstos são emitidos conforme contrato.

## Testes obrigatórios

Compilação, testes unitários, teste em hardware e teste de entrada/saída Zigbee.

## Resultado esperado

End device sensor interoperável no ambiente de teste aprovado.
