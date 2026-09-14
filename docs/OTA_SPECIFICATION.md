# Especificacao de OTA segura do MVP

## Estados e fluxo

Estados: preparado, elegivel, distribuido, recebido, verificado, aplicado, confirmado, recusado, falho e revertido. Para coordenador, router e end device, o fluxo e: operacao autorizada -> verificar elegibilidade -> entregar artefato identificado -> verificar assinatura e integridade no destino -> aplicar -> confirmar ou reverter -> registrar evento auditavel.

## Regras verificaveis

| Area | Regra |
| --- | --- |
| Elegibilidade | Papel, versao, bateria/alimentacao, enlace, espaco de armazenamento e janela operacional devem ser avaliados; ausencia ou falha recusa a atualizacao. |
| Assinatura | Artefato sem assinatura verificavel ou com integridade divergente e recusado antes da aplicacao. Algoritmo, formato e autoridade de chaves aguardam ADR. |
| Armazenamento | O destino deve preservar artefato ou banco de rollback suficiente para recuperar a versao anterior; capacidade insuficiente recusa. |
| Aplicacao | Interrupcao, falha de inicializacao ou ausencia de confirmacao ativa rollback ou estado falho observavel. |
| Telemetria | Cada transicao registra alvo, papel, versao origem/destino, correlacao, resultado, motivo seguro e rollback quando aplicavel. |
| Chaves | Chaves privadas nunca sao versionadas; inventario, rotacao e revogacao seguem RFC-004 e decisao aprovada. |

## Cenarios documentais

- Exito: elegivel, assinatura e integridade validas, aplicacao confirmada e auditoria persistida.
- Recusa: bateria/enlace/armazenamento insuficiente ou assinatura invalida; nenhuma aplicacao ocorre e a causa e registrada.
- Rollback: aplicacao interrompida ou confirmacao ausente; versao anterior e restaurada quando disponivel, com falha rastreavel.

TASK-016 implementara somente esta especificacao aprovada; esta TASK nao distribui artefatos nem executa atualizacoes.
