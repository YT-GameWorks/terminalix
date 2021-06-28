using NLog;
using System;

namespace terminalix.api.Logging
{
	public class Logger
	{
		private static readonly NLog.Logger logger = LogManager.GetLogger("fileTarget");

		public void Log(LogTypes logType, string logMessage)
		{
			switch (logType)
			{
				case LogTypes.INFO:
					logger.Info(logMessage);
					break;
				case LogTypes.DEBUG:
					logger.Debug(logMessage);
					break;
				case LogTypes.WARN:
					logger.Warn(logMessage);
					break;
				case LogTypes.TRACE:
					logger.Trace(logMessage);
					break;
				case LogTypes.ERROR:
					logger.Error(logMessage);
					break;
				case LogTypes.FATAL:
					logger.Fatal(logMessage);
					break;
				default:
					logger.Info(logMessage);
					break;
			}
		}

		public void Log(LogTypes logType, string logMessage, Exception ex)
		{
			switch (logType)
			{
				case LogTypes.INFO:
					logger.Info(ex, logMessage);
					break;
				case LogTypes.DEBUG:
					logger.Debug(ex, logMessage);
					break;
				case LogTypes.WARN:
					logger.Warn(ex, logMessage);
					break;
				case LogTypes.TRACE:
					logger.Trace(ex, logMessage);
					break;
				case LogTypes.ERROR:
					logger.Error(ex, logMessage);
					break;
				case LogTypes.FATAL:
					logger.Fatal(ex, logMessage);
					break;
				default:
					logger.Info(ex, logMessage);
					break;
			}
		}

		public void ShutDownLogging()
		{
			LogManager.Shutdown();
		}
	}
}
