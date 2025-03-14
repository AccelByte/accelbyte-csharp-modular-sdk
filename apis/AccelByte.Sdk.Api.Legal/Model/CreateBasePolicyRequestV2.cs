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

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class CreateBasePolicyRequestV2 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("affectedClientIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? AffectedClientIds { get; set; }

        [JsonPropertyName("affectedCountries")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? AffectedCountries { get; set; }

        [JsonPropertyName("basePolicyName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BasePolicyName { get; set; }

        [JsonPropertyName("countryGroupName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CountryGroupName { get; set; }

        [JsonPropertyName("countryType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public CreateBasePolicyRequestV2CountryType? CountryType { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("isHidden")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsHidden { get; set; }

        [JsonPropertyName("isHiddenPublic")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsHiddenPublic { get; set; }

        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("typeId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TypeId { get; set; }

    }



    public class CreateBasePolicyRequestV2CountryType : StringEnum<CreateBasePolicyRequestV2CountryType>
    {
        public static readonly CreateBasePolicyRequestV2CountryType COUNTRY
            = new CreateBasePolicyRequestV2CountryType("COUNTRY");

        public static readonly CreateBasePolicyRequestV2CountryType COUNTRYGROUP
            = new CreateBasePolicyRequestV2CountryType("COUNTRY_GROUP");


        public static implicit operator CreateBasePolicyRequestV2CountryType(string value)
        {
            return NewValue(value);
        }

        public CreateBasePolicyRequestV2CountryType(string enumValue)
            : base(enumValue)
        {

        }
    }
}