using Serilog.Events;

namespace Günlük
{
    public static class LoggerHelper
    {
        private static ILoggerService _loggerService;
        //singleton
        public static void ConfigureLogger(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        public static void SetLogLevel(LogEventLevel level)
        {
            _loggerService.SetLogLevel(level);
        }

        public static void Log(LogEventLevel level, string message)
        {
            _loggerService.Log(level, message);
        }
    }
}
