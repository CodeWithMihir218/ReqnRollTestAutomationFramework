using TestAutomationFramework.Core.Models.Users;

namespace TestAutomationFramework.Core.Builder
{
    public class UserBuilder
    {
        private readonly UserRequest _user = new();

        public UserBuilder WithUsername(string username) { _user.Username = username; return this; }
        public UserBuilder WithRole(string role) { _user.Role = role; return this; }

        public UserRequest Build() => _user;
    }
}
