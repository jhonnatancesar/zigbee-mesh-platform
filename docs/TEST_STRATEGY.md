# Estrategia de testes e evidencias

## Regra geral

Cada TASK define seus testes obrigatorios e so pode ser considerada pronta quando os respectivos resultados estiverem disponiveis para validacao. Este documento nao substitui os criterios de aceite de cada TASK.

O Gate de Qualidade em `QUALITY_GATE.md` ocorre antes do início da TASK e verifica se ela pode começar; os testes desta estratégia ocorrem durante ou ao final da execução e verificam se ela foi concluída corretamente. Seus resultados devem constar no encerramento obrigatório de `TASK_CLOSURE.md`.

## Camadas esperadas

| Camada | Finalidade | Quando aplicavel |
| --- | --- | --- |
| Revisao documental | Verificar rastreabilidade, escopo e decisoes | TASKs de documentacao e planejamento |
| Teste unitario | Validar unidades isoladas | Firmware e servidor |
| Teste de contrato | Validar interfaces e formatos acordados | Eventos e APIs |
| Teste de integracao | Validar interacao entre componentes | Zigbee, servidor, banco, Home Assistant e OTA |
| Teste em hardware | Validar comportamento no dispositivo alvo | Firmware e hardware |
| Teste ponta a ponta | Validar fluxos criticos do MVP | Validacao integrada |
| Teste de seguranca | Validar controles e falhas de seguranca | TLS, tokens, OTA e IA conforme o risco |

## Evidencias minimas

Uma evidencia deve identificar a TASK, o ambiente, a versao/artefato avaliado, o caso executado, o resultado e as limitacoes. Dados sensiveis e credenciais nunca devem ser incluidos no repositorio.

## Estado na TASK-000

Na TASK-000, os testes aplicaveis sao somente inspecao de arvore, existencia dos documentos exigidos, presenca dos campos obrigatorios das TASKs e rastreabilidade contra o Playbook.
