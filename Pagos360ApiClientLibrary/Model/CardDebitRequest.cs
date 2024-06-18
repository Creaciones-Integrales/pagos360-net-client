using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pagos360ApiClientLibrary.Model
{
    public class CardDebitRequest
    {
        public CardDebitRequest() { }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("amount")]
        public required float Amount { get; set; }

        [JsonPropertyName("card_adhesion_id")]
        public required int CardAdhesionId { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("month")]
        public required int Month { get; set; }

        [JsonPropertyName("year")]
        public required int Year { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }

        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        [JsonPropertyName("card_adhesion")]
        public CardAdhesion? CardAdhesionObject { get; set; }

        [JsonPropertyName("request_result")]
        public RequestResult? RequestResultObject { get; set; }

        [JsonPropertyName("rejected_at")]
        public string? RejectedAt { get; set; }

        [JsonPropertyName("state_comment")]
        public string? StateComment { get; set; }

        [JsonPropertyName("metadata")]
        public JsonElement? Metadata { get; set; }
    }
}
