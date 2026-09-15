# Avaliação da plataforma do servidor local

## Estado

Proposta produzida pela TASK-034. Nenhuma recomendação deste documento é uma decisão arquitetural vigente; ADRs só podem ser criados após validação explícita do usuário.

## Invariantes de decisão

- O servidor local é a fonte da verdade; Home Assistant é cliente.
- O sistema funciona localmente durante indisponibilidade de Internet; serviços externos não são pré-requisito operacional.
- Eventos, comandos, auditoria, correlação, TLS e tokens devem respeitar `CONTRACTS.md` e `SECURITY_ARCHITECTURE.md`.
- `coordinator_adapter` encapsula ESP Zigbee SDK e ambos os transportes: USB/Serial primário e Wi-Fi secundário; o servidor recebe apenas operações e eventos normalizados.
- O firmware do coordenador e dos dispositivos permanece C++ sobre ESP-IDF e ESP Zigbee SDK, separado da aplicação C# do servidor.
- Banco definitivo, esquema físico, migrações e tecnologia de persistência pertencem à TASK-009 e não são escolhidos aqui.

## Alternativas comparadas

| Alternativa | API e concorrência | Operação local | Vantagens | Limites |
| --- | --- | --- | --- | --- |
| C# em .NET LTS com ASP.NET Core | APIs HTTP administrativas, USB/Serial primário e WebSocket/TLS opcional por Wi-Fi, com `async`/`await`, serviços hospedados e canais limitados | Executável cross-platform, Windows Service prioritário e serviço `systemd` possível futuramente | Modelo de hospedagem maduro, bom isolamento de serviços, testes e diagnósticos, publicação reproduzível para mini-PC | Exige disciplina de limites entre serviços e a escolha posterior da versão LTS/política de publicação |
| TypeScript em Node.js LTS com Fastify | Event loop assíncrono, HTTP/WebSocket | Executa em Windows/Linux; requer runtime e estratégia de gerenciador de serviço | Ecossistema amplo, desenvolvimento rápido e bom encaixe para APIs/eventos | Cadeia de dependências e empacotamento precisam de maior controle; trabalho CPU-intensivo exige processos separados |
| Python com FastAPI | `asyncio`, ASGI e tarefas de fundo | Executa nos dois sistemas com ambiente isolado | Simples para integração futura com ecossistema Home Assistant e automação | Concorrência e distribuição exigem maior cuidado operacional; não traz vantagem necessária para o núcleo local |
| Go com `net/http`/framework leve | Goroutines e canais | Binário único simples de implantar | Baixo consumo, concorrência direta e distribuição simples | Maior trabalho manual para contratos, validação e convenções de API; nenhum ganho obrigatório sobre .NET para o MVP |

## Recomendação técnica pendente de aprovação

Adotar **C# em versão LTS suportada de .NET**, com **ASP.NET Core** como host de API e de transporte do adaptador, sem fixar o número da versão nesta TASK. A escolha deve ser revisada na fundação para manter suporte de segurança durante o horizonte operacional do MVP.

O modelo proposto usa:

- APIs administrativas HTTP versionadas, mantidas como fronteira externa;
- USB/Serial como transporte primário entre `coordinator_adapter` e servidor para eventos e comandos correlacionados; Wi-Fi é transporte secundário e pode usar WebSocket sobre TLS, com reconexão, autenticação por token e idempotência previstos nos contratos;
- `async`/`await`, serviços hospedados para consumidores de eventos e filas internas limitadas para aplicar backpressure;
- interfaces de aplicação para publicar/consumir eventos, sem acoplamento direto de controladores, adaptador ou Home Assistant à futura implementação de banco.

USB/Serial é recomendado como conexão local primária por simplicidade, previsibilidade e independência de rede. Wi-Fi/WebSocket-TLS é alternativa secundária quando a topologia física exigir. `coordinator_adapter` abstrai seleção, serialização, reconexão e estado de ambos; domínio, APIs e persistência não conhecem o transporte concreto. A mensagem concreta continua sendo o envelope versionado da TASK-002; a definição detalhada de proteção do enlace serial, transporte Wi-Fi e reconexão deve constar do ADR e da implementação posterior.

## Fronteiras internas propostas

```text
coordinator_adapter -- USB/Serial (primário) -----------------> ingresso de borda
                    -- Wi-Fi/WebSocket + TLS (secundário) ---->        |
                                                                  aplicação/dominio
                                                                         |
                                                          barramento interno limitado e observável
                                                             /             |              \
                                                      persistência*    auditoria       APIs/HA
```

`*` A persistência é uma porta de aplicação; esta TASK não escolhe sua tecnologia. Falha de publicação, fila saturada ou persistência indisponível deve produzir evento de falha rastreável e não descarte silencioso.

O ingresso de borda valida autenticação, versão, origem, tamanho, correlação e idempotência antes de entregar ao domínio. O domínio só conhece contratos normalizados e não APIs ESP-IDF/ESP Zigbee SDK. Chamadas de comando percorrem a direção inversa, recebem resultado correlacionado e não presumem execução pela ausência de erro.

## Segurança e operação

| Área | Proposta compatível com requisitos existentes |
| --- | --- |
| USB/Serial | Transporte primário local, sem exposição de rede; acesso físico, identidade do adaptador e proteção do enlace devem ser definidos no ADR sem segredos no repositório. |
| Wi-Fi/TLS | Quando Wi-Fi for usado, WebSocket sobre TLS com configuração externa ao repositório; recusar canais inseguros. |
| Token | Validação de escopo, expiração e revogação conforme TASK-029; sem tokens ou segredos em logs. O formato/algoritmo permanece decisão de segurança a formalizar. |
| Auditoria | Registrar ator, ação, alvo, autorização, resultado e `correlation_id`; preservar falhas de canal e de autorização. |
| Offline-first | Sem dependência de nuvem; eventos e comandos locais continuam sujeitos à persistência e às regras de recuperação aprovadas. |
| Atualização | Pacote versionado, pré-verificação, janela, resultado e reversão registrados conforme TASK-030. |
| Serviço | Processo único do servidor, sem privilégios administrativos e com reinício controlado pelo gerenciador do SO; nunca gravar configuração sensível no repositório. |

## Mini-PC, compatibilidade e empacotamento

Windows é a plataforma prioritária de implantação e operação inicial. O código, contratos, publicação e fronteiras devem permanecer multiplataforma para permitir futura migração a Linux sem reescrita da aplicação; suporte operacional simultâneo aos dois não é requisito aprovado.

- **Windows Service** é a forma prioritária de execução: processo sem privilégios administrativos, inicialização e reinício controlados pelo Service Control Manager.
- **Linux com `systemd`** é a rota futura de migração: a mesma aplicação deverá poder ser hospedada como serviço do sistema, após qualificação operacional específica.

Para ambos, a publicação deve ser reproduzível por arquitetura/ambiente, com configuração não sensível separada do artefato. A decisão entre publicação framework-dependent e self-contained deve considerar o sistema escolhido, atualização do runtime, tamanho do pacote e plano de reversão; não é necessário escolher agora um instalador, contêiner ou orquestrador. Contêineres não são requisito do MVP.

## Testes propostos para a TASK-008

- testes unitários para serviços e regras de domínio, com portas de adaptador e persistência simuláveis;
- testes de contrato para envelope, autenticação, idempotência e erros em USB/Serial e Wi-Fi/WebSocket;
- teste de inicialização com configuração não sensível e falha fechada quando faltarem requisitos críticos;
- teste de reconexão/backpressure do adaptador para USB/Serial e, quando habilitado, Wi-Fi/WebSocket, sem dispositivo Zigbee físico;
- teste de empacotamento e inicialização como Windows Service; qualificação Linux só será obrigatória após decisão explícita.

## Riscos e questões abertas

- A versão .NET LTS, biblioteca serial concreta, biblioteca WebSocket e método de gerenciamento de tokens precisam de compatibilidade e suporte verificados antes da implementação.
- A garantia de entrega após reinício depende da porta de persistência e da decisão de banco da TASK-009; a fila interna não é durável por si só.
- O alvo operacional prioritário é Windows; publicação, conta de serviço, permissões de porta USB e procedimento de recuperação ainda precisam ser definidos no ADR.
- Capacidade, memória e carga reais do mini-PC permanecem sem metas numéricas; TASK-030 exige medição e registro antes de assumir limites.

## ADRs futuros propostos

1. Plataforma do servidor: C#/.NET LTS, ASP.NET Core, concorrência, Windows Service prioritário e política de publicação.
2. Fronteira coordenador-servidor: USB/Serial primário, Wi-Fi/WebSocket-TLS secundário, autenticação, reconexão e contratos do `coordinator_adapter`.

O banco de dados, formato de migração e retenção física não são ADRs desta TASK; pertencem à TASK-009.

## Referências de pesquisa

- Microsoft, política de suporte e lançamentos LTS do .NET.
- Microsoft, ASP.NET Core, hosted services, `System.Threading.Channels`, Windows Service e `systemd`.
- Node.js, política de versões LTS; Fastify, documentação de API e WebSocket.
- FastAPI/Starlette, guia de deployment ASGI; Go, documentação de concorrência e `net/http`.
