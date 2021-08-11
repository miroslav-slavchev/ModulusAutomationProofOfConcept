using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.PageElements.Generic
{
    public abstract class UIComponent
    {
        public string Name { get; private set; }

        protected IWebElement _searchContext;

        public UIComponent(IWebElement searchContext)
        {
            _searchContext = searchContext;
        }

        public UIComponent()
        {
        }
    }
}
