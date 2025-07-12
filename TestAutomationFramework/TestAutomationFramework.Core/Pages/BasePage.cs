using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestAutomationFramework.Core.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;
        private WebDriverWait _wait;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        protected IWebElement Find(By by)
        {
            return _wait.Until(ExpectedConditions.ElementExists(by));
        }

        protected void Click(By by)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(by)).Click();
        }

        protected void EnterText(By by, string text)
        {
            var element = _wait.Until(ExpectedConditions.ElementIsVisible(by));
            element.Clear();
            element.SendKeys(text);
        }

        protected void WaitUntilVisible(By by)
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        protected void WaitUntilClickable(By by)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        protected bool IsElementDisplayed(By by)
        {
            try
            {
                return Find(by).Displayed;
            }
            catch
            {
                return false;
            }
        }
    }
}
