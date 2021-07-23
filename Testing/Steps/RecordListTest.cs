using Modulus.UI.Library.Application.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Hooks;

namespace Testing.Steps
{
    public class RecordListTest : Browser
    {
        [Test]
        public void RecordListRecord()
        {
            PlannerPage page = new PlannerPage();
            var record = page.RecordList.GetRecord("Automation").GetSubRecord("Unassigned");
        }
    }
}
