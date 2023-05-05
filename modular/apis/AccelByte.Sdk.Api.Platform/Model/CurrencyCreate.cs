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
    public class CurrencyCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("currencySymbol")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CurrencySymbol { get; set; }

        [JsonPropertyName("currencyType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public CurrencyCreateCurrencyType? CurrencyType { get; set; }

        [JsonPropertyName("decimals")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Decimals { get; set; }

        [JsonPropertyName("localizationDescriptions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string>? LocalizationDescriptions { get; set; }

    }



    public class CurrencyCreateCurrencyType : StringEnum<CurrencyCreateCurrencyType>
    {
        public static readonly CurrencyCreateCurrencyType REAL
            = new CurrencyCreateCurrencyType("REAL");

        public static readonly CurrencyCreateCurrencyType VIRTUAL
            = new CurrencyCreateCurrencyType("VIRTUAL");


        public static implicit operator CurrencyCreateCurrencyType(string value)
        {
            return NewValue(value);
        }

        public CurrencyCreateCurrencyType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}