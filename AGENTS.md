# AGENTS.md

## Autoridade e escopo

- `Playbook_Codex_ZigbeeMesh_v1.md` é a autoridade máxima deste repositório.
- Execute uma única TASK por vez, somente após validação da TASK anterior.
- Não altere escopo, não implemente fora da TASK autorizada e não faça commits sem autorização explícita.
- Na dúvida, registre a questão e solicite validação.

## Fluxo de trabalho

Planejamento → TASK → Validação → Commit → Push → Próxima TASK.

Cada TASK deve declarar objetivo, contexto, dependências, escopo, arquivos permitidos e proibidos, critérios de aceite, testes obrigatórios e resultado esperado. Uma TASK corresponde a um commit autorizado.

## Acionamento automático por identificador de TASK

O usuário precisa informar apenas um identificador válido, como `TASK-001`, ou uma solicitação equivalente, como `Execute a TASK-001`. Nenhuma instrução adicional é necessária para iniciar o fluxo; o Codex deve localizar a TASK e executar automaticamente, nesta ordem:

1. identificar a TASK solicitada;
2. ler o Playbook e `AGENTS.md`;
3. executar o Gate de Qualidade;
4. verificar dependências, ADRs, RFCs, segurança e consistência documental;
5. confirmar que a TASK pertence à versão atual;
6. executar exclusivamente a TASK solicitada, dentro de seus arquivos permitidos;
7. atualizar a documentação obrigatória;
8. executar os testes definidos na própria TASK;
9. realizar autoavaliação objetiva de escopo, aceite, testes, segurança, documentação e impacto arquitetural;
10. apresentar o encerramento obrigatório e aguardar validação do usuário.

O Codex não deve iniciar TASK diferente da solicitada, ampliar escopo, fazer commit automaticamente, fazer push automaticamente ou iniciar a próxima TASK. Após a validação do usuário, os comandos explícitos `Commit` e `Push` são suficientes para as respectivas ações, sempre respeitando o Playbook, o escopo da TASK concluída e as verificações aplicáveis.

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
- A autoavaliação da implementação deve ocorrer antes do relatório e ter suas conclusões registradas no Resumo Técnico e em Pendências, quando aplicável.

## Estrutura

Consulte `docs/README.md` para navegação, `docs/DECISIONS.md` para o estado de decisões, `docs/IDEA_TRIAGE.md` para novas ideias, `docs/QUALITY_GATE.md` antes de cada TASK, `docs/TASK_CLOSURE.md` ao encerrá-la e `CONTRIBUTING.md` antes de iniciar uma TASK autorizada.

- `docs/`: contexto e documentação geral.
- `docs/templates/`: modelos canônicos de TASK, RFC e ADR.
- `tasks/`: TASKs versionadas e backlog.
- `adr/`: decisões arquiteturais aprovadas.
- `rfc/`: propostas que aguardam decisão.
- `hardware/`, `firmware/`, `server/`: artefatos de cada domínio quando autorizados.
- `scripts/`, `tools/`: automação e ferramentas quando autorizadas.
