using System;
using System.Text.Json;
using KafkaCurator.Abstractions;
using Microsoft.Extensions.Logging;

namespace KafkaCurator.LogHandler.Microsoft
{
    public class MicrosoftLogHandler : ILogHandler
    {
        private readonly ILogger _logger;

        public MicrosoftLogHandler(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger("KafkaCurator");
        }

        public void Error(string message, Exception ex, object data)
        {
            _logger.LogError(ex, "{Message} | Data: {Data}", message, JsonSerializer.Serialize(data));
        }

        public void Warning(string message, object data)
        {
            _logger.LogWarning("{Message} | Data: {Data}", message, JsonSerializer.Serialize(data));
        }

        public void Info(string message, object data)
        {
            _logger.LogInformation("{Message} | Data: {Data}", message, JsonSerializer.Serialize(data));
        }

        public void Verbose(string message, object data)
        {
            _logger.LogDebug("{Message} | Data: {Data}", message, JsonSerializer.Serialize(data));
        }
    }
}