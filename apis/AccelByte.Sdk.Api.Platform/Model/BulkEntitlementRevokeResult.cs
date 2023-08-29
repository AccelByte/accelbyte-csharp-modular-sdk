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
    public class BulkEntitlementRevokeResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("failList")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<EntitlementRevokeResult>? FailList { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public BulkEntitlementRevokeResultStatus? Status { get; set; }

        [JsonPropertyName("successList")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<EntitlementRevokeResult>? SuccessList { get; set; }

    }



    public class BulkEntitlementRevokeResultStatus : StringEnum<BulkEntitlementRevokeResultStatus>
    {
        public static readonly BulkEntitlementRevokeResultStatus FAIL
            = new BulkEntitlementRevokeResultStatus("FAIL");

        public static readonly BulkEntitlementRevokeResultStatus PARTIALSUCCESS
            = new BulkEntitlementRevokeResultStatus("PARTIAL_SUCCESS");

        public static readonly BulkEntitlementRevokeResultStatus SUCCESS
            = new BulkEntitlementRevokeResultStatus("SUCCESS");


        public static implicit operator BulkEntitlementRevokeResultStatus(string value)
        {
            return NewValue(value);
        }

        public BulkEntitlementRevokeResultStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}