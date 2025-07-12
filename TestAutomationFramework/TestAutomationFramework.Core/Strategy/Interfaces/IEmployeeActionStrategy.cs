namespace TestAutomationFramework.Core.Strategy.Interfaces
{
    public interface IEmployeeActionStrategy
    {
        void AddEmployee(int employeeId, string firstName, string lastName, string department, DateTime joinedDate);
    }
}
