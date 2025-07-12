using System.Text.Json.Serialization;

namespace TestAutomationFramework.Core.Models.Auth
{
    public class AuthRequest
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
