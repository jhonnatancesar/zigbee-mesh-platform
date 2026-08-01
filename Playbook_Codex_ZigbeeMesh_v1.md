# Playbook Codex - Zigbee Mesh Platform

Versão: 2.0

> Documento mestre do projeto. Este playbook define como o Codex deverá
> trabalhar durante toda a vida do projeto.

# 1. Missão

Construir uma plataforma própria de IoT iniciando por Zigbee Mesh,
evoluindo para LoRa, hardware proprietário, IA distribuída e
gerenciamento de múltiplas instalações.

# 2. Papéis

## ChatGPT

-   Arquiteto
-   Product Owner Técnico
-   Revisor
-   Responsável por gerar prompts para o Codex

## Codex

-   Implementador
-   Executor das TASKs
-   Nunca altera escopo

# 3. Fluxo obrigatório

Planejamento → TASK → Validação → Commit → Push → Próxima TASK

Nunca executar duas TASKs.

# 4. Regras Gerais

-   Nunca implementar fora da TASK.
-   Nunca aumentar escopo.
-   Sempre analisar impactos.
-   Sempre atualizar documentação.
-   Nunca criar código de exemplo desnecessário.
-   Nunca inserir credenciais.
-   Nunca fazer commit sem autorização.

# 5. MVP

Inclui: - Coordenador Zigbee - Routers - End Devices - Sensor
proprietário temperatura/umidade - Home Assistant - API - Banco
próprio - IA - OTA - Servidor local

Exclui: - LoRa - Hardware próprio - Interface própria - Nuvem comercial

# 6. Roadmap

## V2

-   LoRa
-   Hardware proprietário
-   Protocolo próprio
-   Coordenador móvel
-   Acesso remoto

## Futuro

-   IA distribuída
-   Multi-servidor
-   Marketplace de dispositivos

# 7. Arquitetura

-   Modular
-   Event-driven
-   APIs para administração
-   Banco próprio como fonte da verdade
-   Home Assistant como cliente

# 8. Segurança

-   TLS
-   Tokens no MVP
-   Evolução para mTLS
-   OTA assinado
-   Rollback
-   Auditoria

# 9. Firmware

-   Firmware proprietário
-   HAL desacoplada
-   ESP32-C6 no MVP

# 10. Banco

Registrar: - medições - falhas - mudanças de rota - OTA - decisões da
IA - justificativas - diagnósticos

Prioridade de retenção: 1. Falhas 2. Mudanças de rota 3. Decisões da IA
4. Eventos 5. Medições

# 11. IA

-   Pré-análise local
-   Consulta a modelos externos quando necessário
-   Execução automática apenas em baixo risco
-   Médio/alto risco conforme política
-   Registrar motivo de toda decisão

# 12. OTA

-   Coordenador
-   Router
-   End Device

Verificar: - bateria - enlace - integridade - rollback

# 13. Estrutura esperada

    docs/
    tasks/
    adr/
    rfc/
    hardware/
    firmware/
    server/
    scripts/
    tools/

# 14. TASKs

Cada TASK deve conter: - objetivo - contexto - dependências - arquivos
permitidos - arquivos proibidos - critérios de aceite - testes -
resultado esperado

Uma TASK = um commit.

# 15. Convenção Git

Branches: - main - feature/* - hotfix/*

Commit: TASK-XXX: descrição objetiva

# 16. Documentação obrigatória

Atualizar quando aplicável: - README - AGENTS - CHANGELOG - ADR - RFC -
Contexto - Backlog

# 17. Qualidade

Todo código deve ser: - modular - testável - documentado - reutilizável

# 18. Compatibilidade

Manter compatibilidade com dispositivos Zigbee de terceiros.

# 19. Critérios de arquitetura

Preferir: - baixo consumo - simplicidade - manutenção - escalabilidade -
desacoplamento

# 20. Regra de Ouro

Na dúvida: - não implementar; - registrar; - solicitar validação.

# 21. Primeira TASK

A TASK-000 deverá: - criar a estrutura do projeto; - criar AGENTS.md; -
criar README.md; - criar CHANGELOG.md; - criar documentação inicial; -
gerar backlog inicial de TASKs; - não implementar código funcional.
