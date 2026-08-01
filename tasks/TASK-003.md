# TASK-003 — Especificação do sensor e plataforma embarcada

## Objetivo

Documentar requisitos do sensor proprietário de temperatura/umidade e da plataforma ESP32-C6 prevista para o MVP, incluindo a metodologia de validação física que será executada futuramente pela TASK-031.

## Contexto

O Playbook requer sensor proprietário e firmware com HAL desacoplada, indicando ESP32-C6 para o MVP; não fornece componentes nem limites físicos.

## Dependências

TASK-001 e TASK-002 validadas.

## Escopo

Produzir especificação funcional e critérios de aceitação de hardware/energia, interfaces e HAL; definir a metodologia futura de ensaios físicos, sem executá-la. A metodologia deve estabelecer, quando aplicável: ensaios, calibração, precisão, consumo energético, autonomia, alcance e qualidade do enlace, instrumentos necessários, critérios de aprovação e forma de registro dos resultados. Registrar lacunas como RFC.

## Arquivos permitidos

`hardware/`, `firmware/`, `docs/`, `rfc/`, `adr/`, `tasks/TASK-003.md`, `CHANGELOG.md`.

## Arquivos proibidos

Esquemáticos finais, PCB, firmware funcional, bibliotecas, compras, execução de ensaios e validação de hardware.

## Critérios de aceite

- Requisitos de medição, energia e interfaces estão documentados.
- A metodologia de validação física da TASK-031 define critérios, instrumentos, evidências e condições de aprovação para cada ensaio aplicável.
- A metodologia separa explicitamente a definição documental da execução prática futura.
- O limite entre HAL e aplicação está definido conceitualmente.
- Itens não definidos pelo Playbook estão pendentes de validação.

## Testes obrigatórios

Revisão documental da metodologia, dos requisitos e da rastreabilidade com as seções 5, 9, 18 e 19 do Playbook; não executar ensaios.

## Resultado esperado

Especificação aprovada para orientar as TASKs de firmware e hardware, incluindo um plano de validação física executável exclusivamente pela TASK-031.
