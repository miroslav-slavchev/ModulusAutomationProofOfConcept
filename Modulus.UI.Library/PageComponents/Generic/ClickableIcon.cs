using Modulus.UI.Log;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.PageComponents.Generic
{
    public class ClickableIcon : Icon
    {
        private IWebElement ClickableContext {get;set;}

        public ClickableIcon(IWebElement searchContext = null) : base(searchContext)
        {
        }

        public void Click()
        {
            ContextLogger.Logger.LogInfo("About to click on icon " + Name);
            if (ClickableContext == null)
            {
                _searchContext.Click();
            }
            else
            {
                ClickableContext.Click();
            }
        }
    }
}
