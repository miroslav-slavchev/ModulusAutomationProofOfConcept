using Modulus.UI.Library.PageElements.Generic;
using Modulus.UI.Library.PageElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modulus.UI.Library.PageElements.Generic.PageObjects.Field.Search;
using Modulus.UI.Library.PageElements.Generic.Interfaces;

namespace Modulus.UI.Application.Bing.PageComponents
{
    public class SearchBar : BaseSearchBar
    {
        public IconButton VoiceSearch => _searchContext.FindClickableIcon();

        public IconButton ImageSearch => _searchContext.FindClickableIcon();

        public IconButton Keyboard => _searchContext.FindClickableIcon();

        public override IconButton SearchButton => _searchContext.FindClickableIcon();

    }
}
