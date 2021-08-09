using Modulus.UI.Application.Yandex.PageComponents;
using Modulus.UI.Library.PageElements;
using Modulus.UI.Library.PageElements.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Application.Yandex.PageInteractions
{
    public class SearchInteractions : PageInteraction
    {
        protected override SearchBar SearchContext => new();

       
    }
}
