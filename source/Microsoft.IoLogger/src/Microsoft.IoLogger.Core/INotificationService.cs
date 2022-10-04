namespace Microsoft.IoLogger.Core
{
    using Microsoft.IoLogger.Core.Aspnet;
    using Microsoft.IoLogger.Core.Http;
    using System.Threading.Tasks;

    public interface INotificationService
    {
        Task HttpRequest(HttpRequestMessage request);

        Task HttpResponse(HttpResponseMessage response);

        Task AspnetRequest(AspnetRequestMessage request);

        Task AspnetResponse(AspnetResponseMessage response);
    }
}
