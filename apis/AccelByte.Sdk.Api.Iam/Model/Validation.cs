// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class Validation : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allowAllSpecialCharacters")]
        public bool? AllowAllSpecialCharacters { get; set; }

        [JsonPropertyName("allowDigit")]
        public bool? AllowDigit { get; set; }

        [JsonPropertyName("allowLetter")]
        public bool? AllowLetter { get; set; }

        [JsonPropertyName("allowSpace")]
        public bool? AllowSpace { get; set; }

        [JsonPropertyName("allowUnicode")]
        public bool? AllowUnicode { get; set; }

        [JsonPropertyName("avatarConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public AccountcommonAvatarConfig? AvatarConfig { get; set; }

        [JsonPropertyName("blockedWord")]
        public List<string>? BlockedWord { get; set; }

        [JsonPropertyName("description")]
        public List<ValidationDescription>? Description { get; set; }

        [JsonPropertyName("isCustomRegex")]
        public bool? IsCustomRegex { get; set; }

        [JsonPropertyName("letterCase")]
        public string? LetterCase { get; set; }

        [JsonPropertyName("maxLength")]
        public int? MaxLength { get; set; }

        [JsonPropertyName("maxRepeatingAlphaNum")]
        public int? MaxRepeatingAlphaNum { get; set; }

        [JsonPropertyName("maxRepeatingSpecialCharacter")]
        public int? MaxRepeatingSpecialCharacter { get; set; }

        [JsonPropertyName("minCharType")]
        public int? MinCharType { get; set; }

        [JsonPropertyName("minLength")]
        public int? MinLength { get; set; }

        [JsonPropertyName("profanityFilter")]
        public string? ProfanityFilter { get; set; }

        [JsonPropertyName("regex")]
        public string? Regex { get; set; }

        [JsonPropertyName("specialCharacterLocation")]
        public string? SpecialCharacterLocation { get; set; }

        [JsonPropertyName("specialCharacters")]
        public List<string>? SpecialCharacters { get; set; }

    }


}