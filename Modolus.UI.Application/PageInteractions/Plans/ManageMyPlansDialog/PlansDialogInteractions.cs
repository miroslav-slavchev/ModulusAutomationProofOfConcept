using Modulus.QA.UI.Application.Phoenix.PageComponents.Plans;
using Modulus.UI.Library.PageElements;
using Modulus.UI.Library.PageElements.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.QA.UI.Application.Phoenix.PageInteractions.Plans
{
    public class PlansDialogInteractions : PageInteraction
    {
        protected override ManageMyPlansDialog SearchContext => new();

        protected Dictionary<string, PlanItemInteractions> MyPlans;

        protected Dictionary<string, PlanItemInteractions> PublicPlans;
    }
}
