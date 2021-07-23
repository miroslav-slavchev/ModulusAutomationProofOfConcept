using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.PageComponents.Generic
{
    public class TextInput : UIComponent
    {
        public TextInput(IWebElement searchContext) : base(searchContext)
        {
        }

        public void EnterText(string text)
        {
            _searchContext.SendKeys(text);
        }
    }
}
