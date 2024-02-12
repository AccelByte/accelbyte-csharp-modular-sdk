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
    public class ModelsGameBinaryRecordAdminResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("binary_info")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsBinaryInfoResponse? BinaryInfo { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("key")]
        public string? Key { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("set_by")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ModelsGameBinaryRecordAdminResponseSetBy? SetBy { get; set; }

        [JsonPropertyName("ttl_config")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsTTLConfigDTO? TtlConfig { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }

    }



    public class ModelsGameBinaryRecordAdminResponseSetBy : StringEnum<ModelsGameBinaryRecordAdminResponseSetBy>
    {
        public static readonly ModelsGameBinaryRecordAdminResponseSetBy CLIENT
            = new ModelsGameBinaryRecordAdminResponseSetBy("CLIENT");

        public static readonly ModelsGameBinaryRecordAdminResponseSetBy SERVER
            = new ModelsGameBinaryRecordAdminResponseSetBy("SERVER");


        public static implicit operator ModelsGameBinaryRecordAdminResponseSetBy(string value)
        {
            return NewValue(value);
        }

        public ModelsGameBinaryRecordAdminResponseSetBy(string enumValue)
            : base(enumValue)
        {

        }
    }
}