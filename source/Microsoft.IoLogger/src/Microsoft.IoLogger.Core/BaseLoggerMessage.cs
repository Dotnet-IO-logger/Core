namespace Microsoft.IoLogger.Core
{
    public abstract class BaseLoggerMessage
    {
        public virtual bool IsMessageCompleted => true;
    }
}
