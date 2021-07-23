using Modulus.UI.Library.Application.PageComponents;

namespace Modulus.UI.Library.Application.PageInteractions.LogIn
{
    public class LogInInteractions
    {
        private LogInForm LogInForm => new LogInForm();

        public void LogIn(string userName, string password)
        {
            LogInForm.EmailAddress.EnterText(userName);
            LogInForm.Password.EnterText(password);
            LogInForm.SignIn.Click();
        }


    }
}
