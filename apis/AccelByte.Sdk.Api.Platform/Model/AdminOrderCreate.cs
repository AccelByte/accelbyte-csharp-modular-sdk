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
    public class AdminOrderCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("currencyNamespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CurrencyNamespace { get; set; }

        [JsonPropertyName("discountedPrice")]
        public int? DiscountedPrice { get; set; }

        [JsonPropertyName("ext")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? Ext { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("language")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Language { get; set; }

        [JsonPropertyName("options")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public OrderCreationOptions? Options { get; set; }

        [JsonPropertyName("platform")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public AdminOrderCreatePlatform? Platform { get; set; }

        [JsonPropertyName("price")]
        public int? Price { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("returnUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReturnUrl { get; set; }

        [JsonPropertyName("sandbox")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Sandbox { get; set; }

        [JsonPropertyName("sectionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SectionId { get; set; }

    }

    public class AdminOrderCreate<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("currencyNamespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CurrencyNamespace { get; set; }

        [JsonPropertyName("discountedPrice")]
        public int? DiscountedPrice { get; set; }

        [JsonPropertyName("ext")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? Ext { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("language")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Language { get; set; }

        [JsonPropertyName("options")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public OrderCreationOptions? Options { get; set; }

        [JsonPropertyName("platform")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public AdminOrderCreatePlatform? Platform { get; set; }

        [JsonPropertyName("price")]
        public int? Price { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("returnUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReturnUrl { get; set; }

        [JsonPropertyName("sandbox")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Sandbox { get; set; }

        [JsonPropertyName("sectionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SectionId { get; set; }

    }


    public class AdminOrderCreatePlatform : StringEnum<AdminOrderCreatePlatform>
    {
        public static readonly AdminOrderCreatePlatform Epic
            = new AdminOrderCreatePlatform("Epic");

        public static readonly AdminOrderCreatePlatform GooglePlay
            = new AdminOrderCreatePlatform("GooglePlay");

        public static readonly AdminOrderCreatePlatform IOS
            = new AdminOrderCreatePlatform("IOS");

        public static readonly AdminOrderCreatePlatform Nintendo
            = new AdminOrderCreatePlatform("Nintendo");

        public static readonly AdminOrderCreatePlatform Oculus
            = new AdminOrderCreatePlatform("Oculus");

        public static readonly AdminOrderCreatePlatform Other
            = new AdminOrderCreatePlatform("Other");

        public static readonly AdminOrderCreatePlatform Playstation
            = new AdminOrderCreatePlatform("Playstation");

        public static readonly AdminOrderCreatePlatform Steam
            = new AdminOrderCreatePlatform("Steam");

        public static readonly AdminOrderCreatePlatform Xbox
            = new AdminOrderCreatePlatform("Xbox");


        public static implicit operator AdminOrderCreatePlatform(string value)
        {
            return NewValue(value);
        }

        public AdminOrderCreatePlatform(string enumValue)
            : base(enumValue)
        {

        }
    }    
}