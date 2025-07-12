using OpenQA.Selenium;
using Reqnroll;
using TestAutomationFramework.Core.Drivers;
using TestAutomationFramework.Core.Enums;
using TestAutomationFramework.Core.Pages;

namespace TestAutomationFramework.Tests.StepDefinitions
{
    [Binding]
    public class CommonSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _driver;

        public CommonSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = DriverManager.GetDriver();
        }

        [Given(@"I choose to run ""(.*)"" for ""(.*)""")]
        public void GivenIChooseToRunFor(string mode, string strategyType)
        {
            var executionMode = Enum.Parse<ExecutionMode>(mode, ignoreCase: true);
            var strategy = StrategyResolver.ResolveStrategy(
                Enum.Parse<StrategyType>(strategyType, ignoreCase: true),
                executionMode,
                _driver);

            _scenarioContext[strategyType + "Strategy"] = strategy;
        }

        [Given(@"I am logged into the application as ""(.*)"" using password ""(.*)""")]
        public void GivenIAmLoggedIntoApplication(string username, string password)
        {
            var loginPage = new LoginPage(_driver);
            loginPage.NavigateToLoginPage();
            loginPage.Login(username, password);
            new DashboardPage(_driver).IsDashBoardPageDisplayed();
        }
    }
}
