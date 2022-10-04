namespace Microsoft.IoLogger.Applications.SignalRServer.Services
{
    using Microsoft.AspNetCore.SignalR;
    using Microsoft.IoLogger.Applications.SignalRServer.Hubs;
    using Microsoft.IoLogger.Core;
    using Microsoft.IoLogger.Core.Aspnet;

    public class SignalrNotificationService : INotificationService
    {
        private readonly IHubContext<LogsHub> hubContext;

        public SignalrNotificationService(IHubContext<LogsHub> hubContext)
        {
            this.hubContext = hubContext;
        }

        public Task AspnetRequest(AspnetRequestMessage request)
        {
            return this.hubContext.Clients.All.SendAsync("aspnetRequest", request);
        }

        public Task AspnetResponse(AspnetResponseMessage response)
        {
            return this.hubContext.Clients.All.SendAsync("aspnetResponse", response);
        }

        public Task HttpRequest(Core.Http.HttpRequestMessage request)
        {
            return this.hubContext.Clients.All.SendAsync("httpRequest", request);
        }

        public Task HttpResponse(Core.Http.HttpResponseMessage response)
        {
            return this.hubContext.Clients.All.SendAsync("httpResponse", response);
        }
    }
}
