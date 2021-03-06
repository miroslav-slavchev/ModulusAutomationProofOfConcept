using Modulus.UI.Library.PageElements.Generic;
using Modulus.UI.Library.PageElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modulus.UI.Library.PageElements.Generic.PageObjects.Field.Search;
using Modulus.UI.Library.PageElements.Generic.Interfaces;
using Modulus.QA.UI.Library.PageElements.Abstract.PageObject;
using Modulus.QA.UI.Library.PageElements.Abstract.PageObject.Wait;

namespace Modulus.QA.UI.Application.Bing.PageComponents
{
    public class SearchBar : BaseSearchBar
    {
        public SearchBar(string name, WaitUIObject waitConditions) : base(name, waitConditions) { }

        public IconButton VoiceSearch => _searchContext.FindClickableIcon();

        public IconButton ImageSearch => _searchContext.FindClickableIcon();

        public IconButton Keyboard => _searchContext.FindClickableIcon();

        public override IconButton SearchButton => _searchContext.FindClickableIcon();

    }
}
