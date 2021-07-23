using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Log
{
    public class DefaultLogger : ILogger
    {
        public void LogDebug(string message)
        {
            string prefix = "-> debug: ";
            Log(prefix, message);
        }

        public void LogError(string message)
        {
            string prefix = "-> error: ";
            Log(prefix, message);
        }

        public void LogInfo(string message)
        {
            string prefix = "-> info: ";
            Log(prefix, message);
        }

        public void LogWarning(string message)
        {
            string prefix = "-> warning: ";
            Log(prefix, message);
        }

        private void Log(string prefix, string message)
        {
            Console.WriteLine(prefix + message);
        }
    }
}
