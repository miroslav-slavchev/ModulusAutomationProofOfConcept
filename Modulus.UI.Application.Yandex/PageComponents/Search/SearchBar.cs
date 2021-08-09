using Modulus.UI.Library.PageElements.Generic;
using Modulus.UI.Library.PageElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modulus.UI.Library.PageElements.Generic.PageObjects.Field.Search;
using Modulus.UI.Library.PageElements.Generic.Interfaces;

namespace Modulus.UI.Application.Yandex.PageComponents
{
    public class SearchBar : BaseSearchBar
    {
        public override Button SearchButton => _searchContext.FindButton();

        public IconButton Keyboard => _searchContext.FindClickableIcon();
    }
}
