using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class LoggerThreadsafe
    {
        private static LoggerThreadsafe instance;
        private static readonly object padLock = new object();
        private LoggerThreadsafe()
        {

        }
        public static LoggerThreadsafe Instance
        {
            get
            {
                lock (padLock)
                {
                    if (instance == null)
                    {
                        instance = new LoggerThreadsafe();
                    }
                    return instance;
                }
            }
        }
    }
}
