using Modulus.UI.Library.PageElements;
using Modulus.UI.Library.PageElements.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.QA.UI.Application.Phoenix.PageInteractions.CommandBar
{
    public class CommandBarInteractions : PageInteraction
    {
        protected override PageComponents.CommandBar.CommandBar SearchContext => new();

        public void SelectMenuItem(string[] path)
        {
            
        }
    }
}
