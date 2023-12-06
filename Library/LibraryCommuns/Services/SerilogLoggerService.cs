using LibraryCommuns.Interfaces;
using Serilog;

namespace LibraryCommuns.Services
{
    public class SerilogLoggerService : ILoggerService
    {
        private readonly ILogger _logger;

        public SerilogLoggerService()
        {
            _logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
        }

        public void LogInformation(string message)
        {
            _logger.Information(message);
        }

        public void LogWarning(string message)
        {
            _logger.Warning(message);
        }

        public void LogError(string message, Exception ex = null)
        {
            if (ex != null)
            {
                _logger.Error(ex, message);
            }
            else
            {
                _logger.Error(message);
            }
        }
    }
}
