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

namespace AccelByte.Sdk.Tests.Mod.Features
{
    [TestFixture(Category = "RefreshTokenIntegration")]
    [Explicit]
    public class TokenRefreshTests
    {
        [Test]
        public void AutoRefreshTokenForWebSocket()
        {
            IAccelByteSdk sdk = AccelByteSdk.Builder
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
