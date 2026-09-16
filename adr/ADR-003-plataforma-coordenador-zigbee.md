# ADR-003 - Plataforma do coordenador Zigbee

## Status

Aprovado.

## Contexto

O MVP requer um coordenador capaz de formar e manter uma rede Zigbee interoperável. TASK-033 validou a plataforma física, stack e fronteira de abstração, mantendo o servidor, domínio, persistência e APIs independentes da Espressif.

## Decisão

- Usar Seeed Studio XIAO ESP32-C6 como plataforma do coordenador inicial.
- Usar ESP-IDF e ESP Zigbee SDK oficiais para firmware do coordenador.
- Responsabilizar o coordenador pela formação/restauração da rede, network steering, permit-join, descoberta ZDO, operações ZCL, reports, comandos, estado da rede e informações de enlace disponíveis.
- Usar `coordinator_adapter` como a fronteira que encapsula ESP-IDF, ESP Zigbee SDK e operações de transporte aprovadas.
- Proibir que APIs específicas da Espressif vazem para domínio, servidor, persistência, APIs administrativas ou Home Assistant.

## Consequências

- TASK-007 pode implementar a integração sem acoplar os demais módulos ao firmware do coordenador.
- Versões compatíveis de ESP-IDF e ESP Zigbee SDK, memória, estabilidade e recuperação do coordenador devem ser qualificadas na implementação.
- Alternativas de rádio futuras só podem substituir a implementação atrás de `coordinator_adapter`, preservando seus contratos normalizados.

## Alternativas consideradas

- TI CC2652P/CC2652RB com ZNP: mantido como fallback futuro, não adotado como plataforma principal do MVP.
- Silicon Labs EFR32MG21/MG24: alternativa futura, não adotada como plataforma inicial.

## Rastreabilidade

TASK-033; RFC-007; ADR-002; `docs/COORDINATOR_INTEROPERABILITY_ARCHITECTURE.md`; `docs/ARCHITECTURE.md`; TASK-007; TASK-019.
