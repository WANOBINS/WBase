using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using WBase.Core.Properties;

namespace WBase.Core.Logging
{
    public class LogLevel
    {
        public static readonly LogLevel TRACE = new LogLevel(LoggingResources.LogLevel_Trace, ConsoleColor.Gray, ConsoleColor.Black);
        public static readonly LogLevel DEBUG = new LogLevel(LoggingResources.LogLevel_Debug, ConsoleColor.DarkGray, ConsoleColor.Black);
        public static readonly LogLevel INFO = new LogLevel(LoggingResources.LogLevel_Info, ConsoleColor.White, ConsoleColor.Black);
        public static readonly LogLevel WARNING = new LogLevel(LoggingResources.LogLevel_Warning, ConsoleColor.Yellow, ConsoleColor.Black);
        public static readonly LogLevel ERROR = new LogLevel(LoggingResources.LogLevel_Error, ConsoleColor.Red, ConsoleColor.Black);
        public static readonly LogLevel FATAL = new LogLevel(LoggingResources.LogLevel_Fatal, ConsoleColor.Black, ConsoleColor.Red);

        public static IEnumerable<LogLevel> Values
        {
            get
            {
                yield return TRACE;
                yield return DEBUG;
                yield return INFO;
                yield return WARNING;
                yield return ERROR;
                yield return FATAL;
            }

        }

        LogLevel(string TransKey, ConsoleColor ForeColor, ConsoleColor? BackColor)
        {
            this.TransKey = TransKey;
            this.ForeColor = ForeColor;
            this.BackColor = BackColor;
        }

        public string TransKey { get; private set; }
        public ConsoleColor ForeColor { get; private set; }
        public ConsoleColor? BackColor { get; private set; }
    }
}
