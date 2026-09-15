# TASK-034 — Decisão da plataforma do servidor local e fundação operacional

## Status

FORMALMENTE CONCLUÍDA E VALIDADA. ADR-001 e ADR-002 registram as decisões aprovadas. Nenhuma implementação foi iniciada.

## Objetivo

Pesquisar, comparar e recomendar a plataforma tecnológica do servidor local necessária para liberar a TASK-008, sem implementar código, escolher banco definitivo ou criar ADR.

## Contexto

TASK-008 exige ADR de tecnologia do servidor, mas nenhuma TASK existente é responsável por produzir a análise que fundamenta essa decisão. A TASK-009 continua responsável pela decisão do banco de dados definitivo.

## Origem e decisão de triagem

Não aplicável. Lacuna de dependência identificada no backlog e autorizada explicitamente pelo usuário.

## Dependências

TASK-001, TASK-002, TASK-029, TASK-030 e TASK-033 validadas.

## Escopo

Pesquisar e comparar runtime/linguagem, framework de API, modelo de concorrência/assíncrono, fronteira de comunicação com `coordinator_adapter`, arquitetura de eventos internos, operação local-first/offline-first, execução no mini-PC/servidor, TLS, autenticação por token, auditoria, testes, empacotamento, execução como serviço, atualização/deploy e critérios de compatibilidade operacional. Windows e Linux são critérios de comparação, não requisito automático de suporte simultâneo.

Produzir RFCs e recomendações técnicas rastreáveis para validação do usuário. A decisão de banco, esquema físico, migrações e implementação de persistência pertencem à TASK-009.

## Arquivos permitidos

`docs/`, `rfc/`, `tasks/TASK-034.md`, `CHANGELOG.md`.

## Arquivos proibidos

`server/`, `firmware/`, `adr/`, banco funcional, esquemas ou migrações executáveis, credenciais, serviços instalados, empacotamento executável, deploy, código de exemplo e implementação de API.

## Critérios de aceite

- Alternativas, critérios, riscos e recomendação são rastreáveis.
- A recomendação preserva servidor local como fonte da verdade, operação offline-first e Home Assistant como cliente.
- Comunicação com `coordinator_adapter`, eventos, TLS, tokens e auditoria respeitam TASK-002, TASK-029, TASK-030 e TASK-033.
- Banco definitivo não é escolhido nem antecipado.
- Windows e Linux são avaliados sem ampliar o escopo para suporte simultâneo obrigatório.
- Nenhuma recomendação é tratada como ADR ou decisão vigente antes de validação explícita.

## Testes obrigatórios

Revisão arquitetural contra `docs/ARCHITECTURE.md`, `docs/CONTRACTS.md`, `docs/SECURITY_ARCHITECTURE.md`, `docs/OPERATIONS_REQUIREMENTS.md`, TASK-008, TASK-009 e TASK-033.

## Resultado esperado

Base decisória validável para ADR da plataforma do servidor local, liberando a TASK-008 após aprovação.

## Gate de Qualidade de início

Registrar na conversa de início da TASK o resultado do checklist de `docs/QUALITY_GATE.md`. Não iniciar o trabalho se houver bloqueio.

## Encerramento obrigatório

Ao final, apresentar o relatório integral de `docs/TASK_CLOSURE.md`. A TASK não é concluída sem esse relatório.
