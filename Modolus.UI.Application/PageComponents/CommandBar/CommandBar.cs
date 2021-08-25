using Modulus.UI.Library.PageElements;
using Modulus.UI.Library.PageElements.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.QA.UI.Application.Phoenix.PageComponents.CommandBar
{
    public class CommandBar : PageObject
    {
        public CommandBar(string name = null) : base(name)
        {
        }

        public Button AddButton => _searchContext.FindButton();
    }
}
