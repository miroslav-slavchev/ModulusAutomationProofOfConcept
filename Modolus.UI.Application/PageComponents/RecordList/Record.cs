using Modulus.UI.Library.PageElements.Generic;
using Modulus.UI.Library.PageElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.QA.UI.Application.Phoenix.PageComponents.RecordList
{
    public class Record : PageObject
    {
        public Record(string name, Container searchContext = null) : base(name, searchContext)
        {
        }

        public IconButton ExpandCollapseArrow => _searchContext.FindClickableIcon(nameof(ExpandCollapseArrow));

        public ClickableLabel RecordName => _searchContext.FindClickableLabel(nameof(RecordName));

        public List<SubRecord> SubRecords => _searchContext.FindContainers(nameof(SubRecord)).Select(recordContainer => new SubRecord(nameof(SubRecord), recordContainer)).ToList();

    }
}
