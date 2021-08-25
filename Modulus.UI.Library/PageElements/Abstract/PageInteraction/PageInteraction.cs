using Modulus.UI.Library.PageElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.PageElements.Abstract
{
    public abstract class PageInteraction
    {
        protected PageObject _searchContext;

        protected abstract PageObject SearchContext { get; }

        public PageInteraction()
        {

        }

        public PageInteraction(PageObject searchContext)
        {
            _searchContext = searchContext;
        }
    }
}
