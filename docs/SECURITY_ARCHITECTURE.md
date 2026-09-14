# Arquitetura de seguranca do MVP

## Objetivo e limites de confianca

O MVP possui quatro limites: dispositivo Zigbee, coordenador, servidor local e clientes administrativos/Home Assistant. Nenhum cliente externo e fonte da verdade. O servidor local registra eventos, auditoria e estado; dispositivos e coordenador nunca recebem privilegio administrativo por implicacao.

## Requisitos verificaveis

| Area | Requisito | Evidencia esperada |
| --- | --- | --- |
| Identidade Zigbee | Cada dispositivo aceito deve ter identidade, estado de comissionamento e trilha de origem rastreaveis. | Registro de comissionamento, recusas e mudancas de estado. |
| Coordenador-servidor | Todo trafego fora da fronteira Zigbee usa canal autenticado, confidencial e protegido contra adulteracao. | Configuracao sem segredos versionados e auditoria de falhas de canal. |
| API administrativa | Toda operacao exige autenticacao, autorizacao por privilegio minimo e auditoria correlacionavel. | Registro de solicitante, acao, alvo, resultado e motivo de recusa. |
| Tokens e TLS | Tokens possuem ciclo de vida, escopo, expiracao, revogacao e nao podem ser persistidos em texto claro nos logs. TLS e requisito do MVP; mTLS permanece evolucao planejada, nao controle implicitamente ativo. | Testes de expiracao, revogacao, escopo e recusa de canal inseguro na TASK-012. |
| OTA | Artefatos exigem assinatura, verificacao de integridade, elegibilidade e rollback; chaves privadas nunca entram no repositorio. | Eventos de aceite, recusa, falha e rollback. |
| Auditoria | Eventos de seguranca sao imutavelmente rastreaveis no nivel de aplicacao e submetidos a retencao aprovada. | Consulta administrativa e correlacao com evento de origem. |

## Fluxos de seguranca

```text
Comissionamento: solicitacao -> verificacao de identidade e autorizacao -> registro -> estado aceito ou recusado
Administracao: cliente -> TLS -> autenticacao -> autorizacao -> acao -> auditoria e resultado
OTA: operacao autorizada -> artefato assinado -> verificacao no destino -> evento -> rollback quando aplicavel
```

## Ameaças e respostas obrigatorias

- Dispositivo nao autorizado, replay ou comissionamento indevido: identidade unica, estado explicito, autorizacao e registro de recusa.
- Interceptacao ou adulteracao coordenador-servidor: canal protegido, autenticacao de pares e falha fechada.
- Token roubado ou excessivamente privilegiado: escopo minimo, expiracao, revogacao, nao exposicao em logs e auditoria.
- OTA maliciosa ou corrompida: assinatura, integridade, elegibilidade, rollback e rastreabilidade.
- Escalada administrativa ou perda de auditoria: autorizacao explicita, correlacao e recusa observavel.

## Pendencias e nao decisoes

Algoritmos, formatos de token, autoridade de certificacao, protocolo concreto de coordenador, armazenamento de chaves, mecanismo de mTLS e formato de assinatura nao foram escolhidos. Eles exigem analise e aprovacao em ADR antes de qualquer implementacao. RFC-002, RFC-003 e RFC-004 detalham essas pendencias.
