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

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsAdminConcurrentRecordRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("set_by")]
        [JsonStringEnum]
        public ModelsAdminConcurrentRecordRequestSetBy? SetBy { get; set; }

        [JsonPropertyName("ttl_config")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsTTLConfigDTO? TtlConfig { get; set; }

        [JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        [JsonPropertyName("value")]
        public Dictionary<string, object>? Value { get; set; }

    }

    public class ModelsAdminConcurrentRecordRequest<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("set_by")]
        [JsonStringEnum]
        public ModelsAdminConcurrentRecordRequestSetBy? SetBy { get; set; }

        [JsonPropertyName("ttl_config")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsTTLConfigDTO? TtlConfig { get; set; }

        [JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        [JsonPropertyName("value")]
        public T1? Value { get; set; }

    }


    public class ModelsAdminConcurrentRecordRequestSetBy : StringEnum<ModelsAdminConcurrentRecordRequestSetBy>
    {
        public static readonly ModelsAdminConcurrentRecordRequestSetBy CLIENT
            = new ModelsAdminConcurrentRecordRequestSetBy("CLIENT");

        public static readonly ModelsAdminConcurrentRecordRequestSetBy SERVER
            = new ModelsAdminConcurrentRecordRequestSetBy("SERVER");


        public static implicit operator ModelsAdminConcurrentRecordRequestSetBy(string value)
        {
            return NewValue(value);
        }

        public ModelsAdminConcurrentRecordRequestSetBy(string enumValue)
            : base(enumValue)
        {

        }
    }
}