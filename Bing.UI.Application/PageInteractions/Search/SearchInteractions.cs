using Modulus.UI.Application.Bing.PageComponents;
using Modulus.UI.Library.PageElements;
using Modulus.UI.Library.PageElements.Abstract;
using Modulus.UI.Library.PageElements.Generic;
using Modulus.UI.Library.PageElements.Generic.PageInteractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Application.Bing.PageInteractions
{
    public class SearchInteractions : PageInteraction
    {
        protected override SearchBar SearchContext => new SearchBar();

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
