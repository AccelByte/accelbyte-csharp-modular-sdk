// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsGroupResponseV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("configurationCode")]
        public string? ConfigurationCode { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("customAttributes")]
        public Dictionary<string, object>? CustomAttributes { get; set; }

        [JsonPropertyName("groupDescription")]
        public string? GroupDescription { get; set; }

        [JsonPropertyName("groupIcon")]
        public string? GroupIcon { get; set; }

        [JsonPropertyName("groupId")]
        public string? GroupId { get; set; }

        [JsonPropertyName("groupMaxMember")]
        public int? GroupMaxMember { get; set; }

        [JsonPropertyName("groupMembers")]
        public List<ModelsGroupMember>? GroupMembers { get; set; }

        [JsonPropertyName("groupName")]
        public string? GroupName { get; set; }

        [JsonPropertyName("groupRegion")]
        public string? GroupRegion { get; set; }

        [JsonPropertyName("groupRules")]
        public ModelsGroupRuleResponseV1? GroupRules { get; set; }

        [JsonPropertyName("groupType")]
        [JsonStringEnum]
        public ModelsGroupResponseV1GroupType? GroupType { get; set; }

    }

    public class ModelsGroupResponseV1<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("configurationCode")]
        public string? ConfigurationCode { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("customAttributes")]
        public T1? CustomAttributes { get; set; }

        [JsonPropertyName("groupDescription")]
        public string? GroupDescription { get; set; }

        [JsonPropertyName("groupIcon")]
        public string? GroupIcon { get; set; }

        [JsonPropertyName("groupId")]
        public string? GroupId { get; set; }

        [JsonPropertyName("groupMaxMember")]
        public int? GroupMaxMember { get; set; }

        [JsonPropertyName("groupMembers")]
        public List<ModelsGroupMember>? GroupMembers { get; set; }

        [JsonPropertyName("groupName")]
        public string? GroupName { get; set; }

        [JsonPropertyName("groupRegion")]
        public string? GroupRegion { get; set; }

        [JsonPropertyName("groupRules")]
        public ModelsGroupRuleResponseV1? GroupRules { get; set; }

        [JsonPropertyName("groupType")]
        [JsonStringEnum]
        public ModelsGroupResponseV1GroupType? GroupType { get; set; }

    }


    public class ModelsGroupResponseV1GroupType : StringEnum<ModelsGroupResponseV1GroupType>
    {
        public static readonly ModelsGroupResponseV1GroupType OPEN
            = new ModelsGroupResponseV1GroupType("OPEN");

        public static readonly ModelsGroupResponseV1GroupType PRIVATE
            = new ModelsGroupResponseV1GroupType("PRIVATE");

        public static readonly ModelsGroupResponseV1GroupType PUBLIC
            = new ModelsGroupResponseV1GroupType("PUBLIC");


        public static implicit operator ModelsGroupResponseV1GroupType(string value)
        {
            return NewValue(value);
        }

        public ModelsGroupResponseV1GroupType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}