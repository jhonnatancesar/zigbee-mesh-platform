using ZigbeeMesh.Server.Application.Events;
using ZigbeeMesh.Server.Infrastructure.Eventing;
using ZigbeeMesh.Server.Options;

namespace ZigbeeMesh.Server.Bootstrap;

public static class ServerApplication
{
    public static WebApplication Build(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Configuration.AddEnvironmentVariables(prefix: "ZIGBEE_MESH_");

        builder.Services
            .AddOptions<ServerOptions>()
            .Bind(builder.Configuration.GetSection(ServerOptions.SectionName))
            .ValidateDataAnnotations()
            .ValidateOnStart();

        builder.Services.AddSingleton<BoundedPlatformEventQueue>();
        builder.Services.AddSingleton<IPlatformEventPublisher>(static services =>
            services.GetRequiredService<BoundedPlatformEventQueue>());
        builder.Services.AddSingleton<IPlatformEventReader>(static services =>
            services.GetRequiredService<BoundedPlatformEventQueue>());
        builder.Services.AddHostedService<PlatformEventDispatchWorker>();

        return builder.Build();
    }
}
