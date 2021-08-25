using Modulus.UI.Library.PageElements.Generic.Interfaces;
using Modulus.UI.Log;
using OpenQA.Selenium;

namespace Modulus.UI.Library.PageElements.Generic
{
    public class Button : UIComponent, IClickable
    {
        internal Button(IWebElement searchContext) : base(searchContext) { }

        public void Click()
        {
            ContextLogger.Logger.LogInfo("Click on button " + Name);
            _searchContext.Click();
        }
    }
}
