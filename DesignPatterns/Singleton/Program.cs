using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = Logger.Instance;
            var loggerThreadsafe = LoggerThreadsafe.Instance;
            var secondLogger = Logger.Instance;
            var secondLoggerThreadsafe = LoggerThreadsafe.Instance;
            Console.WriteLine(logger.GetHashCode() == secondLogger.GetHashCode());
            Console.WriteLine(loggerThreadsafe.GetHashCode() == secondLoggerThreadsafe.GetHashCode());
            Console.WriteLine();
        }
    }
}
