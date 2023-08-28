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
using AccelByte.Sdk.Tests.Mod.Repository;
using AccelByte.Sdk.Feature.LocalTokenValidation;

namespace AccelByte.Sdk.Tests.Mod.Features
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class LocalTokenValidation
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

            string accessToken = String.Empty;
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

            string accessToken = String.Empty;
            sdk.LoginClient((tokenResp) =>
            {
                accessToken = tokenResp.AccessToken!;
            });

            Thread.Sleep(2000);

            string tPermission = $"NAMESPACE:{sdk.Namespace}:PROFILE";
            int tAction = 15;

            bool b = sdk.ValidateToken(accessToken, tPermission, tAction);
            Assert.IsTrue(b);
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

            string accessToken = String.Empty;
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
