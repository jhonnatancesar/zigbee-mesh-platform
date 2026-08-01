# Contribuindo

## Pre-requisitos de trabalho

Antes de alterar o repositorio, leia `Playbook_Codex_ZigbeeMesh_v1.md`, `AGENTS.md`, a TASK autorizada e a documentacao relacionada. O Playbook e a autoridade maxima.

## Processo obrigatorio

O identificador da TASK é suficiente para iniciar o fluxo completo. Consulte `AGENTS.md` para a sequência automática obrigatória. Após o Gate de Qualidade aprovado, trabalhe exclusivamente na TASK solicitada, atualize documentação, execute testes, realize autoavaliação e apresente o encerramento obrigatório antes de aguardar validação.

Após a validação, o comando explícito `Commit` autoriza somente o commit da TASK concluída e `Push` autoriza somente seu envio normal ao remoto configurado. Nenhum dos dois comandos autoriza a próxima TASK.

Nao inclua credenciais. Nao faca escolhas de tecnologia sem justificativa e decisao registrada. Duvidas devem ser registradas em RFC ou na TASK pertinente para validacao.

## Novas ideias

Antes de propor mudanca de escopo, TASK ou backlog, realize a triagem descrita em `docs/IDEA_TRIAGE.md`. O resultado deve ser justificado e nenhuma alteracao no backlog pode ocorrer sem autorizacao explicita do usuario.

## Documentacao

- Use `docs/templates/TASK_TEMPLATE.md` para novas TASKs.
- Use `docs/templates/RFC_TEMPLATE.md` para propostas que aguardam validacao.
- Use `docs/templates/ADR_TEMPLATE.md` somente apos a decisao estar aprovada.
- Atualize `CHANGELOG.md`, os indices e a rastreabilidade quando aplicavel.
- Registre ideias futuras aprovadas somente em `docs/FUTURE_BACKLOG.md`.
- Aplique o Gate de Qualidade antes de qualquer inicio de TASK e registre seu resultado na conversa da TASK.
- Apresente automaticamente o encerramento completo de TASK conforme `docs/TASK_CLOSURE.md`.
