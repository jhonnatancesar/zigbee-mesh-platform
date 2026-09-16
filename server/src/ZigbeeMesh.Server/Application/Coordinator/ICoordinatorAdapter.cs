namespace ZigbeeMesh.Server.Application.Coordinator;

public interface ICoordinatorAdapter
{
    Task<CoordinatorConnectionState> GetConnectionStateAsync(CancellationToken cancellationToken);
}

public sealed record CoordinatorConnectionState(
    bool IsConnected,
    string Transport,
    DateTimeOffset ObservedAt);
