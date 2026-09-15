# TASK-033 — Decisão do coordenador Zigbee e interoperabilidade base

## Status

FORMALMENTE CONCLUÍDA E VALIDADA. Nenhuma ADR foi criada e nenhuma implementação foi iniciada.

## Objetivo

Definir a base arquitetural e as decisões propostas para um coordenador Zigbee capaz de criar e manter rede interoperável por padrões e capacidades anunciadas.

## Dependências

TASK-001, TASK-002, TASK-029 e TASK-030 validadas.

## Escopo

Pesquisar e propor plataforma/arquitetura do coordenador; commissioning/permit-join; autorização; descoberta de dispositivos, fabricante/modelo, endpoints e clusters; atributos, reports e comandos padrão; capacidades parciais; clusters desconhecidos/proprietários; persistência de capacidades; representação no servidor sem lista fixa de modelos; e requisitos para Home Assistant. Produzir RFCs e propostas de ADR para validação.

## Arquivos permitidos

`docs/`, `rfc/`, `adr/`, `tasks/TASK-033.md`, `CHANGELOG.md`.

## Arquivos proibidos

`firmware/`, `server/`, implementações específicas de marca/modelo, credenciais, hardware, testes formais de dispositivos comerciais e código executável.

## Critérios de aceite

- Interoperabilidade deriva de padrões e capacidades anunciadas, não de lista fixa de modelos.
- Dispositivo parcialmente reconhecido permanece seguro e observável.
- Clusters desconhecidos/proprietários não quebram a rede nem recebem comandos não suportados.
- Decisões propostas ficam explicitamente pendentes de validação/ADR.

## Testes obrigatórios

Revisão arquitetural contra contratos, segurança, TASK-007 e TASK-019.

## Resultado esperado

Base decisória aprovada para implementação do coordenador; TASK-019 continua responsável pela matriz e execução formal de interoperabilidade comercial.
