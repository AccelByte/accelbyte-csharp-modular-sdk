// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Core.Security;

namespace AccelByte.Sdk.Core
{
    public interface IAccelByteConfig
    {
        IHttpClient HttpClient { get; }

        ITokenRepository TokenRepository { get; }

        IConfigRepository ConfigRepository { get; }

        ICredentialRepository? Credential { get; set; }

        ITokenValidator? TokenValidator { get; set; }
    }
}
