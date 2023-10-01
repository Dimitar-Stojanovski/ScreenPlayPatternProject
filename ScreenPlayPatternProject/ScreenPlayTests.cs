using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using FluentAssertions;
using ScreenPlayPatternProject.Interactions;
using ScreenPlayPatternProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlayPatternProject
{
    public class ScreenPlayTests:BaseTest
    {
         

        [Test]
        public void PopulateTextBoxElementWithScreenPlay()
        {
            Actor.AttemptsTo(Navigate.ToUrl(TextBoxPage._textBoxUrl));

            Actor.AskingFor(ValueAttribute.Of(TextBoxPage.FullNameInput)).Should().BeEmpty();

            Actor.AttemptsTo(SendKeys.To(TextBoxPage.FullNameInput, "Dimitar Stojanovski"));

            Actor.AttemptsTo(SendKeys.To(TextBoxPage.EmailInput, "mail@mail.com"));

            Actor.AttemptsTo(SendKeys.To(TextBoxPage.CurrentAddressInput, "Address 1"));

            Actor.AttemptsTo(SendKeys.To(TextBoxPage.PermanentAddressInput, "Address 2"));

            Actor.AttemptsTo(ScrollToElement.At(TextBoxPage.SubmitButton));

            Actor.AttemptsTo(Click.On(TextBoxPage.SubmitButton));

            Thread.Sleep(3000);
        }

        [Test]
        public void ScreenPlayTestWithInteractions()
        {
            Actor.AttemptsTo(Navigate.ToUrl(LoginPage.URL));

            Actor.AttemptsTo(Login.WithUser("dimitar", "password"));

            Actor.AttemptsTo(Wait.Until(Appearance.Of(LoginPage.Message),IsEqualTo.True()));

            Actor.AskingFor(Text.Of(LoginPage.Message)).Should().Be("Invalid username or password!");
        }
    }
}
