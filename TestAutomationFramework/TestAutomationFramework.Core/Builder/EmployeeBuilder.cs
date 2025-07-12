using TestAutomationFramework.Core.Models.Employees;

namespace TestAutomationFramework.Core.Builder
{
    public class EmployeeBuilder
    {
        private readonly EmployeeRequest _employee = new();

        public EmployeeBuilder WithEmployeeId(int id) { _employee.EmployeeId = id; return this; }
        public EmployeeBuilder WithFirstName(string firstName) { _employee.FirstName = firstName; return this; }
        public EmployeeBuilder WithLastName(string lastName) { _employee.LastName = lastName; return this; }
        public EmployeeBuilder WithDepartment(string department) { _employee.Department = department; return this; }
        public EmployeeBuilder WithJoinedDate(DateTime date) { _employee.JoinedDate = date; return this; }

        public EmployeeRequest Build() => _employee;
    }
}
