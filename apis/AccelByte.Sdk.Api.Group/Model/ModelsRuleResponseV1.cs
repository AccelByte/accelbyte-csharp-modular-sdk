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

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsRuleResponseV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allowedAction")]
        [JsonStringEnum]
        public ModelsRuleResponseV1AllowedAction? AllowedAction { get; set; }

        [JsonPropertyName("ruleDetail")]
        public List<ModelsRuleInformation>? RuleDetail { get; set; }

    }



    public class ModelsRuleResponseV1AllowedAction : StringEnum<ModelsRuleResponseV1AllowedAction>
    {
        public static readonly ModelsRuleResponseV1AllowedAction CreateGroup
            = new ModelsRuleResponseV1AllowedAction("createGroup");

        public static readonly ModelsRuleResponseV1AllowedAction JoinGroup
            = new ModelsRuleResponseV1AllowedAction("joinGroup");


        public static implicit operator ModelsRuleResponseV1AllowedAction(string value)
        {
            return NewValue(value);
        }

        public ModelsRuleResponseV1AllowedAction(string enumValue)
            : base(enumValue)
        {

        }
    }
}