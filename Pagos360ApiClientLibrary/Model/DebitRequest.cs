using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pagos360ApiClientLibrary.Model
{
    public class DebitRequest
    {
        public DebitRequest() { }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }

        [JsonPropertyName("state_comment")]
        public string? StateComment { get; set; }

        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        [JsonPropertyName("first_due_date")]
        public required string FirstDueDate { get; set; }

        [JsonPropertyName("first_total")]
        public required float FirstTotal { get; set; }

        [JsonPropertyName("second_due_date")]
        public string? SecondDueDate { get; set; }

        [JsonPropertyName("second_total")]
        public float? SecondTotal { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("adhesion")]
        public Adhesion? Adhesion { get; set; }

        [JsonPropertyName("adhesion_id")]
        public int? AdhesionId { get; set; }

        [JsonPropertyName("request_result")]
        public List<RequestResult>? RequestResult { get; set; }

        [JsonPropertyName("metadata")]
        public JsonElement? Metadata { get; set; }
    }
}
