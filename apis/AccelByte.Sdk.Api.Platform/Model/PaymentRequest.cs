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
    public class PaymentRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("metadata")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? Metadata { get; set; }

        [JsonPropertyName("walletPlatform")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PaymentRequestWalletPlatform? WalletPlatform { get; set; }

    }

    public class PaymentRequest<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("metadata")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? Metadata { get; set; }

        [JsonPropertyName("walletPlatform")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PaymentRequestWalletPlatform? WalletPlatform { get; set; }

    }


    public class PaymentRequestWalletPlatform : StringEnum<PaymentRequestWalletPlatform>
    {
        public static readonly PaymentRequestWalletPlatform Epic
            = new PaymentRequestWalletPlatform("Epic");

        public static readonly PaymentRequestWalletPlatform GooglePlay
            = new PaymentRequestWalletPlatform("GooglePlay");

        public static readonly PaymentRequestWalletPlatform IOS
            = new PaymentRequestWalletPlatform("IOS");

        public static readonly PaymentRequestWalletPlatform Nintendo
            = new PaymentRequestWalletPlatform("Nintendo");

        public static readonly PaymentRequestWalletPlatform Oculus
            = new PaymentRequestWalletPlatform("Oculus");

        public static readonly PaymentRequestWalletPlatform Other
            = new PaymentRequestWalletPlatform("Other");

        public static readonly PaymentRequestWalletPlatform Playstation
            = new PaymentRequestWalletPlatform("Playstation");

        public static readonly PaymentRequestWalletPlatform Steam
            = new PaymentRequestWalletPlatform("Steam");

        public static readonly PaymentRequestWalletPlatform Xbox
            = new PaymentRequestWalletPlatform("Xbox");


        public static implicit operator PaymentRequestWalletPlatform(string value)
        {
            return NewValue(value);
        }

        public PaymentRequestWalletPlatform(string enumValue)
            : base(enumValue)
        {

        }
    }
}