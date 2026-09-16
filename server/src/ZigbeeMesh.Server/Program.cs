using ZigbeeMesh.Server.Bootstrap;

var application = ServerApplication.Build(args);
await application.RunAsync();
