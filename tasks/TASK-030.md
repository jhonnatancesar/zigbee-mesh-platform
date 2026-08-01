# TASK-030 — Requisitos operacionais e não funcionais do servidor local

## Objetivo

Definir requisitos verificáveis de operação do servidor local e do banco próprio.

## Contexto

O MVP inclui servidor local e banco como fonte da verdade, com retenção prioritária e auditoria. A implementação precisa de critérios de capacidade, recuperação e operação para evitar decisões implícitas.

## Dependências

TASK-001 validada.

## Escopo

Documentar instalação, configuração não sensível, atualização, backup/restauração, recuperação de falhas, sincronização de tempo, capacidade, disponibilidade, retenção e evidências operacionais. Não implementar automação, infraestrutura ou ensaios operacionais; a TASK-008 e as TASKs consumidoras executarão os requisitos aprovados.

## Arquivos permitidos

`docs/`, `rfc/`, `adr/`, `tasks/TASK-030.md`, `CHANGELOG.md`.

## Arquivos proibidos

`server/`, `scripts/`, `tools/`, banco funcional, serviços de nuvem, credenciais e código executável.

## Critérios de aceite

- Cada requisito operacional possui condição mensurável ou bloqueio explicitamente registrado.
- Backup, restauração, tempo, retenção e falhas possuem critérios de validação.
- Não há escolha de ferramenta sem justificativa e validação.

## Testes obrigatórios

Revisão de requisitos operacionais, riscos e rastreabilidade com as seções 7, 8, 10 e 19 do Playbook.

## Resultado esperado

Especificação operacional aprovada para fundação do servidor, banco e observabilidade.
