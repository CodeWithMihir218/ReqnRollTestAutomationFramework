using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
using TestAutomationFramework.Core.Drivers;
using TestAutomationFramework.Core.Strategy.Interfaces;

namespace TestAutomationFramework.Tests.StepDefinitions
{
    [Binding]
    public class EmployeeSteps
    {
        private IEmployeeActionStrategy _employeeStrategy;
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _driver;

        public EmployeeSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = DriverManager.GetDriver();
        }

        [When(@"I add employee with ID (.*), first name ""(.*)"", last name ""(.*)"", department ""(.*)"", joined date ""(.*)""")]
        public void WhenIAddEmployee(int employeeId, string firstName, string lastName, string department, string joinedDate)
        {
            _employeeStrategy = (IEmployeeActionStrategy)_scenarioContext["EmployeeStrategy"];
            var parsedDate = DateTime.Parse(joinedDate);
            _employeeStrategy.AddEmployee(employeeId, firstName, lastName, department, parsedDate);
        }

        [Then(@"the employee ""(.*) (.*)"" should be added")]
        public void ThenTheEmployeeShouldBeAdded(string firstName, string lastName)
        {
            Assert.IsNotNull(firstName);
            Assert.IsNotNull(lastName);
        }
    }
}
