using Modulus.UI.Library.Application.PageComponents.RecordList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.Application.PageInteractions
{
    public class RecordListInteractions
    {
        private RecordList RecordList => new(nameof(RecordList));

        public RecordInteractions GetRecord(string name)
        {
            var record = RecordList.Records.Where(record => record.RecordName.LabelText == name).FirstOrDefault();
            RecordInteractions recordInteractions = new(record);
            return recordInteractions;
        }
    }
}
