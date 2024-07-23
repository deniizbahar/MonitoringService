using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace Günlük
{
    public class LoggerService : ILoggerService
    {
        private readonly Serilog.ILogger _logger;
        private readonly LoggingLevelSwitch _levelSwitch;

        public LoggerService(string filePath, LogEventLevel initialLevel)
        {
            _levelSwitch = new LoggingLevelSwitch(initialLevel);
            _logger = new LoggerConfiguration()
                .MinimumLevel.ControlledBy(_levelSwitch)
                .WriteTo.File(filePath)
                .CreateLogger();
        }

        public void Log(LogEventLevel level, string message)
        {
            _logger.Write(level, message);
        }

        public void SetLogLevel(LogEventLevel level)
        {
            _levelSwitch.MinimumLevel = level;
        }
    }
}
