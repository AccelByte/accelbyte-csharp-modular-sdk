// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core.Security;
using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Authentication
{
    public class AuthTokenResponse : ITokenResponse
    {
        public string AccessToken { get; }

        public int? ExpiresIn { get; }

        public string DisplayName { get; }

        public string Namespace { get; }

        public string RefreshToken { get; }

        public int? RefreshExpiresIn { get; }

        public string TokenType { get; }

        public string UserId { get; }

        internal AuthTokenResponse(OauthmodelTokenResponseV3 token)
        {
            AccessToken = token.AccessToken ?? "";
            ExpiresIn = token.ExpiresIn;
            RefreshToken = token.RefreshToken ?? "";
            RefreshExpiresIn = token.RefreshExpiresIn;

            DisplayName = token.DisplayName ?? "";
            Namespace = token.Namespace ?? "";
            TokenType = token.TokenType ?? "";
            UserId = token.UserId ?? "";
        }

        internal AuthTokenResponse(OauthmodelTokenResponse token)
        {
            AccessToken = token.AccessToken!;
            ExpiresIn = token.ExpiresIn;
            RefreshToken = token.RefreshToken ?? "";
            RefreshExpiresIn = token.RefreshExpiresIn;

            DisplayName = token.DisplayName ?? "";
            Namespace = token.Namespace ?? "";
            TokenType = token.TokenType ?? "";
            UserId = token.UserId ?? "";
        }

        internal AuthTokenResponse(OauthmodelTokenWithDeviceCookieResponseV3 token)
        {
            AccessToken = token.AccessToken!;
            ExpiresIn = token.ExpiresIn;
            RefreshToken = token.RefreshToken ?? "";
            RefreshExpiresIn = token.RefreshExpiresIn;

            DisplayName = token.DisplayName ?? "";
            Namespace = token.Namespace ?? "";
            TokenType = token.TokenType ?? "";
            UserId = token.UserId ?? "";
        }
    }
}
