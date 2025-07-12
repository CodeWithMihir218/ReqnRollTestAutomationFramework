using RestSharp;
using TestAutomationFramework.Core.Models.Leave;

namespace TestAutomationFramework.Core.Services
{
    public class LeaveApiService
    {
        private readonly RestClient _client;

        public LeaveApiService(string baseUrl, string token)
        {
            _client = new RestClient(baseUrl);
            _client.AddDefaultHeader("Authorization", $"Bearer {token}");
        }

        public async Task<LeaveResponse> ApplyLeaveAsync(LeaveRequest request)
        {
            var req = new RestRequest("/leave", Method.Post).AddJsonBody(request);
            var response = await _client.ExecuteAsync<LeaveResponse>(req);
            return response.Data;
        }

        public async Task<List<LeaveResponse>> GetLeavesAsync()
        {
            var req = new RestRequest("/leave", Method.Get);
            var response = await _client.ExecuteAsync<List<LeaveResponse>>(req);
            return response.Data;
        }
    }
}
