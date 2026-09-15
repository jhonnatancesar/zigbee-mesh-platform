# ADR-001 - Plataforma do servidor local

## Status

Aprovado.

## Contexto

O servidor local é a fonte da verdade do MVP e precisa executar APIs administrativas, serviços de aplicação, eventos, auditoria e a integração futura com Home Assistant. TASK-034 comparou alternativas sem escolher banco, migrações ou persistência concreta, que permanecem na TASK-009. A operação inicial será em Windows, sem impedir migração futura para Linux.

## Decisão

- Usar C# em uma versão LTS suportada de .NET, fixada na fundação de implementação e atualizada de modo controlado.
- Usar ASP.NET Core como host das APIs administrativas e serviços de borda aprovados.
- Usar `async`/`await`, serviços hospedados/background workers e filas internas limitadas para concorrência, backpressure e processamento assíncrono.
- Executar prioritariamente como Windows Service, com configuração não sensível externa ao repositório e reinício controlado pelo Service Control Manager.
- Manter código, contratos e publicação multiplataforma para futura migração a Linux como serviço `systemd`, sem tornar suporte operacional simultâneo um requisito do MVP.

## Consequências

- A TASK-008 pode criar a fundação do servidor sem escolher banco definitivo.
- Serviços, APIs e adaptadores devem depender de portas de aplicação testáveis; a fila interna não é mecanismo de durabilidade e não substitui a decisão da TASK-009.
- Publicação, conta de serviço, permissões e recuperação do Windows Service exigem procedimentos operacionais antes de produção.
- A versão concreta de .NET precisa permanecer dentro de suporte de segurança durante a operação.

## Alternativas consideradas

- TypeScript/Node.js LTS com Fastify: viável, mas não escolhido por exigir maior controle operacional de dependências e execução como serviço.
- Python/FastAPI: viável, porém sem vantagem necessária para o núcleo local.
- Go: viável e simples de distribuir, mas com maior custo manual para contratos e convenções de API.

## Rastreabilidade

TASK-034; RFC-008; `docs/SERVER_PLATFORM_EVALUATION.md`; TASK-001; TASK-002; TASK-029; TASK-030; TASK-008; TASK-009.
