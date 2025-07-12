using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestAutomationFramework.Core.Drivers
{
    public class ChromeDriverFactory : IDriverFactory
    {
        public IWebDriver CreateDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            return new ChromeDriver(options);
        }
    }
}
