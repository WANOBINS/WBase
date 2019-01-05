using System;

namespace WBase.Core.Logging
{
    public interface ILogger
    {
        #region General
        void Log(LogLevel logLevel, string message);
        void Log(LogLevel logLevel, Exception exception);
        #endregion General

        #region Trace
        void LogTrace(string message);
        void LogTrace(Exception exception);
        #endregion Trace

        #region Debug
        void LogDebug(string message);
        void LogDebug(Exception exception);
        #endregion Debug

        #region Info
        void LogInfo(string message);
        void LogInfo(Exception exception);
        #endregion Info

        #region Warning
        void LogWarning(string message);
        void LogWarning(Exception exception);
        #endregion Warning

        #region Error
        void LogError(string message);
        void LogError(Exception exception);
        #endregion Error

        #region Fatal
        void LogFatal(string message);
        void LogFatal(Exception exception);
        #endregion Fatal
    }
}
