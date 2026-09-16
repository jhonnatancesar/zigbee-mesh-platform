using ZigbeeMesh.Server.Application.Events;

namespace ZigbeeMesh.Server.Application.Persistence;

public interface IPlatformEventStore
{
    Task AppendAsync(PlatformEvent platformEvent, CancellationToken cancellationToken);
}
