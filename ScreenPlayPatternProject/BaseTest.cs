using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlayPatternProject
{
    public class BaseTest
    {
        public IActor Actor { get; set; }

        [SetUp]
        public void InitiateScreenPlay()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            options.AddArgument("window-size=1920,1080");
            options.AddArgument("start-maximized");
            ChromiumDriver driver = new ChromeDriver(options);

            Actor = new Actor(name: "Dimitar", logger: new ConsoleLogger());
            Actor.Can(BrowseTheWeb.With(driver));
        }



        [TearDown]
        public void QuitBrowser()
        {
            Actor.AttemptsTo(QuitWebDriver.ForBrowser());
        }
    }
}
