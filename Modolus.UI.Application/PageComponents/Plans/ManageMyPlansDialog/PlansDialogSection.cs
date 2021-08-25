using Modulus.UI.Library.PageElements;
using Modulus.UI.Library.PageElements.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.QA.UI.Application.Phoenix.PageComponents.Plans
{
    public class PlansDialogSection : PageObject
    {
        public PlansDialogSection(Container searchContext) : base(searchContext) { }

        public Icon Icon => _searchContext.FindIcon();

        public Label Header => _searchContext.FindClickableLabel();

        public List<PlansSectionItem> PlansSectionItems => _searchContext.FindContainers().Select(item => new PlansSectionItem(item)).ToList();
    }
}
