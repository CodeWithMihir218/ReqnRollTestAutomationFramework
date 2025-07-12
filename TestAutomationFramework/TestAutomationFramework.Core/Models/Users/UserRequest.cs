using System.Text.Json.Serialization;

namespace TestAutomationFramework.Core.Models.Users
{
    public class UserRequest
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }
    }
}