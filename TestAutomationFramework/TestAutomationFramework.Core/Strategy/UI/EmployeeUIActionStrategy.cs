using OpenQA.Selenium;
using TestAutomationFramework.Core.Pages;
using TestAutomationFramework.Core.Strategy.Interfaces;

namespace TestAutomationFramework.Core.Strategy.UI
{
    public class EmployeeUIActionStrategy : IEmployeeActionStrategy
    {
        private readonly PIMPage _pimPage;

        public EmployeeUIActionStrategy(IWebDriver driver)
        {
            _pimPage = new PIMPage(driver);
        }

        public void AddEmployee(int employeeId, string firstName, string lastName, string department, DateTime joinedDate)
        {
            _pimPage.NavigateToPIM();
            _pimPage.AddEmployee(firstName, lastName); // Only supports first/last name in UI
        }
    }
}
