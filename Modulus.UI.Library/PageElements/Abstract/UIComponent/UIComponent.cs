using OpenQA.Selenium;

namespace Modulus.UI.Library.PageElements.Generic
{
    public abstract class UIComponent
    {
        public string Name { get; private set; }

        protected IWebElement _searchContext;

        internal UIComponent(IWebElement searchContext)
        {
            _searchContext = searchContext;
        }

        internal UIComponent()
        {
        }
    }
}
