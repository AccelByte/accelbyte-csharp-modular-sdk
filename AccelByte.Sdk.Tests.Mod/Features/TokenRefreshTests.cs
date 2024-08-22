// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Tests.Mod.Repository;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Feature.AutoTokenRefresh;

using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Lobby;
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Api.Legal.Wrapper;

namespace AccelByte.Sdk.Tests.Mod.Features
{
    [TestFixture(Category = "RefreshTokenIntegration")]
    [Explicit]
    public class TokenRefreshTests
    {
        [Test]
        public void UserLoginWithAutoRefreshToken()
        {
            using var sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultCredentialRepository()
                .UseAutoTokenRefresh()
                .EnableLog()
                .Build();

            sdk.LoginUser(true);

            //First request, valid token
            List<RetrieveAcceptedAgreementResponse>? aggrs1 = sdk.GetLegalApi().Agreement.RetrieveAgreementsPublic(
                RetrieveAgreementsPublic
                .Builder.Build());
            Assert.IsNotNull(aggrs1);

            //Force token expire
            if (sdk.Configuration.TokenRepository is RefreshableTokenRepository)
            {
                RefreshableTokenRepository tokenRepo = (RefreshableTokenRepository)sdk.Configuration.TokenRepository;
                tokenRepo.SetTokenExpiry(5); // expiry in 5 seconds

                //wait for 5 seconds
                Thread.Sleep(5000);
            }

            //Second request, expired token, try to do refresh
            List<RetrieveAcceptedAgreementResponse>? aggrs2 = sdk.GetLegalApi().Agreement.RetrieveAgreementsPublic(
                RetrieveAgreementsPublic
                .Builder.Build());
            Assert.IsNotNull(aggrs2);

            sdk.Logout();
        }

        [Test]
        public void ClientLoginWithAutoRefreshToken()
        {
            using var sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultCredentialRepository()
                .UseAutoTokenRefresh()
                .EnableLog()
                .Build();

            sdk.LoginClient(true);

            //First request, valid token
            ModelsPublicAchievementsResponse? achResp1 = sdk.GetAchievementApi().Achievements.PublicListAchievementsOp
                .Execute(sdk.Namespace, "en");
            Assert.IsNotNull(achResp1);

            //Force token expire
            if (sdk.Configuration.TokenRepository is RefreshableTokenRepository)
            {
                RefreshableTokenRepository tokenRepo = (RefreshableTokenRepository)sdk.Configuration.TokenRepository;
                tokenRepo.SetTokenExpiry(5); // expiry in 5 seconds

                //wait for 5 seconds
                Thread.Sleep(5000);
            }

            //Second request, expired token, try to do refresh
            ModelsPublicAchievementsResponse? achResp2 = sdk.GetAchievementApi().Achievements.PublicListAchievementsOp
                .Execute(sdk.Namespace, "en");
            Assert.IsNotNull(achResp2);

            sdk.Logout();
        }

        [Test]
        public void AutoRefreshTokenForWebSocket()
        {
            using var sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultCredentialRepository()
                .UseAutoTokenRefresh()
                .EnableLog()
                .SetOnAfterLoginEventHandler((loginType, authType, tokenData, fSdk) =>
                {
                    if (fSdk.Configuration.TokenRepository is RefreshableTokenRepository)
                    {
                        RefreshableTokenRepository tokenRepo = (RefreshableTokenRepository)fSdk.Configuration.TokenRepository;
                        tokenRepo.SetTokenExpiry(5); // expiry in 5 seconds
                    }
                })
                .Build();

            sdk.LoginUser(true);

            bool isRefreshTokenResponseReceived = false;

            CancellationTokenSource lobbyListenCt = new CancellationTokenSource();
            Thread wsThread = new Thread(new ThreadStart(() =>
            {
                LobbyService lobby = new LobbyService(sdk.Configuration);
                lobby.RedirectAllReceivedMessagesToMessageReceivedEvent = true;
                lobby.OnMessageReceived = (aMsg) =>
                {
                    if (aMsg.MessageType == "refreshTokenResponse")
                        isRefreshTokenResponseReceived = true;
                };

                Task connectTask = lobby.Connect(false);
                connectTask.Wait();

                Task listenTask = lobby.Listen(lobbyListenCt.Token);
                listenTask.Wait();

                Task disconnectTask = lobby.Disconnect();
                disconnectTask.Wait();
            }));

            //start lobby ws thread
            wsThread.Start();

            //sleep for 5s to make sure the token is expired
            Thread.Sleep(5000);

            //force token to be refreshed by calling any op
            ModelsPublicAchievementsResponse? achResp = sdk.GetAchievementApi().Achievements
                .PublicListAchievementsOp
                    .Execute(sdk.Namespace, "en");
            Assert.IsNotNull(achResp);

            //wait for any ws response
            Thread.Sleep(2000);

            Assert.IsTrue(isRefreshTokenResponseReceived);

            //cancel ws listen
            lobbyListenCt.Cancel();

            //wait until lobby ws thread is stopped
            while (wsThread.IsAlive)
                Thread.Sleep(100);

            sdk.Logout();
        }
    }
}
