# Backlog de TASKs

## Próxima prioridade: plataforma do servidor

TASK-034 preenche a lacuna de decisão que bloqueia TASK-008: TASK-034 -> validação do usuário -> ADR da plataforma do servidor -> TASK-008. A decisão de banco definitivo continua na TASK-009.

## Prioridade do coordenador

TASK-033 está formalmente concluída. TASK-032 está **SUSPENSA POR REPRIORIZAÇÃO — NÃO BLOQUEANTE**; seu trabalho documental permanece preservado para retomada futura. TASK-034 é a próxima TASK válida; nenhuma TASK está ativa. ADRs do coordenador devem preceder a TASK-007.

TASK-033 e a etapa decisoria anterior ao coordenador. TASK-008 requer primeiro seu ADR de tecnologia do servidor; TASK-007 requer TASK-008 e os ADRs aprovados do coordenador. TASK-019 conserva a matriz e execucao formal de interoperabilidade comercial.

O coordenador e a rede Zigbee interoperavel sao o caminho critico do MVP. TASK-032, TASK-031 e TASK-005 tratam apenas o dispositivo proprio de referencia e nao bloqueiam coordenador, router, servidor ou interoperabilidade. Lacuna identificada: TASK-007 exige ADR de coordenador, mas nenhuma TASK existente pesquisa e propoe essa decisao.

## Ajuste de dependencia da plataforma fisica

TASK-032 e a TASK de decisao que antecede TASK-031. A sequencia vinculante e: TASK-032 -> validacao das decisoes -> ADRs aprovados -> TASK-031 -> TASK-004 -> TASK-005. TASK-032 nao autoriza compra, ensaio fisico ou implementacao.

Use o [índice de modelos](../docs/templates/README.md) ao criar uma TASK autorizada. Consulte a [rastreabilidade](../docs/TRACEABILITY.md) para a relação entre as TASKs e o Playbook.

Somente a TASK-000 está executada. Todas as demais aguardam validação e autorização explícita, uma por vez. O número é um identificador estável; a sequência vinculante é determinada pelas dependências e pela ordem abaixo.

## Sequência proposta

| Ordem | Prioridade | TASK | Tema |
| --- | --- | --- | --- |
| 1 | P0 | 001 | Arquitetura e decisões pendentes |
| 2 | P0 | 029 | Segurança, identidade e chaves |
| 3 | P0 | 002 | Contratos de eventos, dados e API |
| 4 | P0 | 003 | Requisitos do sensor e plataforma embarcada |
| 5 | P0 | 015 | Especificação de OTA segura |
| 6 | P0 | 017 | Política e pré-análise de IA |
| 7 | P0 | 030 | Requisitos operacionais e não funcionais |
| 8 | P0 | 031 | Validação da plataforma física do sensor |
| 9 | P0 | 004 | Fundação de firmware e HAL |
| 10 | P0 | 005 | Firmware do end device sensor |
| 11 | P0 | 006 | Firmware de router Zigbee |
| 12 | P0 | 034 | Decisão da plataforma do servidor local e fundação operacional |
| 13 | P0 | 008 | Fundação do servidor local |
| 14 | P0 | 007 | Integração do coordenador Zigbee |
| 15 | P0 | 009 | Banco como fonte da verdade |
| 16 | P0 | 010 | Ingestão e processamento de eventos |
| 17 | P0 | 012 | Segurança inicial e auditoria |
| 18 | P0 | 011 | API administrativa |
| 19 | P0 | 013 | Integração com Home Assistant |
| 20 | P0 | 014 | Observabilidade e diagnósticos operacionais |
| 21 | P0 | 016 | Implementação de OTA segura |
| 22 | P0 | 018 | Implementação da pré-análise de IA |
| 23 | P0 | 019 | Interoperabilidade Zigbee de terceiros |
| 24 | P0 | 020 | Validação integrada do MVP |
| 25 | P2 | 021–025 | Planejamento da V2 |
| 26 | P3 | 026–028 | Visão futura |

Todas as TASKs até a TASK-020, além das TASKs 029–031 que as habilitam, são obrigatórias para o MVP. P2 e P3 não pertencem ao MVP.
