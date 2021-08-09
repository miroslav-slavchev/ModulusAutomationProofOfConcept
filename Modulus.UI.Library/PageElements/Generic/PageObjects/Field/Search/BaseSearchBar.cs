using Modulus.UI.Library.PageElements.Generic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.PageElements.Generic.PageObjects.Field.Search
{
    public abstract class BaseSearchBar : PageObject
    {
        public TextInput TextInput => _searchContext.FindTextInput();

        public abstract IClickable SearchButton { get; }

    }
}
