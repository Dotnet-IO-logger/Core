namespace Microsoft.IoLogger.Applications.SignalRServer.Hubs
{
    using Microsoft.AspNetCore.SignalR;
    using Microsoft.IoLogger.Core;

    public class LogsHub : Hub
    {
        private readonly LoggerService loggerService;

        public LogsHub(LoggerService loggerService)
        {
            this.loggerService = loggerService;
        }

        /// <summary>
        /// Get list of dotnet processes.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task GetProcesses()
        {
            var processIds = this.loggerService.GetProcesses();
            await Clients.Caller.SendAsync("ProcessesReceived", processIds);
        }

        /// <summary>
        /// Subscribe to required process by id.
        /// </summary>
        /// <param name="processId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task Subscribe(int processId)
        {
            return this.loggerService.Subscribe(processId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="processId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task Unsubscribe(int processId = 0)
        {
            return this.loggerService.Unsubscribe(processId);
        }
    }
}
