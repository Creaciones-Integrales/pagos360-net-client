using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pagos360ApiClientLibrary.Model
{
    public class HolderData
    {
        [JsonPropertyName("holder_name")]
        public string? HolderName { get; set; }

        [JsonPropertyName("holder_email")]
        public string? HolderEmail { get; set; }

        [JsonPropertyName("holder_id_number")]
        public string? HolderIdNumber { get; set; }

        [JsonPropertyName("holder_phone_number")]
        public string? HolderPhoneNumber { get; set; }
    }
}
