namespace ZigbeeMesh.Server.Application.Events;

public sealed record PlatformEvent(
    Guid EventId,
    string ContractVersion,
    DateTimeOffset OccurredAt,
    string Source,
    string CorrelationId,
    string Type,
    object Payload);
