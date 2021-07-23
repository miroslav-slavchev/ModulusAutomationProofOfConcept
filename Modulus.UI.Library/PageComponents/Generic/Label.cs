using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.PageComponents.Generic
{
    public class Label : UIComponent
    {
        public Label(IWebElement searchContext = null) : base(searchContext)
        {
        }

        public string LabelText => _searchContext.Text;

        public ClickableLabel IsClickable()
        {
            if (true)
            {
                return (ClickableLabel)this;
            }
            else
            {
                return null;
            }
        }
    }
}
