using OpenQA.Selenium;

namespace TestAutomationFramework.Core.Pages
{
    public class LeaveHistoryPage : BasePage
    {
        private By LeaveTab => By.XPath("//span[text()='Leave']");
        private By MyLeaveListTab => By.XPath("//a[text()='My Leave']");

        public LeaveHistoryPage(IWebDriver driver) : base(driver) { }

        public void NavigateToLeaveHistory()
        {
            Click(LeaveTab);
            Click(MyLeaveListTab);
        }
    }
}
