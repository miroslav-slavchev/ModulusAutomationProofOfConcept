using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Log
{
    public sealed class ContextLogger
    {
        private static ILogger _instance;

        public static ILogger Logger
        {
            get
            {
                if (_instance == null)
                {
                    var customLogger = ContextLoggerInstance.Logger;
                    if (customLogger == null)
                    {
                        _instance = new DefaultLogger();
                    }
                    else
                    {
                        _instance = customLogger;
                    }
                }
                return _instance;
            }
        }
    }

    public static class ContextLoggerInstance
    {
        public static ILogger Logger { get; set; }
    }
}
