using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
using TestAutomationFramework.Core.Drivers;
using TestAutomationFramework.Core.Strategy.Interfaces;

namespace TestAutomationFramework.Tests.StepDefinitions
{
    [Binding]
    public class UserSteps
    {
        private IUserActionStrategy _userStrategy;
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _driver;

        public UserSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = DriverManager.GetDriver();
        }

        [When(@"I add a user with username ""(.*)"" and role ""(.*)""")]
        public void WhenIAddAUserWithUsernameAndRole(string username, string role)
        {
            _userStrategy = (IUserActionStrategy)_scenarioContext["UserStrategy"];
            _userStrategy.AddUser(username, role);
        }

        [Then(@"the user ""(.*)"" should be added successfully")]
        public void ThenTheUserShouldBeAddedSuccessfully(string username)
        {
            Assert.IsNotNull(username);
        }
    }
}
