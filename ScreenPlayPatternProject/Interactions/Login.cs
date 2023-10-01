using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using ScreenPlayPatternProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlayPatternProject.Interactions
{
    public class Login:ITask
    {
        public string Username { get; }
        public string Password { get; }

        private Login(string userName, string password)
        {
            Username = userName;
            Password = password;
        }

        public static Login WithUser(string userName, string password) =>
            new Login(userName, password);

        public void PerformAs(IActor actor)
        {
            actor.AttemptsTo(SendKeys.To(LoginPage.UserNameInput, Username));
            actor.AttemptsTo(SendKeys.To(LoginPage.PasswordInput, Password));
            actor.AttemptsTo(Click.On(LoginPage.LoginButton));
        }
    }
}
