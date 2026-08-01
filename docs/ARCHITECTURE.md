# Arquitetura - principios e restricoes iniciais

Este documento consolida somente diretrizes ja determinadas pelo Playbook. Nao aprova tecnologias, protocolos internos, contratos de API ou desenho detalhado de modulos.

## Principios obrigatorios

- Arquitetura modular e orientada a eventos.
- Banco proprio como fonte da verdade.
- Home Assistant como cliente, nunca como fonte da verdade.
- APIs destinadas a administracao.
- Firmware proprietario com HAL desacoplada; ESP32-C6 e a plataforma prevista para o MVP.
- Compatibilidade com dispositivos Zigbee de terceiros.
- Prioridade para baixo consumo, simplicidade, manutencao, escalabilidade e desacoplamento.

## Limites de responsabilidade

| Dominio | Responsabilidade estabelecida | Nao estabelecido nesta TASK |
| --- | --- | --- |
| Malha Zigbee | Coordenador, routers e end devices do MVP | Tecnologia concreta do coordenador e contratos detalhados |
| Firmware | Firmware proprietario e HAL desacoplada | SDK, toolchain e implementacao |
| Servidor local | Processamento da plataforma, APIs administrativas e dados | Framework, runtime e desenho de modulos |
| Dados | Fonte da verdade e retencao prioritaria | Tecnologia, esquema fisico e migracoes |
| Home Assistant | Cliente da plataforma | Metodo e contrato de integracao |
| IA | Pre-analise local e decisao controlada por risco | Modelo, fornecedor e mecanismo de execucao |
| OTA | Assinada, com verificacoes e rollback | Formato, distribuicao e gestao de chaves |

## Proximo refinamento

A TASK-001 deve produzir a arquitetura detalhada, os limites de modulos e os fluxos de eventos, usando RFCs para questoes pendentes e ADRs somente para decisoes aprovadas.
