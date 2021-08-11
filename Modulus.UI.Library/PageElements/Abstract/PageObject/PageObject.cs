using Modulus.QA.UI.Library.PageElements.Abstract.PageObject;
using Modulus.QA.UI.Library.PageElements.Abstract.PageObject.Wait;
using Modulus.UI.Library.PageElements.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.PageElements
{
    public class PageObject
    {
        protected Container _searchContext;

        public PageObject(Container searchContext)
        {
            _searchContext = searchContext;
        }

        public PageObject(string name = null)
        {
            if (name == null)
            {
                name = GetDefaultName();
            }

            InitSearchContext(name, null);
        }

        public PageObject(string name = null, Container searchContext = null)
        {
            if (name == null)
            {
                name = GetDefaultName();
            }

            InitSearchContext(name, searchContext);
        }

        public PageObject(string name = null, WaitUIObject waitPageObject = null)
        {
            if (name == null)
            {
                name = GetDefaultName();
            }

            _searchContext = new Container(name, waitPageObject);
        }

        private void InitSearchContext(string name, Container searchContext)
        {
            if (searchContext == null)
            {
                _searchContext = new Container(name);
            }
            else
            {
                _searchContext = searchContext;
            }
        }

        private static string GetDefaultName()
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
    }
}
