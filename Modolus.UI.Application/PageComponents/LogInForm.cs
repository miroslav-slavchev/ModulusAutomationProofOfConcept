using Modulus.UI.Library.PageComponents.Generic;
using Modulus.UI.Library.PageComponents.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus.UI.Library.Application.PageComponents
{
    public class LogInForm : PageObject
    {
        public LogInForm(string name = null, Container searchContext = null) : base(name, searchContext)
        {
        }

        public TextInput EmailAddress => _searchContext.FindTextInput(nameof(EmailAddress));

        public TextInput Password => _searchContext.FindTextInput(nameof(Password));

        public Button SignIn => _searchContext.FindButton(nameof(SignIn));
    }
}
