﻿using KafkaCurator.Configuration;

namespace KafkaCurator.LogHandler.Microsoft
{
    /// <summary>
    /// No needed
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Configure KafkaCurator to use the  Microsoft Logging framework to log messages.
        /// </summary>
        /// <param name="builder">The Kafka configuration builder</param>
        /// <returns></returns>
        public static IKafkaConfigurationBuilder UseMicrosoftLog(this IKafkaConfigurationBuilder builder) =>
            builder.UseLogHandler<MicrosoftLogHandler>();
    }
}