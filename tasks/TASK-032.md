# TASK-032 — Decisão da plataforma física e critérios de validação do sensor MVP

## Status

SUSPENSA POR REPRIORIZAÇÃO — NÃO BLOQUEANTE.

As análises, recomendações e decisões já registradas permanecem válidas como histórico de trabalho e esta TASK deve ser retomada deste ponto quando voltar a ser prioritária. Ela não está concluída e não bloqueia a cadeia do coordenador Zigbee.

## Objetivo

Preparar e conduzir a análise técnica do dispositivo próprio de referência, usando RFC-005 como insumo obrigatório, sem bloquear a cadeia do coordenador.

## Contexto

TASK-031 exige plataforma física aprovada em ADR, metas mensuráveis e instrumentos definidos. TASK-003 documentou a metodologia e RFC-005 registrou as lacunas, mas não pode escolher componentes.

## Dependências

TASK-001, TASK-002, TASK-003, TASK-015 e TASK-029 validadas; RFC-005 disponível.

## Escopo

A Seeed Studio XIAO ESP32-C6 e restricao preexistente e nao e objeto de pesquisa ou recomendacao nesta TASK.

Pesquisar e comparar alternativas, critérios, riscos e recomendação técnica para: plataforma de avaliação; sensor de temperatura/umidade; alimentação; consumo/autonomia; interfaces de sensor, energia, rádio, tempo e armazenamento; SDK/toolchain; fronteiras concretas da HAL; metas numéricas de precisão, calibração, consumo, autonomia, alcance, qualidade de enlace e condições ambientais; instrumentos, método e formato de evidências da TASK-031. Produzir RFCs e propostas de ADR para validação do usuário.

## Arquivos permitidos

`docs/`, `rfc/`, `adr/`, `tasks/TASK-032.md`, `CHANGELOG.md`.

## Arquivos proibidos

`firmware/`, `server/`, PCB, esquemáticos de produção, compras, hardware físico, credenciais, artefatos OTA, ensaios físicos e código executável.

## Critérios de aceite

- Alternativas, critérios, riscos e recomendação são rastreáveis.
- Nenhuma recomendação é tratada como decisão aprovada.
- ADRs propostos identificam a validação explícita necessária.
- Metas, instrumentos e evidências tornam os ensaios da TASK-031 executáveis sem redefinir sua metodologia.

## Testes obrigatórios

Revisão documental contra RFC-005, TASK-003, TASK-031 e seções 5, 9, 18 e 19 do Playbook.

## Resultado esperado

Decisões propostas e critérios mensuráveis prontos para validação do usuário; somente após validação e ADRs aprovados a TASK-031 pode iniciar.
