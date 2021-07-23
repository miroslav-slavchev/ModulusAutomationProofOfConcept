using Modulus.UI.Selenium.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.Selenium.Driver
{
    public static class DriverManagerContext
    {
        private static DriverManager _instance;

        public static DriverManager DriverManager
        {
            get
            {
                if (_instance == null)
                {
                    var driver = DriverManagerContextType.DriverManager;
                    if (driver == null)
                    {
                        _instance = new ChromeDriverManager();
                    }
                    else
                    {
                        _instance = driver;
                    }
                }
                return _instance;
            }
        }

        public static class DriverManagerContextType
        {
            public static DriverManager DriverManager { get; set; }
        }
    }
}
