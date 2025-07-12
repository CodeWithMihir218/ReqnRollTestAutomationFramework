using RestSharp;
using TestAutomationFramework.Core.Models.Employees;

namespace TestAutomationFramework.Core.Services
{
    public class EmployeeApiService
    {
        private readonly RestClient _client;

        public EmployeeApiService(string baseUrl, string token)
        {
            _client = new RestClient(baseUrl);
            _client.AddDefaultHeader("Authorization", $"Bearer {token}");
        }

        public async Task<EmployeeResponse> AddEmployeeAsync(EmployeeRequest request)
        {
            var req = new RestRequest("/employees", Method.Post).AddJsonBody(request);
            var response = await _client.ExecuteAsync<EmployeeResponse>(req);
            return response.Data;
        }

        public async Task<List<EmployeeResponse>> GetEmployeesAsync()
        {
            var request = new RestRequest("/employees", Method.Get);
            var response = await _client.ExecuteAsync<List<EmployeeResponse>>(request);
            return response.Data;
        }
    }
}
