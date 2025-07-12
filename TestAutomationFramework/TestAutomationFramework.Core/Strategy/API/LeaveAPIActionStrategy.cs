using TestAutomationFramework.Core.Builder;
using TestAutomationFramework.Core.Services;
using TestAutomationFramework.Core.Strategy.Interfaces;
using TestAutomationFramework.Core.Utilities;

namespace TestAutomationFramework.Core.Strategy.API
{
    public class LeaveAPIActionStrategy : ILeaveActionStrategy
    {
        private readonly LeaveApiService _leaveService;

        public LeaveAPIActionStrategy()
        {
            string baseUrl = ConfigManager.GetBaseUrl();
            string token = AuthTokenProvider.GetToken();
            _leaveService = new LeaveApiService(baseUrl, token);
        }

        public void ApplyLeave(string leaveType, string fromDate, string toDate, string reason, int employeeId)
        {
            var leave = new LeaveBuilder()
                .WithType(leaveType)
                .From(fromDate)
                .To(toDate)
                .WithReason(reason)
                .ForEmployee(employeeId)
                .WithStatus("Pending")
                .Build();

            _leaveService.ApplyLeaveAsync(leave).Wait();
        }
    }
}
