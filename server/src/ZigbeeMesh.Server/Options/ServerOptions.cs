using System.ComponentModel.DataAnnotations;

namespace ZigbeeMesh.Server.Options;

public sealed class ServerOptions
{
    public const string SectionName = "Server";

    [Range(1, 4096)]
    public int EventQueueCapacity { get; init; } = 256;
}
