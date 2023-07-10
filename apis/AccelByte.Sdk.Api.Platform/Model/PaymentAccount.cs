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
    public class PaymentAccount : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public PaymentAccountType? Type { get; set; }

    }



    public class PaymentAccountType : StringEnum<PaymentAccountType>
    {
        public static readonly PaymentAccountType Card
            = new PaymentAccountType("card");

        public static readonly PaymentAccountType Paypal
            = new PaymentAccountType("paypal");


        public static implicit operator PaymentAccountType(string value)
        {
            return NewValue(value);
        }

        public PaymentAccountType(string enumValue)
            : base(enumValue)
        {

        }
    }
}