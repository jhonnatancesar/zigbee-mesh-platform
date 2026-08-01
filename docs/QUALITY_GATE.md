# Gate de Qualidade para TASKs

## Regra obrigatória

Antes de iniciar qualquer TASK, inclusive TASK documental, o Codex deve executar este Gate de Qualidade. A execução é automática no início de cada solicitação de TASK e precede qualquer alteração de arquivo, instalação, implementação ou teste.

O gate não substitui validação do usuário nem os testes obrigatórios da TASK. Ele decide apenas se a TASK está apta a começar.

Um identificador como `TASK-001` é suficiente para acionar esse fluxo; o Codex deve localizar a TASK e executar o gate sem solicitar instruções adicionais, exceto quando uma verificação bloquear a execução.

## Evidência de pré-requisitos

Uma dependência só é considerada concluída quando houver validação explícita do usuário e evidência documental compatível, como registro no estado do backlog, na TASK, no CHANGELOG ou em documento de validação. Na ausência de evidência verificável, trate-a como pendente.

## Verificações obrigatórias

### 1. Governança

- O Playbook aplicável foi lido e a TASK respeita suas regras.
- `AGENTS.md` e a documentação de contribuição são aplicáveis e estão sendo seguidos.
- A documentação pertinente é consistente com a TASK.

### 2. Dependências

- Todas as dependências diretas e transitivas da TASK foram concluídas e validadas.
- Não há referência a TASK inexistente ou dependência circular.
- Não existe TASK obrigatória anterior na sequência vinculante que permaneça pendente para o caminho de execução da TASK atual.

### 3. Arquitetura e decisões

- ADRs exigidos pela TASK existem e estão aprovados.
- RFCs exigidas pela TASK estão resolvidas ou possuem bloqueios explicitamente aceitos pelo usuário.
- Nenhuma decisão arquitetural vigente invalida a TASK ou seu escopo.

### 4. Escopo e produto

- A TASK pertence à versão atual indicada pelo roadmap.
- Não há conflito com MVP, V2 ou futuro.
- Nenhuma ideia futura, em pesquisa ou descartada foi incorporada sem passar pela triagem e sem autorização.

### 5. Documentação

- Documentos obrigatórios, modelos e índices necessários à TASK existem.
- Não há referências internas quebradas ou inconsistências que impeçam a execução.
- Critérios de aceite, testes obrigatórios, arquivos permitidos e proibidos são suficientes para delimitar o trabalho.

### 6. Segurança e requisitos

- Definições de segurança das quais a TASK depende estão concluídas.
- Requisitos, contratos, metodologia ou critérios prévios necessários estão definidos e aprovados.
- A TASK não executará responsabilidade reservada a uma TASK anterior de definição.

## Resultado do gate

### Aprovado

O Codex registra resumidamente as verificações realizadas e pode iniciar a TASK dentro de seu escopo autorizado.

### Reprovado ou bloqueado

O Codex deve interromper imediatamente antes de qualquer alteração e informar:

1. cada verificação que falhou;
2. a justificativa técnica;
3. as TASKs, RFCs, ADRs ou documentos que precisam ser concluídos primeiro;
4. o impacto de prosseguir sem o pré-requisito.

Depois disso, deve aguardar autorização do usuário. Não deve contornar o bloqueio, alterar o backlog ou iniciar implementação parcial.

## Registro mínimo da execução

No início da conversa de cada TASK, o Codex deve apresentar um resumo contendo:

```md
Gate de Qualidade — TASK-XXX
- Governança: aprovado | bloqueado
- Dependências: aprovado | bloqueado
- Arquitetura e decisões: aprovado | bloqueado
- Escopo e produto: aprovado | bloqueado
- Documentação: aprovado | bloqueado
- Segurança e requisitos: aprovado | bloqueado
- Resultado: apta a iniciar | bloqueada
- Pendências, se houver:
```

## Relação com outros documentos

- `AGENTS.md` torna o gate obrigatório.
- `IDEA_TRIAGE.md` protege o escopo de novas ideias.
- `DECISIONS.md`, `rfc/` e `adr/` fornecem o estado de decisões.
- `tasks/README.md` e as TASKs fornecem sequência e dependências.
- `TEST_STRATEGY.md` define a validação posterior ao início da TASK.
