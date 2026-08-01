# TASK-020 — Validação integrada do MVP

## Objetivo

Validar o MVP completo contra o Playbook e consolidar sua documentação operacional.

## Contexto

O MVP reúne Zigbee, sensor, servidor local, dados, API, segurança, Home Assistant, OTA e IA.

## Dependências

TASK-005, TASK-006, TASK-007, TASK-008, TASK-009, TASK-010, TASK-011, TASK-012, TASK-013, TASK-014, TASK-015, TASK-016, TASK-017, TASK-018 e TASK-019 validadas.

## Escopo

Executar testes ponta a ponta aprovados, revisar documentação e registrar lacunas; não adicionar funcionalidades.

## Arquivos permitidos

`docs/`, `tasks/TASK-020.md`, `README.md`, `CHANGELOG.md` e correções estritamente necessárias nos componentes do MVP.

## Arquivos proibidos

Funcionalidades V2/futuras, LoRa, hardware próprio, interface própria, nuvem comercial.

## Critérios de aceite

- Todos os itens obrigatórios do MVP possuem evidência de aceite; nenhum pode ser dispensado sem alteração explícita e validada do Playbook.
- Fluxos críticos são testados ponta a ponta.
- Lacunas restantes são registradas sem ocultação.

## Testes obrigatórios

Testes ponta a ponta de malha, dados, API, segurança, Home Assistant, OTA, IA e interoperabilidade.

## Resultado esperado

MVP validado ou lacunas objetivamente registradas para decisão.
