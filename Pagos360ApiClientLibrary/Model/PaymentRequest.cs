using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Pagos360ApiClientLibrary.Model
{
    public class PaymentRequest
    {
        public PaymentRequest() { }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }

        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        [JsonPropertyName("payer_name")]
        public required string PayerName { get; set; }

        [JsonPropertyName("payer_email")]
        public string? PayerEmail { get; set; }

        [JsonPropertyName("description")]
        public required string Description { get; set; }

        [JsonPropertyName("external_reference")]
        public string? ExternalReference { get; set; }

        [JsonPropertyName("first_due_date")]
        public required string FirstDueDate { get; set; }

        [JsonPropertyName("first_total")]
        public required float FirstTotal { get; set; }

        [JsonPropertyName("barcode")]
        public string? Barcode { get; set; }

        [JsonPropertyName("checkout_url")]
        public string? CheckoutUrl { get; set; }

        [JsonPropertyName("barcode_url")]
        public string? BarcodeUrl { get; set; }

        [JsonPropertyName("pdf_url")]
        public string? PdfUrl { get; set; }

        [JsonPropertyName("back_url_success")]
        public string? BackUrlSuccess { get; set; }

        [JsonPropertyName("back_url_pending")]
        public string? BackUrlPending { get; set; }

        [JsonPropertyName("back_url_rejected")]
        public string? BackUrlRejected { get; set; }

        [JsonPropertyName("metadata")]
        public JsonElement? Metadata { get; set; }

        [JsonPropertyName("excluded_channels")]
        public string[]? ExcludedChannels { get; set; }

        [JsonPropertyName("excluded_card_brands")]
        public string[]? ExcludedCardBrands { get; set; }

        [JsonPropertyName("excluded_installments")]
        public int[]? ExcludedInstallments { get; set; }

        [JsonPropertyName("second_due_date")]
        public string? SecondDueDate { get; set; }

        [JsonPropertyName("second_total")]
        public float? SecondTotal { get; set; }

        [JsonPropertyName("request_result")]
        public List<RequestResult>? RequestResult { get; set; }

        [JsonPropertyName("items")]
        public List<object>? Items { get; set; }

        [JsonPropertyName("risk_insights")]
        public JsonElement? RiskInsights { get; set; }

        // Assuming TransferTo and HolderData are not required as they were not mentioned in the provided specifications.
        [JsonPropertyName("transfer_to")]
        public List<TransferTo>? TransferTo { get; set; }

        [JsonPropertyName("holder_data")]
        public HolderData? HolderData { get; set; }
    }
}
