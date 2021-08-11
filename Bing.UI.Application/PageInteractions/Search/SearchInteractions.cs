using Modulus.QA.UI.Application.Bing.PageComponents;
using Modulus.QA.UI.Library.PageElements.Abstract.PageObject;
using Modulus.QA.UI.Library.PageElements.Abstract.PageObject.Wait;
using Modulus.UI.Library.PageElements;
using Modulus.UI.Library.PageElements.Abstract;
using Modulus.UI.Library.PageElements.Generic;
using Modulus.UI.Library.PageElements.Generic.PageInteractions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.QA.UI.Application.Bing.PageInteractions
{
    public class SearchInteractions : PageInteraction
    {
        protected override SearchBar SearchContext => new("SearchBar", WaitUIObject.ToBeVisible(5));

        public void PerformQuickSearch(string textInput)
        {
            SearchContext.TextInput.EnterText(textInput);
            SearchContext.SearchButton.Click();
        }

        public KeyboardInteractions ClickKeyboardButton()
        {
            SearchContext.Keyboard.Click();
            return new();
        }

        public ImageSearchPane ClickImageSearchButton()
        {
            SearchContext.ImageSearch.Click();
            return new();
        }
    }
}
