namespace ZigbeeMesh.Server.Application.Events;

public interface IPlatformEventReader
{
    IAsyncEnumerable<PlatformEvent> ReadAllAsync(CancellationToken cancellationToken);
}
