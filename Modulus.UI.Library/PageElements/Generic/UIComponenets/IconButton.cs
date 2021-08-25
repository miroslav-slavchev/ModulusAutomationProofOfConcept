using Modulus.UI.Library.PageElements.Generic.Interfaces;
using Modulus.UI.Log;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.PageElements.Generic
{
    public class IconButton : Icon, IClickable
    {
        private IWebElement ClickableContext { get; set; }

        internal IconButton(IWebElement searchContext = null) : base(searchContext)
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
