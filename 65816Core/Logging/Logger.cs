using System.Diagnostics;

namespace Core.Logging
{
    internal static class Logger
    {
        /// <summary>
        /// Logs a message with the specified <see cref="TraceLevel"/>.
        /// Default <see cref="TraceLevel"/> is <see cref="TraceLevel.Info"/>
        /// </summary>
        /// <param name="message">The message to log</param>
        /// <param name="traceLevel">The trace to write to</param>
        public static void Log(string message, TraceLevel traceLevel = TraceLevel.Info)
        {
            switch (traceLevel)
            {
                case TraceLevel.Info:
                    Trace.WriteLine(message, traceLevel.ToString());
                    break;
                case TraceLevel.Warning:
                    Trace.WriteLine(message, traceLevel.ToString());
                    break;
                case TraceLevel.Error:
                    Trace.WriteLine(message, traceLevel.ToString());
                    break;
                case TraceLevel.Verbose:
                    Trace.WriteLine(message, traceLevel.ToString());
                    break;
                case TraceLevel.Off:
                default:
                    break;
            }
        }
    }
}
