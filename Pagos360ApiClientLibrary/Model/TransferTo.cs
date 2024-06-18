using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pagos360ApiClientLibrary.Model
{
    public class TransferTo
    {
        public TransferTo() { }

        [JsonPropertyName("account_id")]
        public string? AccountId { get; set; }

        [JsonPropertyName("amount")]
        public double? Amount { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("external_reference")]
        public string? ExternalReference { get; set; }

        [JsonPropertyName("refundable")]
        public bool? Refundable { get; set; }
    }
}
