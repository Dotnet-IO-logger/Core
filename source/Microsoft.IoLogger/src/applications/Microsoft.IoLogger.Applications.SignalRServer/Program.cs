namespace Microsoft.IoLogger.Applications.SignalRServer
{
    using Microsoft.IoLogger.Applications.SignalRServer.Hubs;
    using Microsoft.IoLogger.Applications.SignalRServer.Services;
    using Microsoft.IoLogger.Core;

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSignalR();
            builder.Services.AddSingleton<LoggerService>();
            builder.Services.AddSingleton<SignalrNotificationService>();

            var app = builder.Build();

            app.MapHub<LogsHub>("/logsHub");

            app.Run();
        }
    }
}