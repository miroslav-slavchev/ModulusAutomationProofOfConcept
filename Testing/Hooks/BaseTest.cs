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
    public class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            DriverManagerContext.DriverManager.StartDriver();
        }

        [TearDown]
        public void TearDown()
        {
            DriverManagerContext.DriverManager.QuitDriver();
        }
    }
}
