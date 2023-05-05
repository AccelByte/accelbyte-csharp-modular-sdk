// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Security;

namespace AccelByte.Sdk.Core
{
    public class AccelByteConfig : IAccelByteConfig
    {
        public IHttpClient HttpClient { get; }

        public ITokenRepository TokenRepository { get; }

        public IConfigRepository ConfigRepository { get; }

        public ICredentialRepository? Credential { get; set; }

        public ITokenValidator? TokenValidator { get; set; }

        public AccelByteConfig(
                IHttpClient httpClient,
                ITokenRepository tokenRepository,
                IConfigRepository configRepository)
        {
            HttpClient = httpClient;
            TokenRepository = tokenRepository;
            ConfigRepository = configRepository;
        }
    }
}