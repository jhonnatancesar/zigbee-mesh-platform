# ADR-002 - Fronteira entre coordenador e servidor

## Status

Aprovado.

## Contexto

O coordenador XIAO ESP32-C6 executa ESP-IDF e ESP Zigbee SDK, enquanto o servidor local opera C#/.NET. O domínio, APIs, persistência e Home Assistant não podem conhecer APIs Espressif nem um transporte concreto. Eventos e comandos precisam preservar contratos versionados, correlação, autenticação, auditoria, reconexão e comportamento seguro sob falha.

## Decisão

- `coordinator_adapter` encapsula ESP Zigbee SDK e a seleção de transporte.
- USB/Serial é o transporte primário entre coordenador e servidor local.
- Wi-Fi é transporte secundário; quando usado, emprega WebSocket sobre TLS e autenticação por token conforme a arquitetura de segurança aprovada.
- `coordinator_adapter` normaliza operações e eventos nos contratos da TASK-002, administra reconexão, estado de conexão, correlação e erros de transporte.
- Domínio, APIs, persistência e integração Home Assistant dependem apenas das interfaces normalizadas do adaptador, nunca de USB/Serial, Wi-Fi, WebSocket ou ESP-IDF.
- A proteção do enlace USB/Serial deve considerar acesso físico, identidade do adaptador e configuração externa sem segredos no repositório; detalhes concretos serão implementados e testados nas TASKs consumidoras.

## Consequências

- A TASK-007 pode integrar a malha sem acoplar o servidor à Espressif ou a um único transporte.
- Wi-Fi/TLS mantém confidencialidade e autenticação quando o enlace não é físico local.
- Reconexão, idempotência e falhas devem ser observáveis e auditáveis; ausência de conexão não permite descartar comandos ou eventos silenciosamente.
- A implementação precisa qualificar bibliotecas seriais/WebSocket e os limites de reconexão antes de uso em produção.

## Alternativas consideradas

- Wi-Fi/WebSocket-TLS como transporte único: não escolhido como primário porque USB/Serial reduz dependência de rede local.
- USB/Serial exposto diretamente ao domínio: rejeitado por acoplar transporte, hardware e SDK à lógica de negócio.
- NCP de outro fornecedor: mantido como fallback futuro, mas não altera a fronteira normalizada definida neste ADR.

## Rastreabilidade

TASK-033; TASK-034; RFC-007; RFC-008; `docs/COORDINATOR_INTEROPERABILITY_ARCHITECTURE.md`; `docs/SERVER_PLATFORM_EVALUATION.md`; `docs/CONTRACTS.md`; `docs/SECURITY_ARCHITECTURE.md`; TASK-007; TASK-008; TASK-019.
