# Politica de pre-analise de IA do MVP

## Classificacao e tratamento

| Risco | Tratamento |
| --- | --- |
| Baixo | Pode recomendar ou executar somente acao explicitamente autorizada; registra justificativa e resultado. |
| Medio | Nunca executa automaticamente; encaminha a aprovacao humana com contexto e recomendacao. |
| Alto | Bloqueia automacao, preserva evidencia e exige decisao humana explicita. |

## Regras obrigatorias

Gatilhos incluem falha, anomalia, pedido administrativo e evento operacional elegivel. A pre-analise usa apenas dados minimos necessarios e nunca inclui segredos, tokens ou chaves. Toda decisao registra `event_id`, correlacao, classificacao, dados usados, motivo, recomendacao, aprovador quando houver, resultado e instante; esses registros seguem o contrato de decisao de IA e auditoria em `CONTRACTS.md`.

Consulta externa e opcional: exige autorizacao futura, dados minimizados, canal aprovado e falha fechada. Sua indisponibilidade nao autoriza automacao nem impede registro local. Esta politica nao escolhe modelo, fornecedor ou mecanismo de execucao.

## Cenarios de revisao

- Baixo: diagnostico nao invasivo autorizado, com evidencia persistida.
- Medio: recomendacao de manutencao encaminhada para aprovacao humana.
- Alto: comando que possa afetar seguranca, OTA ou disponibilidade e bloqueado ate decisao humana.
