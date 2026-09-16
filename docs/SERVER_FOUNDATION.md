# Fundação do servidor local

## Escopo da TASK-008

A fundação usa C#/.NET 10 LTS e ASP.NET Core conforme ADR-001. Ela define apenas composição, configuração não sensível, fronteiras de aplicação e fila interna limitada. Não contém banco, migrações, APIs de negócio, OTA, IA, Home Assistant, credenciais ou transporte concreto do coordenador.

## Fronteiras

- `Application/Coordinator`: contrato normalizado de `coordinator_adapter`, sem ESP-IDF, USB/Serial ou Wi-Fi.
- `Application/Events`: envelope de evento e portas de publicação, leitura e tratamento.
- `Application/Persistence`: porta de persistência; a implementação e o banco pertencem à TASK-009.
- `Infrastructure/Eventing`: fila limitada e worker hospedado. A fila aplica backpressure, mas não é durável.

## Configuração

`server/src/ZigbeeMesh.Server/appsettings.json` contém somente `Server:EventQueueCapacity` e níveis de log. Variáveis de ambiente com prefixo `ZIGBEE_MESH_` sobrepõem a configuração. Segredos, tokens, certificados e endpoints de produção não são versionados.

## Execução e verificação

Com .NET SDK 10.0.401 ou versão compatível definida em `global.json`:

```text
dotnet build ZigbeeMesh.Server.sln
dotnet run --project server/tests/ZigbeeMesh.Server.SmokeTests
```

O deploy como Windows Service e a configuração de TLS/credenciais serão realizados somente nas TASKs que implementarem os controles e a operação aprovados.
