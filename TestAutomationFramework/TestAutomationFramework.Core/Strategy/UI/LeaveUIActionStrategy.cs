using OpenQA.Selenium;
using TestAutomationFramework.Core.Pages;
using TestAutomationFramework.Core.Strategy.Interfaces;

namespace TestAutomationFramework.Core.Strategy.UI
{
    public class LeaveUIActionStrategy : ILeaveActionStrategy
    {
        private readonly LeavePage _leavePage;

        public LeaveUIActionStrategy(IWebDriver driver)
        {
            _leavePage = new LeavePage(driver);
        }

        public void ApplyLeave(string leaveType, string fromDate, string toDate, string reason, int employeeId)
        {
            _leavePage.NavigateToLeave();
            _leavePage.ApplyLeave(leaveType, fromDate, toDate, reason);
        }
    }
}
