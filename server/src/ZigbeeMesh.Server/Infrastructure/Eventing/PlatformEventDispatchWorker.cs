using ZigbeeMesh.Server.Application.Events;

namespace ZigbeeMesh.Server.Infrastructure.Eventing;

public sealed class PlatformEventDispatchWorker(
    IPlatformEventReader eventReader,
    IEnumerable<IPlatformEventHandler> handlers,
    ILogger<PlatformEventDispatchWorker> logger) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var eventHandlers = handlers.ToArray();

        if (eventHandlers.Length == 0)
        {
            logger.LogInformation(
                "No event handler is registered; event dispatch is paused until a consuming TASK provides a handler.");
            await Task.Delay(Timeout.InfiniteTimeSpan, stoppingToken);
            return;
        }

        await foreach (var platformEvent in eventReader.ReadAllAsync(stoppingToken))
        {
            foreach (var handler in eventHandlers)
            {
                await handler.HandleAsync(platformEvent, stoppingToken);
            }
        }
    }
}
