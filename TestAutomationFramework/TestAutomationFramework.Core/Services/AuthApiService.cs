using RestSharp;
using TestAutomationFramework.Core.Models.Auth;

namespace TestAutomationFramework.Core.Services
{
    public class AuthApiService
    {
        private readonly RestClient _client;

        public AuthApiService(string baseUrl)
        {
            _client = new RestClient(baseUrl);
        }

        public async Task<AuthResponse> LoginAsync(AuthRequest request)
        {
            var restRequest = new RestRequest("/auth", Method.Post);
            restRequest.AddJsonBody(request);
            var response = await _client.ExecuteAsync<AuthResponse>(restRequest);
            return response.Data;
        }
    }
}
