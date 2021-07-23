using Modulus.UI.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Selenium.Driver
{
    public class ChromeDriverManager : DriverManager
    {
        protected override IWebDriver GetDriverInstance()
        {
            ChromeDriver chromeDriver;
            string driverDirectory = GetDriverExeDirectory();

            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("ignore-certificate-errors");
            try
            {
                chromeDriver = new ChromeDriver(driverDirectory, chromeOptions);
            }
            catch (DriverServiceNotFoundException)
            {
                string message = string.Format(@"Driver not found in {0}", driverDirectory);
                throw new DriverServiceNotFoundException(message);
            }

            return chromeDriver;
        }

        private string GetDriverExeDirectory()
        {
            string relativePath = ConfigurationReader.GetSetting(Assembly.GetExecutingAssembly().GetName().Name, "driverExePath");
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath).ToString();
        }
    }
}
