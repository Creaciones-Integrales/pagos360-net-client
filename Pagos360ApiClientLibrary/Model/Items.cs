using System.Text.Json.Serialization;

namespace Pagos360ApiClientLibrary.Model
{
    public class Items
    {

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("description")]
        public required string Description { get; set; }

        [JsonPropertyName("amount")]
        public required float Amount { get; set; }
    }
}
