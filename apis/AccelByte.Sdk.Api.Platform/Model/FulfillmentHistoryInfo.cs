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

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentHistoryInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Code { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("creditSummaries")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<CreditSummary>? CreditSummaries { get; set; }

        [JsonPropertyName("entitlementSummaries")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<EntitlementSummary>? EntitlementSummaries { get; set; }

        [JsonPropertyName("extensionFulfillmentSummaries")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ExtensionFulfillmentSummary>? ExtensionFulfillmentSummaries { get; set; }

        [JsonPropertyName("fulfillItems")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<FulfillmentItem>? FulfillItems { get; set; }

        [JsonPropertyName("fulfillmentError")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public FulfillmentError? FulfillmentError { get; set; }

        [JsonPropertyName("grantedItemIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? GrantedItemIds { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("orderNo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? OrderNo { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public FulfillmentHistoryInfoStatus? Status { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }



    public class FulfillmentHistoryInfoStatus : StringEnum<FulfillmentHistoryInfoStatus>
    {
        public static readonly FulfillmentHistoryInfoStatus FAIL
            = new FulfillmentHistoryInfoStatus("FAIL");

        public static readonly FulfillmentHistoryInfoStatus SUCCESS
            = new FulfillmentHistoryInfoStatus("SUCCESS");


        public static implicit operator FulfillmentHistoryInfoStatus(string value)
        {
            return NewValue(value);
        }

        public FulfillmentHistoryInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}