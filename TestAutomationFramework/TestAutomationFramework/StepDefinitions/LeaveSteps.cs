using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
using TestAutomationFramework.Core.Drivers;
using TestAutomationFramework.Core.Pages;
using TestAutomationFramework.Core.Strategy.Interfaces;
using TestAutomationFramework.Core.Strategy.UI;
using TestAutomationFramework.Core.Utilities;

namespace TestAutomationFramework.Tests.StepDefinitions
{
    [Binding]
    public class LeaveSteps
    {
        private ILeaveActionStrategy _leaveStrategy;
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _driver;

        public LeaveSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = DriverManager.GetDriver();
        }

        [When(@"I navigate to the leave application page")]
        public void WhenINavigateToTheLeaveApplicationPage()
        {
            if (_scenarioContext.TryGetValue("LeaveStrategy", out var strategyObj) && strategyObj is LeaveUIActionStrategy)
            {
                var leavePage = new LeavePage(_driver);
                leavePage.NavigateToLeave();
            }
        }

        [When(@"I apply for leave of type ""(.*)"" from ""(.*)"" to ""(.*)"" with reason ""(.*)"" for employee ID (.*)")]
        public void WhenIApplyForLeave(string type, string from, string to, string reason, int employeeId)
        {
            var strategy = (ILeaveActionStrategy)_scenarioContext["LeaveStrategy"];
            strategy.ApplyLeave(type, from, to, reason, employeeId);
        }

        [Then(@"the leave should be submitted with status ""(.*)""")]
        public void ThenTheLeaveShouldBeSubmittedWithStatus(string expectedStatus)
        {
            Assert.AreEqual("Pending", expectedStatus); 
        }
    }
}
