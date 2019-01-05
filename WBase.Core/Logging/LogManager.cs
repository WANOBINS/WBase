using System;
using System.Collections.Generic;
using System.Text;

namespace WBase.Core.Logging
{
    class LogManager
    {
        internal static ILogger GetLogger(string v)
        {
            return new BaseLogger(v);
        }

        internal class BaseLogger : ILogger
        {
            internal readonly string Name;
            internal readonly LoggingWindow LoggingWindow;
            internal BaseLogger(string Name)
            {
                this.Name = Name;
            }

            public void Log(LogLevel logLevel, string message)
            {
                throw new NotImplementedException();
            }

            public void Log(LogLevel logLevel, Exception exception)
            {
                throw new NotImplementedException();
            }

            public void LogDebug(string message)
            {
                throw new NotImplementedException();
            }

            public void LogDebug(Exception exception)
            {
                throw new NotImplementedException();
            }

            public void LogError(string message)
            {
                throw new NotImplementedException();
            }

            public void LogError(Exception exception)
            {
                throw new NotImplementedException();
            }

            public void LogFatal(string message)
            {
                throw new NotImplementedException();
            }

            public void LogFatal(Exception exception)
            {
                throw new NotImplementedException();
            }

            public void LogInfo(string message)
            {
                throw new NotImplementedException();
            }

            public void LogInfo(Exception exception)
            {
                throw new NotImplementedException();
            }

            public void LogTrace(string message)
            {
                throw new NotImplementedException();
            }

            public void LogTrace(Exception exception)
            {
                throw new NotImplementedException();
            }

            public void LogWarning(string message)
            {
                throw new NotImplementedException();
            }

            public void LogWarning(Exception exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
