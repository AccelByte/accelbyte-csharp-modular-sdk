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

namespace AccelByte.Sdk.Api.Challenge.Model
{
    public class ModelPluginAssignmentRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AppName { get; set; }

        [JsonPropertyName("extendType")]
        [JsonStringEnum]
        public ModelPluginAssignmentRequestExtendType? ExtendType { get; set; }

        [JsonPropertyName("grpcServerAddress")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? GrpcServerAddress { get; set; }

    }



    public class ModelPluginAssignmentRequestExtendType : StringEnum<ModelPluginAssignmentRequestExtendType>
    {
        public static readonly ModelPluginAssignmentRequestExtendType APP
            = new ModelPluginAssignmentRequestExtendType("APP");

        public static readonly ModelPluginAssignmentRequestExtendType CUSTOM
            = new ModelPluginAssignmentRequestExtendType("CUSTOM");


        public static implicit operator ModelPluginAssignmentRequestExtendType(string value)
        {
            return NewValue(value);
        }

        public ModelPluginAssignmentRequestExtendType(string enumValue)
            : base(enumValue)
        {

        }
    }
}