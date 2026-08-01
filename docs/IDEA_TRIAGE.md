# Triagem permanente de ideias

## Finalidade

Toda nova sugestão deve ser avaliada antes de alterar uma TASK, o backlog, a arquitetura ou qualquer implementação. Este processo preserva o escopo vigente e impede que ideias futuras se tornem trabalho implícito.

RFCs e ADRs continuam sendo usados para propostas e decisões técnicas. Este documento classifica a pertinência de uma ideia para o produto e define seu destino.

## Processo obrigatório

1. Registrar a sugestão com contexto, origem e data.
2. Avaliar os doze critérios abaixo.
3. Atribuir uma única classificação e justificá-la.
4. Registrar o resultado no local definido pela classificação.
5. Comunicar o impacto; não criar, alterar ou executar TASK sem autorização do usuário.

## Critérios de avaliação

| Critério | Pergunta de avaliação |
| --- | --- |
| Alinhamento | A ideia contribui para a missão e os objetivos do produto? |
| Versão atual | É necessária para cumprir ou proteger o MVP/versão em andamento? |
| Benefício | Qual benefício técnico ou funcional verificável ela oferece? |
| Custo e complexidade | O esforço e a complexidade são proporcionais ao benefício? |
| Segurança | Introduz riscos, superfícies de ataque ou requisitos de segurança? |
| Arquitetura | Preserva modularidade, eventos, desacoplamento e manutenção? |
| Dependências | Quais decisões, componentes, fornecedores ou tarefas ela exige? |
| Retrabalho | Evita ou cria retrabalho relevante na versão atual? |
| Compatibilidade | É compatível com Zigbee, ESP32-C6/plataforma aprovada e dispositivos de terceiros? |
| Equivalência | Já existe solução ou TASK planejada com o mesmo objetivo? |
| Maturidade | Há evidência técnica suficiente para planejar com responsabilidade? |
| Prioridade | É mais importante que a entrega atualmente autorizada? |

## Classificações e destino

### Incorporar agora

Use somente quando a ideia for necessária para cumprir requisito vigente, corrigir lacuna comprovada ou evitar retrabalho relevante na versão atual.

- Identifique a TASK afetada, o impacto e os critérios alterados.
- Proponha criação ou alteração de TASK, sem modificar arquivos.
- Aguarde autorização explícita do usuário antes de alterar backlog ou implementar.

### Planejar para versão futura

Use quando a ideia for válida, mas não necessária na versão atual.

- Registre-a em `docs/FUTURE_BACKLOG.md` com versão sugerida, motivação, impacto e dependências.
- Não altere escopo, prioridade ou TASKs do MVP.

### Manter em pesquisa

Use quando a ideia for promissora, mas não houver informação suficiente para planejar ou decidir.

- Mantenha o registro nesta página com hipótese, dúvidas, pesquisa necessária e critérios de decisão futura.
- Não crie TASK e não inclua no backlog futuro até a pesquisa produzir evidência suficiente.

### Descartar

Use quando a ideia não tiver benefício claro, fugir dos objetivos, duplicar solução planejada, gerar complexidade desproporcional, contradizer a arquitetura, apresentar risco maior que o benefício ou for inviável.

- Registre resumidamente a ideia, motivo, data/contexto e condição de reconsideração, se houver.
- Não a apague e não a inclua no backlog futuro.

## Registro de triagens

O registro começa vazio. Acrescente novas entradas em ordem cronológica, usando um identificador `IDEA-AAAAMMDD-NN`.

### Modelo de entrada

```md
## IDEA-AAAAMMDD-NN — título

- Data/contexto:
- Ideia e origem:
- Avaliação dos critérios: alinhamento; versão atual; benefício; custo/complexidade; segurança; arquitetura; dependências; retrabalho; compatibilidade; equivalência; maturidade; prioridade.
- Classificação: incorporar agora | planejar para versão futura | manter em pesquisa | descartar.
- Justificativa e impacto:
- Destino: TASK proposta (somente após autorização) | FUTURE_BACKLOG | pesquisa | registro de descarte.
- Condição para reavaliação, se aplicável:
```

## Registros em pesquisa

Nenhum registro no momento.

## Registros descartados

Nenhum registro no momento.
