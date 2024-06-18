using System.Text.Json.Serialization;

namespace Pagos360ApiClientLibrary.Model
{
    public class Webhook
    {
        [JsonPropertyName("entity_name")]
        public string? EntityName { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("entity_id")]
        public int? EntityId { get; set; }

        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        [JsonPropertyName("payload")]
        public object? Payload { get; set; }
    }
}
