using Modulus.UI.Library.PageElements.Generic.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.PageElements.Generic
{
    public class TextInput : UIComponent, ITextInput
    {
        public TextInput(IWebElement searchContext) : base(searchContext)
        {
        }

        public void EnterText(string text)
        {
            _searchContext.SendKeys(text);
        }

        public TextInput Focus()
        {
            _searchContext.Click();
            return this;
        }
    }
}
