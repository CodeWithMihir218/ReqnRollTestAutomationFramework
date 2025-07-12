using TestAutomationFramework.Core.Models.Leave;

namespace TestAutomationFramework.Core.Builder
{
    public class LeaveBuilder
    {
        private readonly LeaveRequest _leave = new();

        public LeaveBuilder WithType(string type) { _leave.LeaveType = type; return this; }
        public LeaveBuilder From(string fromDate) { _leave.FromDate = fromDate; return this; }
        public LeaveBuilder To(string toDate) { _leave.ToDate = toDate; return this; }
        public LeaveBuilder WithReason(string reason) { _leave.Reason = reason; return this; }
        public LeaveBuilder ForEmployee(int id) { _leave.EmployeeId = id; return this; }
        public LeaveBuilder WithStatus(string status) { _leave.Status = status; return this; }

        public LeaveRequest Build() => _leave;
    }
}
