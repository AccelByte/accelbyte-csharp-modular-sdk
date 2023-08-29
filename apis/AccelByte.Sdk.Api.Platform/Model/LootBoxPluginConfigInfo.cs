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
    public class LootBoxPluginConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public AppConfig? AppConfig { get; set; }

        [JsonPropertyName("customConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PublicCustomConfigInfo? CustomConfig { get; set; }

        [JsonPropertyName("extendType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public LootBoxPluginConfigInfoExtendType? ExtendType { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

    }



    public class LootBoxPluginConfigInfoExtendType : StringEnum<LootBoxPluginConfigInfoExtendType>
    {
        public static readonly LootBoxPluginConfigInfoExtendType APP
            = new LootBoxPluginConfigInfoExtendType("APP");

        public static readonly LootBoxPluginConfigInfoExtendType CUSTOM
            = new LootBoxPluginConfigInfoExtendType("CUSTOM");


        public static implicit operator LootBoxPluginConfigInfoExtendType(string value)
        {
            return NewValue(value);
        }

        public LootBoxPluginConfigInfoExtendType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}