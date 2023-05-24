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
    public class RevocationResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("creditRevocations")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<CreditRevocation>? CreditRevocations { get; set; }

        [JsonPropertyName("entitlementRevocations")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<EntitlementRevocation>? EntitlementRevocations { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("itemRevocations")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ItemRevocation>? ItemRevocations { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public RevocationResultStatus? Status { get; set; }

    }



    public class RevocationResultStatus : StringEnum<RevocationResultStatus>
    {
        public static readonly RevocationResultStatus FAIL
            = new RevocationResultStatus("FAIL");

        public static readonly RevocationResultStatus SUCCESS
            = new RevocationResultStatus("SUCCESS");


        public static implicit operator RevocationResultStatus(string value)
        {
            return NewValue(value);
        }

        public RevocationResultStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}