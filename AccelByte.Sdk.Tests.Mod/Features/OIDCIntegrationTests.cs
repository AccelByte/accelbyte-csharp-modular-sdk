// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Core.Repository;

using AccelByte.Sdk.Tests.Mod.Model;

namespace AccelByte.Sdk.Tests.Mod.Features
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class OIDCIntegrationTests : BaseIntegrationTest
    {
        private IAccelByteSdk? _Sdk = null;

        private string _PhantauthBaseUrl = "https://phantauth.net";

        [OneTimeSetUp]
        public void Startup()
        {
            _Sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .UseDefaultConfigRepository()
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .EnableLog()
                .Build();

            _PhantauthBaseUrl = Environment.GetEnvironmentVariable("AB_PHANTAUTH_BASE_URL")
                ?? "https://phantauth.net";
        }

        [OneTimeTearDown]
        public void End()
        {
            _Sdk?.Logout();
        }

        protected string GetPhantauthToken(string username, string tokenType)
        {
            string url = $"{_PhantauthBaseUrl}/user/{username.Trim()}/token/{tokenType.Trim().ToLower()}";

            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, url);
            if (DefaultHttpClient.Http == null)
                return String.Empty;

            HttpResponseMessage response = DefaultHttpClient.Http.Send(req);
            return response.Content.ReadAsStream().ReadToString();
        }

        protected PhantauthTokens GetPhantauthAuthorizedToken(string clientId, string clientSecret, string authorizationToken)
        {
            string url = $"{_PhantauthBaseUrl}/auth/token";

            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, url);
            req.Content = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                {"grant_type", "authorization_code" },
                {"client_id", clientId },
                {"client_secret", clientSecret },
                {"redirect_uri", "http://localhost" },
                {"code", authorizationToken }
            });

            HttpResponseMessage response = DefaultHttpClient.Http.Send(req);
            string jsonString = response.Content.ReadAsStream().ReadToString();

            return JsonSerializer.Deserialize<PhantauthTokens>(jsonString)!;
        }

        [Test]
        public void PhantauthOIDCPlatformLoginTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter(_Sdk))
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            string platformId = "phantauth";
            string clientId = "test.client";
            string clientSecret = "UTBcWwt5";

            string authzToken = GetPhantauthToken("test.serversdk1", "authorization");
            PhantauthTokens pTokens = GetPhantauthAuthorizedToken(clientId, clientSecret, authzToken);

            bool isSuccess = _Sdk.LoginPlatform(platformId, pTokens.ID);
            Assert.IsTrue(isSuccess);
        }
    }
}
