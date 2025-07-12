using OpenQA.Selenium;

namespace TestAutomationFramework.Core.Drivers
{
    public interface IDriverFactory
    {
        IWebDriver CreateDriver();
    }
}
