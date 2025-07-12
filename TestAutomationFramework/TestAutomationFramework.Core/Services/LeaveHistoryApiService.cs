using RestSharp;
using TestAutomationFramework.Core.Models.LeaveHistory;

namespace TestAutomationFramework.Core.Services
{
    public class LeaveHistoryApiService
    {
        private readonly RestClient _client;

        public LeaveHistoryApiService(string baseUrl, string token)
        {
            _client = new RestClient(baseUrl);
            _client.AddDefaultHeader("Authorization", $"Bearer {token}");
        }

        public async Task<LeaveHistoryResponse> AddHistoryAsync(LeaveHistoryRequest request)
        {
            var req = new RestRequest("/leaveHistory", Method.Post).AddJsonBody(request);
            var response = await _client.ExecuteAsync<LeaveHistoryResponse>(req);
            return response.Data;
        }

        public async Task<List<LeaveHistoryResponse>> GetLeaveHistoryAsync()
        {
            var req = new RestRequest("/leaveHistory", Method.Get);
            var response = await _client.ExecuteAsync<List<LeaveHistoryResponse>>(req);
            return response.Data;
        }
    }
}
