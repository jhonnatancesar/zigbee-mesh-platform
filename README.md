# Zigbee Mesh Platform

Plataforma própria de IoT iniciada por uma malha Zigbee. O MVP previsto no Playbook contempla coordenador, routers, end devices, sensor proprietário de temperatura/umidade, Home Assistant, API, banco de dados próprio, IA, OTA e servidor local.

Este repositorio concluiu as TASKs 000 e 001. Nao ha implementacao funcional, dependencias ou escolhas de framework aprovadas nesta etapa.

## Princípios

- Arquitetura modular e orientada a eventos.
- Banco próprio como fonte da verdade; Home Assistant atua como cliente.
- Segurança com TLS e tokens no MVP, com evolução prevista para mTLS.
- Compatibilidade com dispositivos Zigbee de terceiros.
- Firmware proprietário desacoplado por HAL, com ESP32-C6 previsto para o MVP.

## Estrutura

O [índice da documentação](docs/README.md) concentra contexto, roadmap, arquitetura de princípios, decisões e rastreabilidade. O [backlog](tasks/README.md) contém as TASKs. Novas sugestões devem seguir a [triagem de ideias](docs/IDEA_TRIAGE.md); toda TASK deve passar pelo [Gate de Qualidade](docs/QUALITY_GATE.md) antes de iniciar e pelo [encerramento obrigatório](docs/TASK_CLOSURE.md) ao terminar. As regras operacionais estão em [AGENTS.md](AGENTS.md) e o processo de contribuição em [CONTRIBUTING.md](CONTRIBUTING.md).

## Estado

Aguardando autorizacao para a proxima TASK, que continuara sujeita ao Gate de Qualidade.
