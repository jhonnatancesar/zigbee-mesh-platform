# Encerramento obrigatório de TASKs

## Regra obrigatória

Nenhuma TASK é considerada concluída sem a apresentação automática do relatório de encerramento definido neste documento. O relatório é emitido ao final de toda TASK, antes de declarar a conclusão e antes de iniciar a próxima TASK.

O Gate de Qualidade verifica se uma TASK pode começar; este processo verifica se ela foi concluída dentro do escopo, com evidências e documentação suficientes.

## Procedimento

1. Confirmar os critérios de aceite e o resultado esperado da TASK.
2. Executar e consolidar os testes obrigatórios.
3. Atualizar toda documentação aplicável e verificar o backlog.
4. Reavaliar o estado final de governança, segurança e dependências afetadas.
5. Apresentar integralmente o relatório padronizado abaixo.
6. Declarar a TASK concluída somente se não houver bloqueio de aceite ou pendência que impeça sua conclusão.

Se a implementação não puder ser concluída, o relatório deve declarar isso objetivamente. O Codex não deve apresentar a TASK como concluída nem iniciar a próxima sem orientação do usuário.

## Relatório obrigatório

Ao encerrar uma TASK, o Codex deve apresentar exatamente esta estrutura, preenchida com evidências do trabalho executado:

```md
# Encerramento da TASK

## Gate de Qualidade

Informar se todas as verificações obrigatórias foram aprovadas.
Caso alguma tenha falhado, informar o motivo.

## Implementação

Informar se a implementação foi concluída integralmente.
Caso não tenha sido possível concluir, explicar o motivo.

## Testes

Informar:
- testes executados;
- resultado de cada teste;
- cobertura quando aplicável;
- pendências.

## Documentação

Confirmar que toda a documentação obrigatória foi atualizada.
Caso algum documento não tenha sido atualizado, justificar.

## Backlog

Confirmar que:
- o backlog permanece consistente;
- dependências continuam válidas;
- nenhuma TASK foi afetada sem autorização.

## Pendências

Listar qualquer pendência restante.
Caso não exista nenhuma:
**Pendências: Nenhuma.**

## Resumo Técnico

Apresentar um resumo objetivo das alterações realizadas.

## Próximos Passos

Informar qual é a próxima TASK prevista e confirmar se ela já atende aos pré-requisitos para iniciar.
```

## Regras para os próximos passos

A indicação da próxima TASK não autoriza seu início. Antes dela, o Codex deve executar novamente o Gate de Qualidade em `QUALITY_GATE.md`. Caso o gate bloqueie, o relatório deve registrar a pendência e o Codex deve aguardar autorização.

## Relação com outros documentos

- `AGENTS.md` torna este encerramento obrigatório.
- `QUALITY_GATE.md` controla o início de uma TASK.
- `TEST_STRATEGY.md` define as evidências de teste.
- `tasks/README.md`, RFCs e ADRs sustentam a revisão de backlog e dependências.
