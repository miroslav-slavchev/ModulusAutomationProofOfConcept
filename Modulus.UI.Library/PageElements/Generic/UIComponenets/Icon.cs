using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.PageElements.Generic
{
    public class Icon : UIComponent
    {
        internal Icon(IWebElement searchContext = null) : base(searchContext)
        {
        }
        
        public IconType Type { get; set; }
    
    }

    public enum IconType
    {
        Avatar,
        ArrowUp,
        ArrowDown
    }
}
