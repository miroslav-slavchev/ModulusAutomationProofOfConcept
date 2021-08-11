using Modulus.QA.UI.Library.PageElements.Abstract.PageObject;
using Modulus.QA.UI.Library.PageElements.Abstract.PageObject.Wait;
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
        public BaseSearchBar(string name, WaitUIObject waitConditions) : base(name, waitConditions) { }

        public BaseSearchBar(string name) : base(name) { }

        public TextInput TextInput => _searchContext.FindTextInput();

        public abstract IClickable SearchButton { get; }

    }
}
