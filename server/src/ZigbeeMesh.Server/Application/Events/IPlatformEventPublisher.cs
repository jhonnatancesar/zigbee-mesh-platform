namespace ZigbeeMesh.Server.Application.Events;

public interface IPlatformEventPublisher
{
    ValueTask PublishAsync(PlatformEvent platformEvent, CancellationToken cancellationToken);
}
