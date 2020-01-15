using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Logger
    {
        private static Logger instance;
        private Logger()
        {

        }
        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }
    }
}
