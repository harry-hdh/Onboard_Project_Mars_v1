using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProjectMars.Drivers;
using SpecFlowProjectMars.Pages;
using TechTalk.SpecFlow;

namespace Testing_Project_Mars_SpecFlow.Hooks
{
    [Binding]
    public sealed class Hook : CommonDriver
    {
        SignIn SignInObj = new SignIn();

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("http://localhost:5000/Home");
            _driver.Manage().Window.Maximize();

            SignInObj.Login(_driver, "testing111@gmail.com", "123qweasd");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (_driver != null) { _driver.Quit(); }
        }
    }
}