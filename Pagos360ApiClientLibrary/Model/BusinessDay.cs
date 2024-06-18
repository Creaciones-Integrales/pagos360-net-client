using System.Text.Json;
using System.Text.Json.Serialization;
namespace Pagos360ApiClientLibrary.Model
{
    public class BusinessDay
    {
        public BusinessDay() { }

        [JsonPropertyName("date")]
        public required string Date { get; set; }

        [JsonPropertyName("days")]
        public required int Days { get; set; }
    }
}
