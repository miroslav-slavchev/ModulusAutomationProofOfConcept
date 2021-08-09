using Modulus.UI.Library.PageElements.Generic;
using Modulus.UI.Library.PageElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.Application.PageComponents.RecordList
{
    public class RecordList : PageObject
    {
        public RecordList(string name, Container searchContext = null) : base(name, searchContext)
        {

        }

        public List<Record> Records => _searchContext.FindContainers(nameof(Record)).Select(recordContainer => new Record(nameof(Record), recordContainer)).ToList();
    }
}
