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

namespace AccelByte.Sdk.Api.Reporting.Model
{
    public class RestapiModerationRuleRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("action")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public RestapiModerationRuleRequestAction? Action { get; set; }

        [JsonPropertyName("actions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public RestapiModerationRuleActionsRequest? Actions { get; set; }

        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        [JsonPropertyName("category")]
        [JsonStringEnum]
        public RestapiModerationRuleRequestCategory? Category { get; set; }

        [JsonPropertyName("extensionCategory")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtensionCategory { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("threshold")]
        public int? Threshold { get; set; }

    }



    public class RestapiModerationRuleRequestAction : StringEnum<RestapiModerationRuleRequestAction>
    {
        public static readonly RestapiModerationRuleRequestAction HideContent
            = new RestapiModerationRuleRequestAction("HideContent");


        public static implicit operator RestapiModerationRuleRequestAction(string value)
        {
            return NewValue(value);
        }

        public RestapiModerationRuleRequestAction(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class RestapiModerationRuleRequestCategory : StringEnum<RestapiModerationRuleRequestCategory>
    {
        public static readonly RestapiModerationRuleRequestCategory CHAT
            = new RestapiModerationRuleRequestCategory("CHAT");

        public static readonly RestapiModerationRuleRequestCategory EXTENSION
            = new RestapiModerationRuleRequestCategory("EXTENSION");

        public static readonly RestapiModerationRuleRequestCategory UGC
            = new RestapiModerationRuleRequestCategory("UGC");

        public static readonly RestapiModerationRuleRequestCategory USER
            = new RestapiModerationRuleRequestCategory("USER");


        public static implicit operator RestapiModerationRuleRequestCategory(string value)
        {
            return NewValue(value);
        }

        public RestapiModerationRuleRequestCategory(string enumValue)
            : base(enumValue)
        {

        }
    }
}