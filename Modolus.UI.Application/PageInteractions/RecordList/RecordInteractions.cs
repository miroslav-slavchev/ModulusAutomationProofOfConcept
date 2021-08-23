using Modulus.QA.UI.Application.Phoenix.PageComponents.RecordList;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Modulus.QA.UI.Application.Phoenix.PageInteractions
{
    public class RecordInteractions
    {
        private Record Record { get; set; }

        public RecordInteractions(Record record)
        {
            Record = record;
        }

        public SubRecordInteractions GetSubRecord(string name)
        {
            var subRecord = Record.SubRecords.Where(subRecordObject => subRecordObject.FieldValues.First().Value.TextContent == name).FirstOrDefault();
            SubRecordInteractions recordInteractions = new(subRecord);
            return recordInteractions;
        }

        public string Name => Record.RecordName.TextContent;

        public void ClickExpandCollapseArrow() => Record.ExpandCollapseArrow.Click();

        public void Click() => Record.RecordName.Click();
    }
}