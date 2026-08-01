# AGENTS.md

## Autoridade e escopo

- `Playbook_Codex_ZigbeeMesh_v1.md` é a autoridade máxima deste repositório.
- Execute uma única TASK por vez, somente após validação da TASK anterior.
- Não altere escopo, não implemente fora da TASK autorizada e não faça commits sem autorização explícita.
- Na dúvida, registre a questão e solicite validação.

## Fluxo de trabalho

Planejamento → TASK → Validação → Commit → Push → Próxima TASK.

Cada TASK deve declarar objetivo, contexto, dependências, escopo, arquivos permitidos e proibidos, critérios de aceite, testes obrigatórios e resultado esperado. Uma TASK corresponde a um commit autorizado.

## Regras de implementação

- Não inserir credenciais, chaves ou dados sensíveis.
- Manter o código modular, testável, documentado e reutilizável.
- Atualizar README, CHANGELOG, ADR, RFC, contexto e backlog quando aplicável.
- Priorizar baixo consumo, simplicidade, manutenção, escalabilidade e desacoplamento.
- Preservar compatibilidade com dispositivos Zigbee de terceiros.

## Triagem permanente de ideias

- Nenhuma nova ideia deve ser implementada, transformada em TASK ou usada para alterar o backlog automaticamente.
- O Codex realiza a triagem técnica inicial conforme `docs/IDEA_TRIAGE.md` e justifica a classificação.
- Somente ideias aprovadas para a versão atual podem ser propostas para alterar uma TASK; a alteração do backlog exige autorização explícita do usuário.
- Ideias futuras não ampliam silenciosamente o escopo atual e devem ser registradas em `docs/FUTURE_BACKLOG.md` somente quando classificadas para planejamento futuro.
- Ideias sem valor técnico ou funcional, redundantes, incompatíveis ou inviáveis podem ser descartadas com justificativa registrada.
- Evite acumular ideias redundantes, imaturas ou sem propósito no backlog futuro.

## Gate de Qualidade obrigatório

- Antes de iniciar qualquer TASK, execute automaticamente o Gate de Qualidade definido em `docs/QUALITY_GATE.md`.
- Nenhuma alteração, implementação, instalação ou teste pode ocorrer antes de o gate aprovar a TASK.
- Se qualquer verificação falhar, interrompa o trabalho, informe falhas, justificativas, pré-requisitos e impacto; aguarde autorização do usuário.
- Somente após o resultado aprovado o Codex pode iniciar a execução dentro do escopo autorizado.

## Encerramento obrigatório de TASKs

- Ao final de toda TASK, apresente automaticamente o relatório completo definido em `docs/TASK_CLOSURE.md`.
- Nenhuma TASK pode ser declarada concluída sem esse encerramento, incluindo evidências de implementação, testes, documentação, backlog, pendências e próximos passos.
- A próxima TASK indicada no relatório continua sujeita a novo Gate de Qualidade; não a inicie automaticamente.

## Estrutura

Consulte `docs/README.md` para navegação, `docs/DECISIONS.md` para o estado de decisões, `docs/IDEA_TRIAGE.md` para novas ideias, `docs/QUALITY_GATE.md` antes de cada TASK, `docs/TASK_CLOSURE.md` ao encerrá-la e `CONTRIBUTING.md` antes de iniciar uma TASK autorizada.

- `docs/`: contexto e documentação geral.
- `docs/templates/`: modelos canônicos de TASK, RFC e ADR.
- `tasks/`: TASKs versionadas e backlog.
- `adr/`: decisões arquiteturais aprovadas.
- `rfc/`: propostas que aguardam decisão.
- `hardware/`, `firmware/`, `server/`: artefatos de cada domínio quando autorizados.
- `scripts/`, `tools/`: automação e ferramentas quando autorizadas.
