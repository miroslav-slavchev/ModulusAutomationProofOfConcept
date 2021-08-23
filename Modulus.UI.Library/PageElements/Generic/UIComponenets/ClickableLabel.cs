using Modulus.UI.Library.PageElements.Generic.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.PageElements.Generic
{
    public class ClickableLabel : Label, IClickable
    {
        public ClickableLabel(IWebElement searchContext = null) : base(searchContext) { }

        public void Click() => _searchContext.Click();

    }
}
