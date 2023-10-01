using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using static Boa.Constrictor.Selenium.WebLocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlayPatternProject.Pages
{
    public static class TextBoxPage
    {
        public const string _textBoxUrl = "https://demoqa.com/text-box";

        static By userNameInput = By.Id("userName");
        static By userEmail = By.Id("userEmail");
        static By currentAdddress = By.Id("currentAddress");
        static By permanentAddress = By.Id("permanentAddress");
        static By submitButton = By.Id("submit");

        public static IWebLocator FullNameInput => L("Text box in Elements Input", userNameInput);

        public static IWebLocator EmailInput => L( "Email to input", userEmail);

        public static IWebLocator CurrentAddressInput => L("Current Address", currentAdddress);

        public static IWebLocator PermanentAddressInput => L( "Permanent Address", permanentAddress);

        public static IWebLocator SubmitButton => L( "Submit button", submitButton);
    }
}
