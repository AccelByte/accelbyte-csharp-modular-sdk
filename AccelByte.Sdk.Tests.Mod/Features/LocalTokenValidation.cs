// Copyright (c) 2023-2025 AccelByte Inc. All Rights Reserved.
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
using AccelByte.Sdk.Tests.Mod.Repository;
using AccelByte.Sdk.Feature.LocalTokenValidation;
using AccelByte.Sdk.Tests.Mod.Scenario;

namespace AccelByte.Sdk.Tests.Mod.Features
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class LocalTokenValidation : BaseIntegrationTest
    {
        [Test]
        public void TokenValidationTest()
        {
            using IAccelByteSdk sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .UseLocalTokenValidator()
                .UseAutoRefreshForTokenRevocationList(2000) //refresh revocation every 2s
                .EnableLog()
                .Build();

            string accessToken = "";
            sdk.LoginClient((tokenResp) =>
            {
                accessToken = tokenResp.AccessToken!;
            });

            Thread.Sleep(2000);

            bool b = sdk.ValidateToken(accessToken);
            Assert.IsTrue(b);

            sdk.GetIamApi().OAuth20.TokenRevocationV3Op.Execute(accessToken);
            Thread.Sleep(3000);

            b = sdk.ValidateToken(accessToken);
            Assert.IsFalse(b);
        }

        [Test]
        public void PermissionValidationTest()
        {
            using IAccelByteSdk sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .UseLocalTokenValidator()
                .UseAutoRefreshForTokenRevocationList()
                .EnableLog()
                .Build();

            string accessToken = "";
            sdk.LoginClient((tokenResp) =>
            {
                accessToken = tokenResp.AccessToken!;
            });

            string tPermission = $"NAMESPACE:{sdk.Namespace}:PROFILE";
            int tAction = 15;

            bool b = sdk.ValidateToken(accessToken, tPermission, tAction);
            Assert.IsTrue(b);
        }

        [Test]
        public void UserPermissionValidationTest()
        {
            //first sdk object is for oauth client which has ADMIN:ROLE [READ] permission, since we will assume that default user doesn't have this permission.
            using IAccelByteSdk sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .UseLocalTokenValidator()
                .UseAutoRefreshForTokenRevocationList()
                .EnableLog()
                .Build();
            sdk.LoginClient();

            //we will access user using different sdk object wrapped inside `ExistingTestPlayer` object.
            var user = new ExistingTestPlayer("AB", true);

            string tPermission = $"NAMESPACE:{sdk.Namespace}:PROFILE";
            int tAction = 2;

            //validate user's token against expected permission.
            bool b = sdk.ValidateToken(user.AccessToken, tPermission, tAction);
            Assert.IsTrue(b);

            user.Logout();
        }

        [Test]
        public void ParseAccessTokenNoValidationTest()
        {
            using IAccelByteSdk sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .EnableLog()
                .Build();

            string accessToken = "";
            sdk.LoginClient((tokenResp) =>
            {
                accessToken = tokenResp.AccessToken!;
            });

            AccessTokenPayload? payload = sdk.ParseAccessToken(accessToken, false);
            Assert.IsNotNull(payload);
            if (payload != null)
            {
                Assert.AreEqual(sdk.Namespace, payload.Namespace);
                Assert.AreEqual(sdk.Configuration.ConfigRepository.ClientId, payload.ClientId);
            }
        }
    }
}
