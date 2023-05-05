// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

namespace AccelByte.Sdk.Core.Security
{
    public interface ITokenResponse
    {
        string AccessToken { get; }

        int? ExpiresIn { get; }

        string DisplayName { get; }

        string Namespace { get; }

        string RefreshToken { get; }

        int? RefreshExpiresIn { get; }

        string TokenType { get; }

        string UserId { get; }
    }
}
