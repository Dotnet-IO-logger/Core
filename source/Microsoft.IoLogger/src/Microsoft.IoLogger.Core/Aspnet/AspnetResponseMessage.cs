namespace Microsoft.IoLogger.Core.Aspnet
{
    using System;
    using System.Collections.Generic;

    public class AspnetResponseMessage : BaseLoggerMessage
    {
        public Guid CorrelationId { get; set; }
        public DateTime Date { get; set; }
        public int StatusCode { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public object Body { get; set; }
    }
}
