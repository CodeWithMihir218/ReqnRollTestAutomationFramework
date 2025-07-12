using System.Text.Json.Serialization;

namespace TestAutomationFramework.Core.Models.LeaveHistory
{
    public class LeaveHistoryResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("employeeId")]
        public int EmployeeId { get; set; }

        [JsonPropertyName("leaveType")]
        public string LeaveType { get; set; }

        [JsonPropertyName("fromDate")]
        public string FromDate { get; set; }

        [JsonPropertyName("toDate")]
        public string ToDate { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("approvedBy")]
        public string ApprovedBy { get; set; }
    }
}
