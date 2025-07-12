using TestAutomationFramework.Core.Builder;
using TestAutomationFramework.Core.Services;
using TestAutomationFramework.Core.Strategy.Interfaces;
using TestAutomationFramework.Core.Utilities;

namespace TestAutomationFramework.Core.Strategy.API
{
    public class UserAPIActionStrategy : IUserActionStrategy
    {
        private readonly UserApiService _userService;

        public UserAPIActionStrategy()
        {
            string baseUrl = ConfigManager.GetBaseUrl();
            string token = AuthTokenProvider.GetToken();
            _userService = new UserApiService(baseUrl, token);
        }

        public void AddUser(string username, string role)
        {
            var user = new UserBuilder()
                .WithUsername(username)
                .WithRole(role)
                .Build();

            _userService.CreateUserAsync(user).Wait();
        }
    }
}
