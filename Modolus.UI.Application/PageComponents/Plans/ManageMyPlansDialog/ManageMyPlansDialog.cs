using Modulus.UI.Library.PageElements;
using Modulus.UI.Library.PageElements.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.QA.UI.Application.Phoenix.PageComponents.Plans
{
    public class ManageMyPlansDialog : PageObject
    {
        public ManageMyPlansDialog(string name = null) : base(name) { }

        public Button NewPlanButton => _searchContext.FindButton();

        public PlansDialogSection MyPlans => new PlansDialogSection(_searchContext.FindContainer(nameof(MyPlans)));

        public PlansDialogSection PublicPlans => new PlansDialogSection(_searchContext.FindContainer(nameof(PublicPlans)));
    }
}
