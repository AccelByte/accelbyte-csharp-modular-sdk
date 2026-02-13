// Copyright (c) 2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Net.Http;

namespace AccelByte.Sdk.Tests.Mod.Scenario
{
    public class RepoTestPlayer : ITestPlayer
    {
        private readonly DefaultTokenRepository _TokenRepo;

        private readonly IAccelByteSdk _Sdk;

        private readonly ICredentialRepository _CredentialRepo;

        public string AccessToken { get => _TokenRepo.Token; }

        public string UserId { get => _CredentialRepo.UserId; }

        public RepoTestPlayer(IConfigRepository config, ICredentialRepository credential, bool doLogin)
        {
            _TokenRepo = new DefaultTokenRepository();
            _CredentialRepo = credential;
            _Sdk = AccelByteSdk.Builder
                .SetConfigRepository(config)
                .UseDefaultHttpClient()
                .SetCredentialRepository(_CredentialRepo)
                .SetTokenRepository(_TokenRepo)
                .EnableLog()
                .Build();

            if (doLogin)
                Login();
        }

        public void Login()
        {
            _Sdk.LoginUser();
        }

        public void Logout()
        {
            _Sdk.Logout();
        }

        public void Run(Action<IAccelByteSdk, ITestPlayer> action)
        {
            action.Invoke(_Sdk, this);
        }
    }
}
