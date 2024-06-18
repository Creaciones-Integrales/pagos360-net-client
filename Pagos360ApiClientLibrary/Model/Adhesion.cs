using System.Text.Json;
using System.Text.Json.Serialization;
namespace Pagos360ApiClientLibrary.Model
{
    public class Adhesion
    {
        public Adhesion() { }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }

        [JsonPropertyName("state_comment")]
        public string? StateComment { get; set; }

        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        [JsonPropertyName("canceled_at")]
        public string? CanceledAt { get; set; }

        [JsonPropertyName("adhesion_holder_name")]
        public required string AdhesionHolderName { get; set; }

        [JsonPropertyName("bank")]
        public string? Bank { get; set; }

        [JsonPropertyName("cbu_holder_id_number")]
        public required long CbuHolderIdNumber { get; set; }

        [JsonPropertyName("cbu_holder_name")]
        public required string CbuHolderName { get; set; }

        [JsonPropertyName("cbu_number")]
        public required string CbuNumber { get; set; }

        [JsonPropertyName("description")]
        public required string Description { get; set; }

        [JsonPropertyName("short_description")]
        public required string ShortDescription { get; set; }

        [JsonPropertyName("email")]
        public required string Email { get; set; }

        [JsonPropertyName("external_reference")]
        public required string ExternalReference { get; set; }

        [JsonPropertyName("metadata")]
        public JsonElement? Metadata { get; set; }
    }
}
