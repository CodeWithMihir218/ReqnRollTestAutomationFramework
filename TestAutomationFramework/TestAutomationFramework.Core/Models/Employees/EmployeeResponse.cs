using System.Text.Json.Serialization;

namespace TestAutomationFramework.Core.Models.Employees
{
    public class EmployeeResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("employeeId")]
        public int EmployeeId { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("department")]
        public string Department { get; set; }

        [JsonPropertyName("joinedDate")]
        public DateTime JoinedDate { get; set; }
    }
}
