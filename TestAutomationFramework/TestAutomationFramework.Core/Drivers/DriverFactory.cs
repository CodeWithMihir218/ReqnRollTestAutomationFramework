namespace TestAutomationFramework.Core.Drivers
{
    public static class DriverFactory
    {
        public static IDriverFactory GetFactory(string browserName)
        {
            return browserName.ToLower() switch
            {
                "chrome" => new ChromeDriverFactory(),
                "edge" => new EdgeDriverFactory(),
                _ => throw new ArgumentException("Unsupported browser")
            };
        }
    }

}
