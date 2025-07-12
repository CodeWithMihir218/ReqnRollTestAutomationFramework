namespace TestAutomationFramework.Core.Strategy.Interfaces
{
    public interface ILeaveActionStrategy
    {
        void ApplyLeave(string leaveType, string fromDate, string toDate, string reason, int employeeId);
    }
}
