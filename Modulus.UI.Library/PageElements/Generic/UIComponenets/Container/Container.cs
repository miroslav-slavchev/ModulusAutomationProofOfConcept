using Modulus.QA.UI.Library.PageElements.Abstract.PageObject.Wait;
using Modulus.QA.UI.Library.PageElements.Generic.UIComponenets.Container;
using Modulus.UI.Library.Selenium.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace Modulus.UI.Library.PageElements.Generic
{
    public class Container : UIComponent
    {
        protected LocatorProvider LocatorProvider { get; set; }

        internal Container(string locatorFileNmae) : base()
        {
            LocatorProvider = new LocatorProvider(locatorFileNmae);
            InitSearchContext(null);
        }

        internal Container(string locatorFileNmae, IWebElement searchContext = null) : base()
        {
            LocatorProvider = new LocatorProvider(locatorFileNmae);
            InitSearchContext(searchContext);
        }

        internal Container(string locatorFileNmae, WaitUIObject waitUIObject = null) : base()
        {
            LocatorProvider = new LocatorProvider(locatorFileNmae);
            InitSearchContextWithWait(waitUIObject);
        }

        public Container FindContainer(string name = null) => new(name, GetElement(name));

        public List<Container> FindContainers(string name = null) => GetElements(name).Select(element => new Container(name, element)).ToList();

        public TextInput FindTextInput(string name = null) => new(GetElement(name));

        public Button FindButton(string name = null) => new(GetElement(name));

        public Icon FindIcon(string name = null) => new(GetElement(name));

        public IconButton FindClickableIcon(string name = null) => new(GetElement(name));

        public ClickableLabel FindClickableLabel(string name = null) => new(GetElement(name));

        #region InitSearchContext
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

        private void InitSearchContextWithWait(WaitUIObject waitConditions)
        {
            if (waitConditions == null)
            {
                _searchContext = DriverManagerContext.DriverManager.Driver.FindElement(LocatorProvider.GetSearchContextLocator());
            }
            else
            {
                // TODO - wait mechanism
                WebDriverWait wait = new WebDriverWait(DriverManagerContext.DriverManager.Driver, waitConditions.TimeSpan);
                _searchContext = wait.Until(ExpectedConditions.ElementIsVisible(LocatorProvider.GetSearchContextLocator()));
                //Thread.Sleep(5000);
                //_searchContext = DriverManagerContext.DriverManager.Driver.FindElement(LocatorProvider.GetSearchContextLocator());
            }
        }
        #endregion

        #region GetElement
        private IWebElement GetElement(string name = null, WaitUIObject waitUIObject = null)
        {
            if (name == null)
            {
                name = GetDefaultName();
            }

            By locator = LocatorProvider.GetLocator(name);
            IWebElement element;

            if (waitUIObject == null)
            {
                element = FindElement(locator);
            }
            else
            {
                element = WaitFactory.WaitForElement(locator, waitUIObject);
            }

            return element;
        }

        private IWebElement FindElement(By locator)
        {
            return _searchContext.FindElement(locator);
        }

        private List<IWebElement> GetElements(string name = null)
        {
            By locator = LocatorProvider.GetLocator(name);
            List<IWebElement> elements = _searchContext.FindElements(locator).ToList();
            return elements;
        }

        private string GetDefaultName()
        {
            StackTrace stackTrace = new StackTrace();
            StackFrame stackFrame = stackTrace.GetFrame(3);
            MethodBase methodBase = stackFrame.GetMethod();
            string name = methodBase.Name;

            if (name.StartsWith("get_"))
            {
                name = name.Split("get_")[1];
            }
            return name;
        }
        #endregion
    }
}
