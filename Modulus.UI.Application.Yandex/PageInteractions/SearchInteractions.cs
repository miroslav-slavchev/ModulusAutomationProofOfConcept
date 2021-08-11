using Modulus.QA.UI.Application.Yandex.PageComponents;
using Modulus.UI.Library.PageElements;
using Modulus.UI.Library.PageElements.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.QA.UI.Application.Yandex.PageInteractions
{
    public class SearchInteractions : PageInteraction
    {
        protected override SearchBar SearchContext => new("SearchBar");

        public void PerformQuickSearch(string text)
        {
            SearchContext.TextInput.EnterText(text);
            SearchContext.SearchButton.Click();
        }
    }
}
