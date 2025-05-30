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
    public class XblReconcileResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("iapOrderStatus")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public XblReconcileResultIapOrderStatus? IapOrderStatus { get; set; }

        [JsonPropertyName("itemId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemId { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("transactionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TransactionId { get; set; }

        [JsonPropertyName("xboxProductId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? XboxProductId { get; set; }

    }



    public class XblReconcileResultIapOrderStatus : StringEnum<XblReconcileResultIapOrderStatus>
    {
        public static readonly XblReconcileResultIapOrderStatus FAILED
            = new XblReconcileResultIapOrderStatus("FAILED");

        public static readonly XblReconcileResultIapOrderStatus FULFILLED
            = new XblReconcileResultIapOrderStatus("FULFILLED");

        public static readonly XblReconcileResultIapOrderStatus PARTIALREVOKED
            = new XblReconcileResultIapOrderStatus("PARTIAL_REVOKED");

        public static readonly XblReconcileResultIapOrderStatus REVOKED
            = new XblReconcileResultIapOrderStatus("REVOKED");

        public static readonly XblReconcileResultIapOrderStatus REVOKEFAILED
            = new XblReconcileResultIapOrderStatus("REVOKE_FAILED");

        public static readonly XblReconcileResultIapOrderStatus VERIFIED
            = new XblReconcileResultIapOrderStatus("VERIFIED");


        public static implicit operator XblReconcileResultIapOrderStatus(string value)
        {
            return NewValue(value);
        }

        public XblReconcileResultIapOrderStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}