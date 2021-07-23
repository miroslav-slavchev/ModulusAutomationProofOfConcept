﻿using Modulus.UI.Library.PageComponents.Generic;
using Modulus.UI.Library.PageComponents.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.Application.PageComponents.RecordList
{
    public class SubRecord : PageObject
    {
        public SubRecord(string name, Container searchContext = null) : base(name, searchContext)
        {
        }

        public Dictionary<string, Label> FieldValues;

    }
}
