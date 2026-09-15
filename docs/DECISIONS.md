# Decisoes e propostas

## Estado atual

TASK-034 é responsável por pesquisar e propor a plataforma do servidor local. Runtime, framework, concorrência, comunicação com `coordinator_adapter`, eventos internos, empacotamento e deploy permanecem pendentes; banco definitivo continua reservado à TASK-009.

TASK-033 foi validada e produziu a RFC-007 e a arquitetura do coordenador. A direcao XIAO ESP32-C6 com ESP Zigbee SDK, a fronteira `coordinator_adapter`, admission e o modelo de capacidades foram aprovados conceitualmente. A formalizacao em ADR continua necessaria antes da TASK-007; nenhum ADR foi criado.

TASK-029 documenta requisitos e pendencias de seguranca em `docs/SECURITY_ARCHITECTURE.md` e RFCs 002 a 004. Nenhum algoritmo, fornecedor ou mecanismo concreto foi aprovado.

A TASK-001 adicionou [RFC-001](../rfc/RFC-001.md) para mapear as pendencias. Nenhuma decisao tecnica foi aprovada por ela.

Nenhuma decisao de tecnologia, framework, SDK, banco, protocolo, hardware ou fornecedor foi aprovada na TASK-000.

## Uso de RFC e ADR

| Artefato | Quando usar | Estado |
| --- | --- | --- |
| RFC | Ha uma proposta ou uma duvida que precisa de analise e validacao | Pendente de aprovacao |
| ADR | Uma decisao arquitetural foi aprovada | Registrada como decisao vigente |

Uma RFC nao e uma decisao. Um ADR nao deve registrar hipotese, escolha unilateral ou decisao ainda pendente.

## Relação com novas ideias

Antes de uma sugestão se tornar RFC, ADR ou TASK, ela deve passar pela triagem de produto em `IDEA_TRIAGE.md`. A triagem define se a proposta pertence à versão atual, a uma versão futura, à pesquisa ou ao descarte; RFC/ADR tratam apenas de análise e decisão técnica quando cabíveis.

## Registro inicial de questoes em aberto

- Tecnologia e implementacao do coordenador Zigbee.
- SDK/toolchain do ESP32-C6 e fronteiras concretas da HAL.
- Tecnologia do servidor local, banco e mecanismo de eventos.
- Contratos das APIs administrativas e da integracao com Home Assistant.
- Modelo de seguranca de tokens, TLS e evolucao para mTLS.
- Assinatura, distribuicao e gestao de chaves para OTA.
- Politica operacional e mecanismos da IA.

Essas questoes sao tratadas pelas TASKs `001`, `002`, `003`, `015`, `017`, `029` e `030` e exigem validacao antes de qualquer escolha.
