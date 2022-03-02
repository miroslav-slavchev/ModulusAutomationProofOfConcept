using Modulus.QA.UI.Application.Bing.Pages;
using Modulus.QA.UI.Application.Yandex.Pages;
using Modulus.UI.Library.Selenium.Driver;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Hooks;

namespace Testing.Steps
{
    public class SearchTest : BaseTest
    {
        [Test]
        public void BingTest()
        {
            DriverManagerContext.DriverManager.LoadUrl("https://www.bing.com/");
            BingHomePage page = new BingHomePage();
            page.Search.PerformQuickSearch("selenium");

        }

        [Test]
        public void YandexTest()
        {
            DriverManagerContext.DriverManager.LoadUrl("https://yandex.com/");
            YandexHomePage page = new YandexHomePage();
            page.Search.PerformQuickSearch("selenium");
        }
    }
}
