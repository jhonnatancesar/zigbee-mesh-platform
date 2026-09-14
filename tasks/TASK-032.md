# TASK-032 — Decisão da plataforma física e critérios de validação do sensor MVP

## Objetivo

Preparar e conduzir a análise técnica das decisões necessárias para liberar a TASK-031, usando RFC-005 como insumo obrigatório.

## Contexto

TASK-031 exige plataforma física aprovada em ADR, metas mensuráveis e instrumentos definidos. TASK-003 documentou a metodologia e RFC-005 registrou as lacunas, mas não pode escolher componentes.

## Dependências

TASK-001, TASK-002, TASK-003, TASK-015 e TASK-029 validadas; RFC-005 disponível.

## Escopo

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
