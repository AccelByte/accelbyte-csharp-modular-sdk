// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

namespace AccelByte.Sdk.Core.Security
{
    public interface ITokenValidator
    {
        bool Validate(IAccelByteSdk sdk, string accessToken);

        bool Validate(IAccelByteSdk sdk, string accessToken, string permission, int action);

        bool Validate(IAccelByteSdk sdk, string accessToken, string permission, int action, string? aNamespace, string? userId);
    }
}
