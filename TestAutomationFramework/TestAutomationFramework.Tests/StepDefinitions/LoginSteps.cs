using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
using TestAutomationFramework.Core.Drivers;
using TestAutomationFramework.Core.Pages;
using TestAutomationFramework.Core.Utilities;

namespace TestAutomationFramework.Tests.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;

        public LoginSteps()
        {
            _driver = DriverManager.GetDriver();
        }

        [Given(@"I navigate to OrangeHRM login page")]
        [When(@"I navigate to OrangeHRM login page")]
        public void GivenINavigateToLoginPage()
        {
            var loginPage = new LoginPage(_driver);
            loginPage.NavigateToLoginPage();
        }

        [When(@"I login with username ""(.*)"" and password ""(.*)""")]
        [Given(@"I login with username ""(.*)"" and password ""(.*)""")]
        public void WhenILoginWithCredentials(string username, string password)
        {
            var loginPage = new LoginPage(_driver);
            loginPage.Login(username, password);
        }

        [Then(@"I should be redirected to the dashboard")]
        public void ThenIShouldSeeDashboard()
        {
            var dashBoardPage = new DashboardPage(_driver);
            Assert.IsTrue(dashBoardPage.IsDashBoardPageDisplayed(), "Dashboard is not displayed");
        }
    }

}
