using Microsoft.Extensions.Configuration;
namespace TestAutomationFramework.Core.Utilities
{
    public static class ConfigManager
    {
        private static readonly IConfigurationRoot _config;

        static ConfigManager()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        public static string GetBaseUrl() => _config["AppConfig:BaseUrl"];
        public static string GetOrangeHrmBaseUrl() => _config["AppConfig:OrangeHrmBaseUrl"];
        public static string GetBrowser() => _config["AppConfig:Browser"];
        public static string GetUsername() => _config["AppConfig:Credentials:Username"];
        public static string GetPassword() => _config["AppConfig:Credentials:Password"];
    }

}
