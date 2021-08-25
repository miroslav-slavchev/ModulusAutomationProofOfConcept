using Modulus.QA.UI.Library.PageElements.Abstract.Interfaces.UIComponent.Read;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.PageElements.Generic
{
    public class Label : UIComponent, IReadable
    {
        internal Label(IWebElement searchContext = null) : base(searchContext)
        {
        }

        public string TextContent => _searchContext.Text;

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
