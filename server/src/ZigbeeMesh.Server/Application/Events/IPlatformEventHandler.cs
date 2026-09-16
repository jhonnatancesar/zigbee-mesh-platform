namespace ZigbeeMesh.Server.Application.Events;

public interface IPlatformEventHandler
{
    Task HandleAsync(PlatformEvent platformEvent, CancellationToken cancellationToken);
}
