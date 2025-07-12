using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestAutomationFramework.Core.Pages
{
    public class EmployeePage : BasePage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        public EmployeePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private By PIMMenu => By.XPath("//span[text()='PIM']");
        private By EmployeeNameField => By.XPath("//label[text()='Employee Name']/following::input[1]");
        private By SearchButton => By.XPath("//button[@type='submit']");
        private By ResultTable => By.CssSelector(".oxd-table-body");

        public void NavigateToPIM()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(PIMMenu)).Click();
        }

        public void SearchEmployee(string employeeName)
        {
            var nameField = _wait.Until(ExpectedConditions.ElementIsVisible(EmployeeNameField));
            nameField.Clear();
            nameField.SendKeys(employeeName);

            _wait.Until(ExpectedConditions.ElementToBeClickable(SearchButton)).Click();
        }

        public bool IsEmployeeListed()
        {
            try
            {
                return _wait.Until(ExpectedConditions.ElementIsVisible(ResultTable)).Displayed;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
    }
}
