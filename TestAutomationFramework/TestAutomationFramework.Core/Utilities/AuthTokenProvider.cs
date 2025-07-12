using TestAutomationFramework.Core.Models.Auth;
using TestAutomationFramework.Core.Services;

namespace TestAutomationFramework.Core.Utilities
{
    public static class AuthTokenProvider
    {
        private static string _token;
        private static readonly object _lock = new();

        public static string GetToken()
        {
            if (!string.IsNullOrEmpty(_token))
                return _token;

            lock (_lock)
            {
                if (!string.IsNullOrEmpty(_token))
                    return _token;

                string baseUrl = ConfigManager.GetBaseUrl();

                var authService = new AuthApiService(baseUrl);
                var request = new AuthRequest
                {
                    Username = ConfigManager.GetUsername(),
                    Password = ConfigManager.GetPassword()
                };

                var response = authService.LoginAsync(request).GetAwaiter().GetResult();
                _token = response?.Token;
            }

            return _token;
        }
    }
}
