using Modulus.QA.UI.Application.Phoenix.PageComponents;

namespace Modulus.QA.UI.Application.Phoenix.PageInteractions.LogIn
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
