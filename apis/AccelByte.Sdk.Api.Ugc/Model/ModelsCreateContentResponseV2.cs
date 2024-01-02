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

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsCreateContentResponseV2 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("channelId")]
        public string? ChannelId { get; set; }

        [JsonPropertyName("contentStatus")]
        [JsonStringEnum]
        public ModelsCreateContentResponseV2ContentStatus? ContentStatus { get; set; }

        [JsonPropertyName("contentType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ContentType { get; set; }

        [JsonPropertyName("createdTime")]
        public string? CreatedTime { get; set; }

        [JsonPropertyName("customAttributes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? CustomAttributes { get; set; }

        [JsonPropertyName("fileExtension")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FileExtension { get; set; }

        [JsonPropertyName("fileLocation")]
        public string? FileLocation { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("isHidden")]
        public bool? IsHidden { get; set; }

        [JsonPropertyName("isOfficial")]
        public bool? IsOfficial { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("parentNamespace")]
        public string? ParentNamespace { get; set; }

        [JsonPropertyName("payloadURL")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ModelsPayloadURL>? PayloadURL { get; set; }

        [JsonPropertyName("shareCode")]
        public string? ShareCode { get; set; }

        [JsonPropertyName("subType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SubType { get; set; }

        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }

        [JsonPropertyName("updatedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? UpdatedTime { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }

    public class ModelsCreateContentResponseV2<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("channelId")]
        public string? ChannelId { get; set; }

        [JsonPropertyName("contentStatus")]
        [JsonStringEnum]
        public ModelsCreateContentResponseV2ContentStatus? ContentStatus { get; set; }

        [JsonPropertyName("contentType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ContentType { get; set; }

        [JsonPropertyName("createdTime")]
        public string? CreatedTime { get; set; }

        [JsonPropertyName("customAttributes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? CustomAttributes { get; set; }

        [JsonPropertyName("fileExtension")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FileExtension { get; set; }

        [JsonPropertyName("fileLocation")]
        public string? FileLocation { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("isHidden")]
        public bool? IsHidden { get; set; }

        [JsonPropertyName("isOfficial")]
        public bool? IsOfficial { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("parentNamespace")]
        public string? ParentNamespace { get; set; }

        [JsonPropertyName("payloadURL")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ModelsPayloadURL>? PayloadURL { get; set; }

        [JsonPropertyName("shareCode")]
        public string? ShareCode { get; set; }

        [JsonPropertyName("subType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SubType { get; set; }

        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }

        [JsonPropertyName("updatedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? UpdatedTime { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }


    public class ModelsCreateContentResponseV2ContentStatus : StringEnum<ModelsCreateContentResponseV2ContentStatus>
    {
        public static readonly ModelsCreateContentResponseV2ContentStatus PUBLISHED
            = new ModelsCreateContentResponseV2ContentStatus("PUBLISHED");

        public static readonly ModelsCreateContentResponseV2ContentStatus UNDERREVIEW
            = new ModelsCreateContentResponseV2ContentStatus("UNDER_REVIEW");


        public static implicit operator ModelsCreateContentResponseV2ContentStatus(string value)
        {
            return NewValue(value);
        }

        public ModelsCreateContentResponseV2ContentStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}