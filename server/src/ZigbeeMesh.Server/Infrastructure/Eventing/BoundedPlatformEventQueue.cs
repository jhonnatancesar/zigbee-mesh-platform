using System.Threading.Channels;
using ZigbeeMesh.Server.Application.Events;
using ZigbeeMesh.Server.Options;

namespace ZigbeeMesh.Server.Infrastructure.Eventing;

public sealed class BoundedPlatformEventQueue : IPlatformEventPublisher, IPlatformEventReader
{
    private readonly Channel<PlatformEvent> _channel;

    public BoundedPlatformEventQueue(Microsoft.Extensions.Options.IOptions<ServerOptions> options)
    {
        _channel = Channel.CreateBounded<PlatformEvent>(new BoundedChannelOptions(options.Value.EventQueueCapacity)
        {
            FullMode = BoundedChannelFullMode.Wait,
            SingleReader = true,
            SingleWriter = false
        });
    }

    public ValueTask PublishAsync(PlatformEvent platformEvent, CancellationToken cancellationToken) =>
        _channel.Writer.WriteAsync(platformEvent, cancellationToken);

    public IAsyncEnumerable<PlatformEvent> ReadAllAsync(CancellationToken cancellationToken) =>
        _channel.Reader.ReadAllAsync(cancellationToken);
}
