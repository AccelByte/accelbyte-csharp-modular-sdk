// Copyright (c) 2024-2025 AccelByte Inc. All Rights Reserved.
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
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultCredentialRepository()
                .UseOnDemandTokenRefresh()
                .EnableLog()
                .Build();

            sdk.LoginUser();

            //First request, valid token
            _ = sdk.GetLegalApi().Agreement.RetrieveAgreementsPublicOp
                .Execute()
                .EnsureSuccess();

            //force expiry in 5 seconds
            sdk.Configuration.TokenRepository.SetTokenExpiry(5); 

            //wait for 5 seconds
            Thread.Sleep(5000);

            //Second request, expired token, try to do refresh
            _ = sdk.GetLegalApi().Agreement.RetrieveAgreementsPublicOp
                .Execute()
                .EnsureSuccess();

            sdk.Logout();
        }

        [Test]
        public void ClientLoginWithAutoRefreshToken()
        {
            using var sdk = AccelByteSdk.Builder
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultCredentialRepository()
                .UseOnDemandTokenRefresh()
                .EnableLog()
                .Build();

            sdk.LoginClient();

            //First request, valid token
            _ = sdk.GetAchievementApi().Achievements.PublicListAchievementsOp
                .Execute(sdk.Namespace, "en")
                .EnsureSuccess();

            //force expiry in 5 seconds
            sdk.Configuration.TokenRepository.SetTokenExpiry(5);

            //wait for 5 seconds
            Thread.Sleep(5000);

            //Second request, expired token, try to do refresh
            _ = sdk.GetAchievementApi().Achievements.PublicListAchievementsOp
                .Execute(sdk.Namespace, "en")
                .EnsureSuccess();

            sdk.Logout();
        }

        [Test]
        public void AutoRefreshTokenForWebSocket()
        {
            using var sdk = AccelByteSdk.Builder
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultCredentialRepository()
                .UseOnDemandTokenRefresh()
                .EnableLog()
                .SetOnAfterLoginEventHandler((loginType, authType, tokenData, fSdk) =>
                {
                    // expiry in 5 seconds
                    fSdk.Configuration.TokenRepository.SetTokenExpiry(5);
                })
                .Build();

            sdk.LoginUser();

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
            _ = sdk.GetAchievementApi().Achievements
                .PublicListAchievementsOp
                .Execute(sdk.Namespace, "en")
                .EnsureSuccess();

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
