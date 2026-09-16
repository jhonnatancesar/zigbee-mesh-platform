using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using ZigbeeMesh.Server.Application.Events;
using ZigbeeMesh.Server.Bootstrap;
using ZigbeeMesh.Server.Options;

await using var application = ServerApplication.Build(["--urls", "http://127.0.0.1:0"]);

using var scope = application.Services.CreateScope();
var options = scope.ServiceProvider.GetRequiredService<IOptions<ServerOptions>>().Value;
var publisher = scope.ServiceProvider.GetRequiredService<IPlatformEventPublisher>();
var reader = scope.ServiceProvider.GetRequiredService<IPlatformEventReader>();

if (options.EventQueueCapacity <= 0 || publisher is null || reader is null)
{
    throw new InvalidOperationException("Server foundation services were not initialized.");
}

await application.StartAsync();
await application.StopAsync();

Console.WriteLine("Server foundation smoke test passed.");
