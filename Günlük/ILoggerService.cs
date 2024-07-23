using Serilog.Events;

namespace Günlük
{
    public interface ILoggerService
    {
        void Log(LogEventLevel level, string message);
        void SetLogLevel(LogEventLevel level);
    }
}
