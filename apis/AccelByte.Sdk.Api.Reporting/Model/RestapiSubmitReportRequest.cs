// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Reporting.Model
{
    public class RestapiSubmitReportRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalInfo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? AdditionalInfo { get; set; }

        [JsonPropertyName("category")]
        [JsonStringEnum]
        public RestapiSubmitReportRequestCategory? Category { get; set; }

        [JsonPropertyName("comment")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Comment { get; set; }

        [JsonPropertyName("extensionCategory")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtensionCategory { get; set; }

        [JsonPropertyName("objectId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ObjectId { get; set; }

        [JsonPropertyName("objectType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ObjectType { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }

    public class RestapiSubmitReportRequest<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalInfo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? AdditionalInfo { get; set; }

        [JsonPropertyName("category")]
        [JsonStringEnum]
        public RestapiSubmitReportRequestCategory? Category { get; set; }

        [JsonPropertyName("comment")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Comment { get; set; }

        [JsonPropertyName("extensionCategory")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtensionCategory { get; set; }

        [JsonPropertyName("objectId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ObjectId { get; set; }

        [JsonPropertyName("objectType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ObjectType { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }


    public class RestapiSubmitReportRequestCategory : StringEnum<RestapiSubmitReportRequestCategory>
    {
        public static readonly RestapiSubmitReportRequestCategory CHAT
            = new RestapiSubmitReportRequestCategory("CHAT");

        public static readonly RestapiSubmitReportRequestCategory EXTENSION
            = new RestapiSubmitReportRequestCategory("EXTENSION");

        public static readonly RestapiSubmitReportRequestCategory UGC
            = new RestapiSubmitReportRequestCategory("UGC");

        public static readonly RestapiSubmitReportRequestCategory USER
            = new RestapiSubmitReportRequestCategory("USER");


        public static implicit operator RestapiSubmitReportRequestCategory(string value)
        {
            return NewValue(value);
        }

        public RestapiSubmitReportRequestCategory(string enumValue)
            : base(enumValue)
        {

        }
    }    
}