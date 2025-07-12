using TestAutomationFramework.Core.Builder;
using TestAutomationFramework.Core.Services;
using TestAutomationFramework.Core.Strategy.Interfaces;
using TestAutomationFramework.Core.Utilities;

namespace TestAutomationFramework.Core.Strategy.API
{
    public class EmployeeAPIActionStrategy : IEmployeeActionStrategy
    {
        private readonly EmployeeApiService _employeeService;

        public EmployeeAPIActionStrategy()
        {
            string baseUrl = ConfigManager.GetBaseUrl();
            string token = AuthTokenProvider.GetToken(); // Assuming this method returns token from login

            _employeeService = new EmployeeApiService(baseUrl, token);
        }

        public void AddEmployee(int employeeId, string firstName, string lastName, string department, DateTime joinedDate)
        {
            var employee = new EmployeeBuilder()
                .WithEmployeeId(employeeId)
                .WithFirstName(firstName)
                .WithLastName(lastName)
                .WithDepartment(department)
                .WithJoinedDate(joinedDate)
                .Build();

            _employeeService.AddEmployeeAsync(employee).Wait();
        }
    }

}
