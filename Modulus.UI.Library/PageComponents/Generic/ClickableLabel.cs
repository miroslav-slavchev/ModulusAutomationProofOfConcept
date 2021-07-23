using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.PageComponents.Generic
{
    public class ClickableLabel : Label
    {
        public ClickableLabel(IWebElement searchContext = null) : base(searchContext) { }

        public void Click() => _searchContext.Click();

    }
}
