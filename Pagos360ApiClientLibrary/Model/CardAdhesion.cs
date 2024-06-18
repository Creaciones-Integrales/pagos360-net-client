using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pagos360ApiClientLibrary.Model
{
    public class CardAdhesion
    {
        public CardAdhesion() { }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("external_reference")]
        public required string ExternalReference { get; set; }

        [JsonPropertyName("adhesion_holder_name")]
        public required string AdhesionHolderName { get; set; }

        [JsonPropertyName("email")]
        public required string Email { get; set; }

        [JsonPropertyName("card_holder_name")]
        public required string CardHolderName { get; set; }

        [JsonPropertyName("card_number")]
        public required string CardNumber { get; set; }

        [JsonPropertyName("description")]
        public required string Description { get; set; }

        [JsonPropertyName("last_four_digits")]
        public string? LastFourDigits { get; set; }

        [JsonPropertyName("card")]
        public string? CardBrand { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }

        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        [JsonPropertyName("state_comment")]
        public string? StateComment { get; set; }

        [JsonPropertyName("canceled_at")]
        public string? CanceledAt { get; set; }

        [JsonPropertyName("metadata")]
        public JsonElement? Metadata { get; set; }
    }
}
