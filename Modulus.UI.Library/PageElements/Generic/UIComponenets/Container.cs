using Modulus.UI.Library.Selenium.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.PageElements.Generic
{
    public class Container : UIComponent
    {
        protected LocatorProvider LocatorProvider { get; set; }

        internal Container(string locatorFileNmae, IWebElement searchContext = null) : base(searchContext)
        {
            LocatorProvider = new LocatorProvider(locatorFileNmae);
            InitSearchContext(searchContext);
        }

        private void InitSearchContext(IWebElement searchContext)
        {
            if (searchContext == null)
            {
                _searchContext = DriverManagerContext.DriverManager.Driver.FindElement(LocatorProvider.GetSearchContextLocator());
            }
            else
            {
                _searchContext = searchContext;
            }
        }

        public Container FindContainer(string name = null) => new(name, GetElement(name));

        public List<Container> FindContainers(string name = null) => GetElements(name).Select(element => new Container(name, element)).ToList();

        public TextInput FindTextInput(string name = null) => new(GetElement(name));

        public Button FindButton(string name = null) => new(GetElement(name));

        public Icon FindIcon(string name = null) => new(GetElement(name));

        public IconButton FindClickableIcon(string name = null) => new(GetElement(name));

        public ClickableLabel FindClickableLabel(string name = null) => new(GetElement(name));

        #region GetElement
        private IWebElement GetElement(string name = null)
        {
            By locator = LocatorProvider.GetLocator(name);
            IWebElement element = _searchContext.FindElement(locator);
            return element;
        }

        private List<IWebElement> GetElements(string name = null)
        {
            By locator = LocatorProvider.GetLocator(name);
            List<IWebElement> elements = _searchContext.FindElements(locator).ToList();
            return elements;
        }
        #endregion
    }
}
