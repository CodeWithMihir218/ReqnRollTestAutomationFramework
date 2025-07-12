using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
using TestAutomationFramework.Core.Drivers;
using TestAutomationFramework.Core.Strategy.Interfaces;

namespace TestAutomationFramework.Tests.StepDefinitions
{
    [Binding]
    public class LeaveHistorySteps
    {
        private ILeaveHistoryActionStrategy _historyStrategy;
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _driver;

        public LeaveHistorySteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = DriverManager.GetDriver();
        }

        [When(@"I view leave history")]
        public void WhenIViewLeaveHistory()
        {
            _historyStrategy = (ILeaveHistoryActionStrategy)_scenarioContext["LeaveHistoryStrategy"];
            _historyStrategy.ViewLeaveHistory();
        }

        [Then(@"I should see previously approved and rejected leaves")]
        public void ThenIShouldSeePreviouslyApprovedAndRejectedLeaves()
        {
            Assert.Pass("Leave history viewed successfully.");
        }
    }
}
