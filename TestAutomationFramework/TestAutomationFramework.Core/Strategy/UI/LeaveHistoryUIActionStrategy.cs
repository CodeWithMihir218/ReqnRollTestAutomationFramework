using OpenQA.Selenium;
using TestAutomationFramework.Core.Pages;
using TestAutomationFramework.Core.Strategy.Interfaces;

namespace TestAutomationFramework.Core.Strategy.UI
{
    public class LeaveHistoryUIActionStrategy : ILeaveHistoryActionStrategy
    {
        private readonly LeaveHistoryPage _historyPage;

        public LeaveHistoryUIActionStrategy(IWebDriver driver)
        {
            _historyPage = new LeaveHistoryPage(driver);
        }

        public void ViewLeaveHistory()
        {
            _historyPage.NavigateToLeaveHistory();
        }
    }

}
