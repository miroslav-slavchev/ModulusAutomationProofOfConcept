using Modulus.UI.Library.PageElements;
using Modulus.UI.Library.PageElements.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.QA.UI.Application.Phoenix.PageComponents.Plans
{
    public class PlansSectionItem : PageObject
    {
        public PlansSectionItem(Container searchContext) : base(searchContext)
        {
        }

        public Label Name => _searchContext.FindLabel();

        public Button Ellipsis => _searchContext.FindButton();

    }
}
