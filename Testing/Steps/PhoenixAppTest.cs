using Modulus.QA.UI.Application.Phoenix.PageInteractions.LogIn;
using Modulus.QA.UI.Application.Phoenix.Pages;
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
    public class PhoenixAppTest : BaseTest
    {

        private static void LogIn()
        {
            DriverManagerContext.DriverManager.LoadUrl("https://qa2.retaincloud.com/uiauto/");
            LogInInteractions logIn = new LogInInteractions();
            logIn.LogIn("AutomationUser@retaininternational.com", "Automation");
        }

        [Test]
        public void RecordListRecord()
        {

            LogIn();

            PlannerPage page = new PlannerPage();
            var record = page.RecordList.GetRecord("Automation").GetSubRecord("Unassigned");
        }
    }
}
