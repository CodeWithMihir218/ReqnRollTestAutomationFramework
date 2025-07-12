using System.Text.Json.Serialization;

namespace TestAutomationFramework.Core.Models.Auth
{
    public class AuthResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
