using OpenQA.Selenium;
using static Boa.Constrictor.Selenium.WebLocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boa.Constrictor.Selenium;

namespace ScreenPlayPatternProject.Pages
{
    public static class LoginPage
    {
        public const string URL = "https://demoqa.com/login";

        static By _userNameInput =By.Id("userName");
        static By _passwordInput = By.Id("password");
        static By _loginButton = By.Id("login");
        static By _message = By.XPath("//p[@id='name' and contains(text(),'Invalid')]");

        public static IWebLocator UserNameInput => L("User Name Input", _userNameInput);

        public static IWebLocator PasswordInput => L("Password input", _passwordInput);

        public static IWebLocator LoginButton => L("LoginButton", _loginButton);

        public static IWebLocator Message => L("Success or failed message", _message);
    }
}
