using Modulus.UI.Library.PageElements.Generic;
using Modulus.UI.Library.PageElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.QA.UI.Application.Phoenix.PageComponents.RecordList
{
    public class SubRecord : PageObject
    {
        public SubRecord(string name, Container searchContext = null) : base(name, searchContext)
        {
        }

        public Dictionary<string, Label> FieldValues;

    }
}
