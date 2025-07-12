using System.Text.Json.Serialization;

namespace TestAutomationFramework.Core.Models.Leave
{
    public class LeaveResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("leaveType")]
        public string LeaveType { get; set; }

        [JsonPropertyName("fromDate")]
        public string FromDate { get; set; }

        [JsonPropertyName("toDate")]
        public string ToDate { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("employeeId")]
        public int EmployeeId { get; set; }
    }
}