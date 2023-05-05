// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

namespace AccelByte.Sdk.Core.Repository
{
    public interface ICredentialRepository
    {
        string Username { get; }

        string Password { get; }

        string UserId { get; set; }
    }
}