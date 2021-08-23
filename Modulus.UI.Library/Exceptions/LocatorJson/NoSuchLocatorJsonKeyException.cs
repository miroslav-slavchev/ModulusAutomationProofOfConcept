using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.QA.UI.Library.Exceptions.LocatorJson
{
    public class NoSuchLocatorJsonKeyException : Exception
    {
        public NoSuchLocatorJsonKeyException(string message) : base(message)
        {
        }
    }
}
