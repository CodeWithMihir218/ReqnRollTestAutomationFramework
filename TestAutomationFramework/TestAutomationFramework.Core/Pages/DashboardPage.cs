using OpenQA.Selenium;

namespace TestAutomationFramework.Core.Pages
{
    public class DashboardPage : BasePage
    {
        private readonly IWebDriver _driver;

        public DashboardPage(IWebDriver driver) : base(driver) { }

        private By DashBoardHeader => By.XPath("//span//h6[text()='Dashboard']");

        public bool IsDashBoardPageDisplayed()
        {
            var isDashBoardDisplayed = IsElementDisplayed(DashBoardHeader);
            return isDashBoardDisplayed;
        }
    }
}
