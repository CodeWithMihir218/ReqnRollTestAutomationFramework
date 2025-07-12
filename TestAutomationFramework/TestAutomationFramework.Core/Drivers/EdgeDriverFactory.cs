using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace TestAutomationFramework.Core.Drivers
{
    public class EdgeDriverFactory : IDriverFactory
    {
        public IWebDriver CreateDriver()
        {
            var options = new EdgeOptions();
            options.AddArgument("start-maximized");
            return new EdgeDriver(options);
        }
    }
}
