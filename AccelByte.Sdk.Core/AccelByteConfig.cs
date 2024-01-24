// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Security;

namespace AccelByte.Sdk.Core
{
    public class AccelByteConfig : IAccelByteConfig
    {
        public static string DefaultFlightId { get; private set; }

        static AccelByteConfig()
        {
            DefaultFlightId = Guid.NewGuid().ToString();
        }

        public void UpdateDefaultFlightId(string flightId)
        {
            DefaultFlightId = flightId;
        }


        public IHttpClient HttpClient { get; }

        public ITokenRepository TokenRepository { get; }

        public IConfigRepository ConfigRepository { get; }

        public ICredentialRepository? Credential { get; set; }

        public ITokenValidator? TokenValidator { get; set; }

        public Dictionary<string, bool> Flags { get; private set; }

        public AccelByteConfig(
                IHttpClient httpClient,
                ITokenRepository tokenRepository,
                IConfigRepository configRepository)
        {
            HttpClient = httpClient;
            TokenRepository = tokenRepository;
            ConfigRepository = configRepository;
            Flags = new Dictionary<string, bool>();
        }

        public AccelByteConfig(
                IHttpClient httpClient,
                ITokenRepository tokenRepository,
                IConfigRepository configRepository,
                Dictionary<string, bool> flags)
        {
            HttpClient = httpClient;
            TokenRepository = tokenRepository;
            ConfigRepository = configRepository;
            Flags = flags;
        }
    }
}