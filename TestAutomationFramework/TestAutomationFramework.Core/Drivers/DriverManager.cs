using OpenQA.Selenium;
using TestAutomationFramework.Core.Utilities;

namespace TestAutomationFramework.Core.Drivers
{
    public static class DriverManager
    {
        private static ThreadLocal<IWebDriver> _driver = new();

        public static IWebDriver GetDriver()
        {
            if (!_driver.IsValueCreated || _driver.Value == null)
            {
                var browser = ConfigManager.GetBrowser();
                var factory = DriverFactory.GetFactory(browser);
                _driver.Value = factory.CreateDriver();
            }

            return _driver.Value;
        }

        public static void QuitDriver()
        {
            if (_driver.IsValueCreated)
            {
                _driver.Value.Quit();
                _driver.Dispose();
            }
        }

        public static string CaptureScreenshot(string scenarioTitle)
        {
            var screenshot = ((ITakesScreenshot)GetDriver()).GetScreenshot();
            var fileName = $"{scenarioTitle}_{DateTime.Now:HHmmss}.png".Replace(" ", "_").Replace(":", "_");
            var dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Screenshots");
            Directory.CreateDirectory(dir);
            var path = Path.Combine(dir, fileName);
            screenshot.SaveAsFile(path);
            return path;
        }
    }

}
