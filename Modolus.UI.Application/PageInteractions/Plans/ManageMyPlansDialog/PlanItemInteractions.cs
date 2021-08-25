using Modulus.QA.UI.Application.Phoenix.PageComponents.Plans;
using Modulus.UI.Library.PageElements.Abstract;

namespace Modulus.QA.UI.Application.Phoenix.PageInteractions.Plans
{
    public class PlanItemInteractions : PageInteraction
    {

        protected override PlansSectionItem SearchContext => (PlansSectionItem)_searchContext;

        public PlanItemInteractions(PlansSectionItem plansSectionItem) : base(plansSectionItem)
        {
        }

        public string Name;

        public bool IsSeleted;

        public PlanItemContextMenuInteractions ClickEllispis()
        {
            SearchContext.Ellipsis.Click();
            return new PlanItemContextMenuInteractions();
        }
    }
}
