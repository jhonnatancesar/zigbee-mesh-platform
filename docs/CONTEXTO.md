# Contexto do projeto

Navegação complementar: [índice documental](README.md), [roadmap](ROADMAP.md), [arquitetura de princípios](ARCHITECTURE.md) e [rastreabilidade](TRACEABILITY.md).

## Missão

Construir uma plataforma própria de IoT, iniciando com Zigbee Mesh e evoluindo, fora do escopo do MVP, para LoRa, hardware e protocolo próprios, coordenador móvel, acesso remoto, IA distribuída, multi-servidor e marketplace de dispositivos.

## Escopo do MVP

Inclui coordenador Zigbee, routers, end devices, sensor proprietário de temperatura/umidade, Home Assistant, API, banco próprio, IA, OTA e servidor local.

Exclui LoRa, hardware próprio, interface própria e nuvem comercial.

## Diretrizes arquiteturais

A plataforma deve ser modular, orientada a eventos e expor APIs administrativas. O banco próprio é a fonte da verdade; Home Assistant é cliente. Devem ser priorizados baixo consumo, simplicidade, manutenção, escalabilidade e desacoplamento.

## Segurança, retenção e operação

O MVP prevê TLS e tokens, com evolução para mTLS. OTA deve ser assinada e oferecer rollback. O banco deve registrar medições, falhas, mudanças de rota, OTA, decisões e justificativas da IA e diagnósticos. A retenção prioriza falhas, mudanças de rota, decisões da IA, eventos e medições, nessa ordem.

## Governança

As decisões ainda não aprovadas devem ser registradas em RFC; decisões aprovadas, em ADR. Toda nova ideia deve ser classificada conforme `IDEA_TRIAGE.md` antes de afetar o escopo. Consulte o backlog em `tasks/` antes de iniciar qualquer trabalho.
