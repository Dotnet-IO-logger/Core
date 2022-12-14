namespace Microsoft.IoLogger.Core.Http
{
    public enum HttpEventCodesEnum
    {
        RequestStart = 100,
        RequestEnd = 101,
        RequestHeader = 102,
        ResponseHeader = 103
    }

    public class HttpRequestStartModel
    {
        public string HttpMethod { get; set; }
        public string Uri { get; set; }
    }

    public class HttpRequestEndModel
    {
        public string StatusCode { get; set; }
    }
}
