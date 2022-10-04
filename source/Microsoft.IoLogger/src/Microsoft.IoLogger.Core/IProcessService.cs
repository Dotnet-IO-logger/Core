namespace Microsoft.IoLogger.Core
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IProcessService
    {
        Task<IReadOnlyCollection<int>> GetAllProcesses();

        Task SubscribeProcess(int processId);

        Task UnsubscribeProcess(int processId = 0);
    }
}
