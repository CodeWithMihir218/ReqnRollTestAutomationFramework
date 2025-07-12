using RestSharp;
using TestAutomationFramework.Core.Models.Users;

namespace TestAutomationFramework.Core.Services
{
    public class UserApiService
    {
        private readonly RestClient _client;

        public UserApiService(string baseUrl, string token)
        {
            _client = new RestClient(baseUrl);
            _client.AddDefaultHeader("Authorization", $"Bearer {token}");
        }

        public async Task<List<UserResponse>> GetAllUsersAsync()
        {
            var request = new RestRequest("/users", Method.Get);
            var response = await _client.ExecuteAsync<List<UserResponse>>(request);
            return response.Data;
        }

        public async Task<UserResponse> CreateUserAsync(UserRequest request)
        {
            var req = new RestRequest("/users", Method.Post).AddJsonBody(request);
            var response = await _client.ExecuteAsync<UserResponse>(req);
            return response.Data;
        }
    }
}
