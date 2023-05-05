// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Reporting.Model
{
    public class RestapiReportResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalInfo")]
        public Dictionary<string, object>? AdditionalInfo { get; set; }

        [JsonPropertyName("category")]
        [JsonStringEnum]
        public RestapiReportResponseCategory? Category { get; set; }

        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        [JsonPropertyName("extensionCategory")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtensionCategory { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("objectId")]
        public string? ObjectId { get; set; }

        [JsonPropertyName("objectType")]
        public string? ObjectType { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("reporterId")]
        public string? ReporterId { get; set; }

        [JsonPropertyName("ticketId")]
        public string? TicketId { get; set; }

        [JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }

    public class RestapiReportResponse<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalInfo")]
        public T1? AdditionalInfo { get; set; }

        [JsonPropertyName("category")]
        [JsonStringEnum]
        public RestapiReportResponseCategory? Category { get; set; }

        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        [JsonPropertyName("extensionCategory")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtensionCategory { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("objectId")]
        public string? ObjectId { get; set; }

        [JsonPropertyName("objectType")]
        public string? ObjectType { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("reporterId")]
        public string? ReporterId { get; set; }

        [JsonPropertyName("ticketId")]
        public string? TicketId { get; set; }

        [JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }


    public class RestapiReportResponseCategory : StringEnum<RestapiReportResponseCategory>
    {
        public static readonly RestapiReportResponseCategory CHAT
            = new RestapiReportResponseCategory("CHAT");

        public static readonly RestapiReportResponseCategory EXTENSION
            = new RestapiReportResponseCategory("EXTENSION");

        public static readonly RestapiReportResponseCategory UGC
            = new RestapiReportResponseCategory("UGC");

        public static readonly RestapiReportResponseCategory USER
            = new RestapiReportResponseCategory("USER");


        public static implicit operator RestapiReportResponseCategory(string value)
        {
            return NewValue(value);
        }

        public RestapiReportResponseCategory(string enumValue)
            : base(enumValue)
        {

        }
    }    
}