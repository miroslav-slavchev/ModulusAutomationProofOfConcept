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
    public class Button : UIComponent, IClickable
    {
        public Button(IWebElement searchContext) : base(searchContext)
        {
        }

        public void Click()
        {
            ContextLogger.Logger.LogInfo("Click on button " + Name);
            _searchContext.Click();
        }
    }
}
