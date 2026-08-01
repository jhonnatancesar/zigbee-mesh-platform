# Contribuindo

## Pre-requisitos de trabalho

Antes de alterar o repositorio, leia `Playbook_Codex_ZigbeeMesh_v1.md`, `AGENTS.md`, a TASK autorizada e a documentacao relacionada. O Playbook e a autoridade maxima.

## Processo obrigatorio

1. Execute o Gate de Qualidade de `docs/QUALITY_GATE.md` antes de iniciar a TASK.
2. Trabalhe em uma unica TASK autorizada somente se o gate estiver aprovado.
3. Respeite integralmente o escopo e as listas de arquivos permitidos/proibidos.
4. Registre impactos e atualize a documentacao aplicavel.
5. Execute os testes obrigatorios da TASK e registre as evidencias previstas.
6. Apresente o encerramento obrigatório de `docs/TASK_CLOSURE.md` antes de declarar a TASK concluída.
7. Aguarde validacao antes de commit, push ou inicio da proxima TASK.

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
