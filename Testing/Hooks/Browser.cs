using Modulus.UI.Library.Application.PageInteractions.LogIn;
using Modulus.UI.Library.Selenium.Driver;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Hooks
{
    public class Browser
    {
        [SetUp]
        public void SetUp()
        {
            DriverManagerContext.DriverManager.StartDriver();
            DriverManagerContext.DriverManager.LoadUrl("https://qa2.retaincloud.com/uiauto/");
            LogIn();
        }

        private static void LogIn()
        {
            LogInInteractions logIn = new LogInInteractions();
            logIn.LogIn("AutomationUser@retaininternational.com", "Automation");
        }

        [TearDown]
        public void TearDown()
        {
            DriverManagerContext.DriverManager.QuitDriver();
        }
    }
}
