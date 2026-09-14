# Requisitos operacionais do servidor local

## Requisitos verificaveis

| Area | Requisito e evidencia |
| --- | --- |
| Instalacao/configuracao | Procedimento reproduzivel, configuracao nao sensivel e validacao de inicio; segredos fora do repositorio. |
| Atualizacao | Versao, janela, pre-verificacao, resultado e plano de reversao registrados. |
| Backup/restauracao | Backup inclui dados e auditoria exigidos; restauracao deve comprovar integridade, versao e correlacao antes de liberar operacao. |
| Falhas | Falhas de persistencia, tempo, armazenamento ou canal sao observaveis, auditaveis e nao descartam eventos silenciosamente. |
| Tempo | Fonte, sincronizacao, desvio e indisponibilidade de tempo sao registrados; eventos preservam instante de origem e recebimento. |
| Capacidade/disponibilidade | Limites numericos aguardam decisao aprovada; antes disso, carga, espaco e degradacao devem ser medidos e limitacoes registradas. |
| Retencao | Falhas, rotas, decisoes de IA, eventos e medicoes seguem prioridade definida em `CONTRACTS.md`; exclusao exige politica aprovada e evidencia. |

## Evidencias operacionais

Cada procedimento registra versao, ambiente, operador, instante, configuracao nao sensivel, dados de entrada, resultado, falhas, recuperacao e correlacao. Ferramenta, banco, runtime, servico de tempo e mecanismo de backup permanecem pendentes de RFC/ADR; esta especificacao nao os escolhe.
