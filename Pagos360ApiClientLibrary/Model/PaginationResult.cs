using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Pagos360ApiClientLibrary.Model
{
    public class PaginationResult<T>
    {
        [JsonPropertyName("current_page")]
        public int? CurrentPage { get; set; }

        [JsonPropertyName("items_per_page")]
        public int? ItemsPerPage { get; set; }

        [JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        [JsonPropertyName("data")]
        public List<T>? Data { get; set; }
    }
}
