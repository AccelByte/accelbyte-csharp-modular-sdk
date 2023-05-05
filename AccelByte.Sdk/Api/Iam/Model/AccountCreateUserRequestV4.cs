// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountCreateUserRequestV4 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("acceptedPolicies")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<LegalAcceptedPoliciesRequest>? AcceptedPolicies { get; set; }

        [JsonPropertyName("authType")]
        [JsonStringEnum]
        public AccountCreateUserRequestV4AuthType? AuthType { get; set; }

        [JsonPropertyName("code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Code { get; set; }

        [JsonPropertyName("country")]
        public string? Country { get; set; }

        [JsonPropertyName("dateOfBirth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DateOfBirth { get; set; }

        [JsonPropertyName("displayName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DisplayName { get; set; }

        [JsonPropertyName("emailAddress")]
        public string? EmailAddress { get; set; }

        [JsonPropertyName("password")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Password { get; set; }

        [JsonPropertyName("passwordMD5Sum")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PasswordMD5Sum { get; set; }

        [JsonPropertyName("reachMinimumAge")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ReachMinimumAge { get; set; }

        [JsonPropertyName("username")]
        public string? Username { get; set; }

    }



    public class AccountCreateUserRequestV4AuthType : StringEnum<AccountCreateUserRequestV4AuthType>
    {
        public static readonly AccountCreateUserRequestV4AuthType EMAILPASSWD
            = new AccountCreateUserRequestV4AuthType("EMAILPASSWD");


        public static implicit operator AccountCreateUserRequestV4AuthType(string value)
        {
            return NewValue(value);
        }

        public AccountCreateUserRequestV4AuthType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}