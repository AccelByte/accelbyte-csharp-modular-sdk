// Copyright (c) 2022-2025 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Text;

using AccelByte.Sdk.Core.Security;

namespace AccelByte.Sdk.Core.Repository
{
    public interface ITokenRepository
    {
        string Token { get; }

        string RefreshToken { get; }

        int TokenExpiryIn { get; }

        int RefreshExpireIn { get; }

        int SecondsUntilExpiry { get; }

        long IssuedTimestamp { get; }

        bool HasToken { get; }

        bool HasRefreshToken { get; }

        bool IsTokenExpired { get; }

        LoginType LoginType { get; }

        ITokenResponse? TokenData { get; }

        void RemoveToken();

        void StoreToken(LoginType loginType, ITokenResponse tokenResponse);

        void UpdateToken(ITokenResponse tokenResponse);

        void SetTokenExpiry(int value);

        bool IsTokenExpiring(float rate);
    }
}
