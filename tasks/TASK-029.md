# TASK-029 — Arquitetura de segurança e identidade do MVP

## Objetivo

Definir e validar os requisitos arquiteturais de segurança, identidade, autenticação, autorização, auditoria e gestão de chaves do MVP.

## Contexto

O Playbook determina TLS, tokens, auditoria, OTA assinada e evolução para mTLS. A malha Zigbee e a comunicação com o servidor precisam de limites de confiança e identidade documentados antes das implementações.

## Dependências

TASK-001 validada.

## Escopo

Produzir RFCs para identidade e comissionamento Zigbee, comunicação coordenador-servidor, tokens, TLS, auditoria, rotação/revogação de credenciais e interfaces com OTA. Registrar ADRs somente para decisões aprovadas. Não implementar controles, emitir credenciais ou executar testes de segurança; a TASK-012 implementará os controles aprovados.

## Arquivos permitidos

`docs/`, `rfc/`, `adr/`, `tasks/TASK-029.md`, `CHANGELOG.md`.

## Arquivos proibidos

`firmware/`, `server/`, credenciais, certificados, chaves reais, OTA funcional e serviços remotos.

## Critérios de aceite

- Limites de confiança e identidades do MVP estão documentados.
- Comissionamento Zigbee, tokens, TLS, auditoria e gestão do ciclo de vida de chaves possuem requisitos verificáveis.
- Toda decisão necessária está aprovada em ADR ou identificada como bloqueio explícito.

## Testes obrigatórios

Revisão de ameaças e de rastreabilidade contra as seções 7, 8, 10 e 12 do Playbook.

## Resultado esperado

Base de segurança aprovada para contratos, firmware, servidor, API e OTA.
