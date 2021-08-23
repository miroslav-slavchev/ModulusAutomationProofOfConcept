using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.QA.UI.Library.Exceptions.LocatorJson
{
    public class NoLocatorKeyException : Exception
    {
        public NoLocatorKeyException(string message) : base(message)
        {
        }
    }
}
