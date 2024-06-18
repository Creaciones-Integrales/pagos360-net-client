using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pagos360ApiClientLibrary.Model
{
    public class RequestResult
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("channel")]
        public string? Channel { get; set; }

        [JsonPropertyName("paid_at")]
        public DateTime? PaidAt { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("available_at")]
        public DateTime? AvailableAt { get; set; }

        [JsonPropertyName("rejected_at")]
        public DateTime? RejectedAt { get; set; }

        [JsonPropertyName("is_available")]
        public bool? IsAvailable { get; set; }

        [JsonPropertyName("amount")]
        public float? Amount { get; set; }

        [JsonPropertyName("gross_fee")]
        public float? GrossFee { get; set; }

        [JsonPropertyName("net_fee")]
        public float? NetFee { get; set; }

        [JsonPropertyName("fee_iva")]
        public float? FeeIva { get; set; }

        [JsonPropertyName("net_amount")]
        public float? NetAmount { get; set; }

        [JsonPropertyName("state_comment")]
        public string? StateComment { get; set; }

        [JsonPropertyName("retentions")]
        public List<object>? Retentions { get; set; }
    }
}
