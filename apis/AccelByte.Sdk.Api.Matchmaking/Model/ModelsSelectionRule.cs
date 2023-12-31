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

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsSelectionRule : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("selection")]
        [JsonStringEnum]
        public ModelsSelectionRuleSelection? Selection { get; set; }

        [JsonPropertyName("threshold")]
        public long? Threshold { get; set; }

    }



    public class ModelsSelectionRuleSelection : StringEnum<ModelsSelectionRuleSelection>
    {
        public static readonly ModelsSelectionRuleSelection Newest
            = new ModelsSelectionRuleSelection("newest");

        public static readonly ModelsSelectionRuleSelection Oldest
            = new ModelsSelectionRuleSelection("oldest");

        public static readonly ModelsSelectionRuleSelection Pivot
            = new ModelsSelectionRuleSelection("pivot");

        public static readonly ModelsSelectionRuleSelection Random
            = new ModelsSelectionRuleSelection("random");


        public static implicit operator ModelsSelectionRuleSelection(string value)
        {
            return NewValue(value);
        }

        public ModelsSelectionRuleSelection(string enumValue)
            : base(enumValue)
        {

        }
    }
}