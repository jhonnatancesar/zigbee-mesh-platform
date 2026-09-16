# ADR-004 - Commissioning e autorização Zigbee

## Status

Aprovado.

## Contexto

A rede precisa aceitar dispositivos Zigbee sem transformar ingresso técnico em autorização administrativa implícita. TASK-033 e RFC-002 definiram a separação entre commissioning, descoberta e autorização, com evidências auditáveis.

## Decisão

- O coordenador forma e restaura uma única rede local persistente; identidade, PAN, canal e material sensível seguem proteção operacional aprovada.
- Network steering é executado pelo coordenador dentro de janela de commissioning autorizada.
- Permit-join inicia fechado e só abre por ação administrativa autorizada, com ator, motivo, duração limitada, timeout, auditoria e fechamento explícito ou por expiração.
- Descoberta técnica após ingresso não equivale a autorização pelo servidor e não concede comandos privilegiados.
- O ciclo de estados é `solicitado -> verificado -> aceito | suspenso | revogado | removido`; cada transição exige instante, motivo, ator/origem e auditoria.
- Recusas, timeouts, falhas de descoberta e falhas de persistência são observáveis e auditáveis. Estado ambíguo mantém permit-join fechado.
- Reassociação, reconexão e alteração de endereço curto preservam a identidade IEEE quando comprovada e passam por transições/auditoria aplicáveis.

## Consequências

- A TASK-007 deve separar eventos de ingresso, descoberta, decisão de autorização e comandos.
- O servidor continua fonte de verdade para autorização; o coordenador não concede privilégios administrativos por conta própria.
- Recuperação de rede e reconexão precisam produzir evidência correlacionável, sem reabrir commissioning automaticamente.

## Alternativas consideradas

- Permit-join permanentemente aberto: rejeitado por aumentar ingresso indevido e reduzir auditabilidade.
- Autorizar automaticamente após discovery: rejeitado porque descoberta técnica não prova autorização administrativa.
- Identidade baseada apenas em endereço curto: rejeitada porque o endereço é mutável.

## Rastreabilidade

TASK-033; RFC-002; RFC-007; `docs/SECURITY_ARCHITECTURE.md`; `docs/COORDINATOR_INTEROPERABILITY_ARCHITECTURE.md`; `docs/CONTRACTS.md`; TASK-007; TASK-019.
