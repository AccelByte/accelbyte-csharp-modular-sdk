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
    public class PublicEntitlementMetadata : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("operationSource")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PublicEntitlementMetadataOperationSource? OperationSource { get; set; }

    }



    public class PublicEntitlementMetadataOperationSource : StringEnum<PublicEntitlementMetadataOperationSource>
    {
        public static readonly PublicEntitlementMetadataOperationSource INVENTORY
            = new PublicEntitlementMetadataOperationSource("INVENTORY");


        public static implicit operator PublicEntitlementMetadataOperationSource(string value)
        {
            return NewValue(value);
        }

        public PublicEntitlementMetadataOperationSource(string enumValue)
            : base(enumValue)
        {

        }
    }
}