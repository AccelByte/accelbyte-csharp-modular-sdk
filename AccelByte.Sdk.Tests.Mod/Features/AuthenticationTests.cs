// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
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
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Authentication;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Tests.Mod.Features
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class AuthenticationTests
    {

        [Test]
        public void OnDemandRefreshTokenTestForUser()
        {
            int loginCounter = 0;
            int refreshCounter = 0;

            DefaultTokenRepository tokenRepo = new DefaultTokenRepository();
            using IAccelByteSdk sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .UseDefaultConfigRepository()
                .SetTokenRepository(tokenRepo)
                .UseDefaultCredentialRepository()
                .SetOnAfterLoginEventHandler((loginType, authAction, token, sdk) =>
                {
                    tokenRepo.SetTokenExpiry(1); //set to 1s expiry for fast test execution
                    if (authAction == AuthActionType.Login)
                        loginCounter++;
                    else if (authAction == AuthActionType.TokenRefresh)
                        refreshCounter++;
                })
                .Build();

            int loopCounter = 0;
            int maxLoop = 10;
            while (loopCounter < maxLoop)
            {
                if (!sdk.LoginUser())
                    throw new Exception("Login failed");

                _ = sdk.GetLegalApi()
                    .Agreement.RetrieveAgreementsPublicOp.Execute()
                    .Ok();

                loopCounter++;

                //sleep for 200ms to make sure the token is expired
                Thread.Sleep(200);
            }

            sdk.Logout();

            //Make sure that actual login executed only once.
            Assert.AreEqual(loginCounter, 1);

            //Make sure at least one refresh token is executed. More is not an issue.
            Assert.GreaterOrEqual(refreshCounter, 1);
        }

        [Test]
        public void OnDemandLoginClientTest()
        {
            int loginCounter = 0;

            DefaultTokenRepository tokenRepo = new DefaultTokenRepository();
            using IAccelByteSdk sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .UseDefaultConfigRepository()
                .SetTokenRepository(tokenRepo)
                .UseDefaultCredentialRepository()
                .SetOnAfterLoginEventHandler((loginType, authAction, token, sdk) =>
                {
                    tokenRepo.SetTokenExpiry(2); //set to 1s expiry for fast test execution
                    loginCounter++;
                })
                .Build();

            int loopCounter = 0;
            int maxLoop = 10;
            while (loopCounter < maxLoop)
            {
                if (!sdk.LoginClient())
                    throw new Exception("Login failed");

                _ = sdk.GetAchievementApi()
                    .GlobalAchievements.PublicListGlobalAchievementsOp
                    .Execute(sdk.Namespace)
                    .Ok();

                loopCounter++;

                //sleep for 200ms to make sure the token is expired
                Thread.Sleep(200);
            }

            sdk.Logout();

            //Make sure that number of login execution is less than login method call.
            Assert.Less(loginCounter, maxLoop);
        }


    }
}
