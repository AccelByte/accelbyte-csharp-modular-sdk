// Copyright (c) 2024-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Authentication;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Tests.Mod.Repository;
using AccelByte.Sdk.Tests.Mod.Scenario;
using AccelByte.Sdk.Core.Security;

namespace AccelByte.Sdk.Tests.Mod.Features
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class DefaultTokenValidation : BaseIntegrationTest
    {
        private ITestPlayer _SimulateAdminPortalLogin(ICredentialRepository credRepo)
        {
            var user = new RepoTestPlayer(IntegrationTestConfigRepository.AdminPortalLogin, credRepo, false);
            user.Run((sdk, player) =>
            {
                Random random = new Random();

                string codeVerifier = random.GenerateCodeVerifier();
                string codeChallenge = codeVerifier.GenerateCodeChallenge();
                string clientId = sdk.Configuration.ConfigRepository.ClientId;
                string csrf = Guid.NewGuid().ToString().Replace("-", "");
                string redirectUri = $"{sdk.Configuration.ConfigRepository.BaseUrl}/admin";

                var authorizeResponse = sdk.GetIamApi().OAuth20.AuthorizeV3Op
                    .SetRedirectUri(redirectUri)
                    .SetState(csrf)
                    .SetCodeChallenge(codeChallenge)
                    .SetCodeChallengeMethod("S256")
                    .Execute(clientId, "code")
                    .EnsureSuccess();

                var authorizeV3Query = HttpUtility.ParseQueryString(new Uri(authorizeResponse).Query);
                var requestId = authorizeV3Query["request_id"] ??
                    throw new Exception("AuthorizeV3: Not getting the expected value from backend (key: request_id)");

                var loginResponse = sdk.GetIamApi().OAuth20Extension.UserAuthenticationV3Op
                    .SetRedirectUri(redirectUri)
                    .SetClientId(clientId)
                    .Execute(credRepo.Password, requestId, credRepo.Username)
                    .EnsureSuccess();

                var loginV3Query = HttpUtility.ParseQueryString(new Uri(loginResponse).Query);
                var code = loginV3Query["code"] ??
                    throw new Exception("UserAuthenticationV3: Not getting the expected value from backend (key: code)");
                var state = loginV3Query["state"] ??
                    throw new Exception("UserAuthenticationV3: Not getting the expected value from backend (key: state)");
                if (state != csrf)
                    throw new Exception("State is different from initial CSRF value.");

                var resultToken = sdk.GetIamApi().OAuth20.TokenGrantV3Op
                    .SetRedirectUri(redirectUri)
                    .SetClientId(clientId)
                    .SetCode(code)
                    .SetCodeVerifier(codeVerifier)
                    .Execute("authorization_code")
                    .EnsureSuccess();

                //login succeed
                var tokenResponse = new AuthTokenResponse(resultToken);
                sdk.Configuration.TokenRepository.StoreToken(LoginType.User, tokenResponse);
            });
            return user;
        }

        [Test]
        public void TokenValidationTest()
        {
            using IAccelByteSdk sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .UseDefaultTokenValidator()
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
                .SetConfigRepository(IntegrationTestConfigRepository.Basic)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .UseDefaultTokenValidator()
                .Build();

            string accessToken = "";
            sdk.LoginClient((tokenResp) =>
            {
                accessToken = tokenResp.AccessToken!;
            });

            string tPermission = $"ADMIN:NAMESPACE:{sdk.Namespace}:PROFILE";
            int tAction = 2;

            bool b = sdk.ValidateToken(accessToken, tPermission, tAction);
            Assert.IsTrue(b);
        }

        [Test]
        public void UserPermissionValidationTest()
        {
            //first sdk object is for oauth client which has ADMIN:ROLE [READ] permission, since we will assume that default user doesn't have this permission.
            using IAccelByteSdk sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Basic)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .UseDefaultTokenValidator()
                .Build();
            sdk.LoginClient();

            //we will access user using different sdk object wrapped inside `ExistingTestPlayer` object.
            var user = new ExistingTestPlayer("AB", true);

            string tPermission = $"ADMIN:NAMESPACE:{sdk.Namespace}:USER";
            int tAction = 2;

            //validate user's token against expected permission.
            bool b = sdk.ValidateToken(user.AccessToken, tPermission, tAction);
            Assert.IsTrue(b);

            user.Logout();
        }

        [Test]
        public void CustomPermissionValidationTestUsingDefaultValidator()
        {
            using IAccelByteSdk sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.CustomPermission)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .UseDefaultTokenValidator()
                .Build();

            string accessToken = "";
            sdk.LoginClient((tokenResp) =>
            {
                accessToken = tokenResp.AccessToken!;
            });

            string tPermission = $"CUSTOM:ADMIN:NAMESPACE:{sdk.Namespace}:GUILD";
            int tAction = 2;

            bool b = sdk.ValidateToken(accessToken, tPermission, tAction);
            Assert.IsTrue(b);
        }

        [Test]
        public void UserCustomPermissionValidationTestUsingDefaultValidator()
        {
            //first sdk object is for oauth client which has ADMIN:ROLE [READ] permission, since we will assume that default user doesn't have this permission.
            using IAccelByteSdk sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .UseDefaultTokenValidator()
                .Build();
            sdk.LoginClient();

            //we will access user using different sdk object wrapped inside `ExistingTestPlayer` object.
            var user = new ExistingTestPlayer("AB_PLAYER1", true);

            string tPermission = $"CUSTOM:NAMESPACE:{sdk.Namespace}:GUILD";
            int tAction = 2;

            //validate user's token against expected permission.
            bool b = sdk.ValidateToken(user.AccessToken, tPermission, tAction);
            Assert.IsTrue(b);

            user.Logout();
        }

        /// <summary>
        /// To test "IsResourceAllowed" function in TokenValidator class.
        /// </summary>
        [Test]
        public void StaticTestTokenValidation()
        {
            StaticTestTokenValidator validator = new StaticTestTokenValidator("game1", "studio1", "foundations");

            List<LocalPermissionItem> availablePermissions = new List<LocalPermissionItem>();
            availablePermissions.Add(new LocalPermissionItem()
            {
                Resource = "NAMESPACE:{namespace}:PROFILE",
                Action = 15
            });
            string targetPermission = "NAMESPACE:studio1-game1:PROFILE";

            var testWithGameNs = validator.TestValidateResource(availablePermissions, "studio1-game1", targetPermission);
            Assert.IsTrue(testWithGameNs);

            var testWithStudioNs = validator.TestValidateResource(availablePermissions, "studio1-", targetPermission);
            Assert.IsTrue(testWithStudioNs);

            var testWithDifferentGameNs = validator.TestValidateResource(availablePermissions, "studio1-game2", targetPermission);
            Assert.IsFalse(testWithDifferentGameNs);

            var testWithDifferentStudio = validator.TestValidateResource(availablePermissions, "studio2-", targetPermission);
            Assert.IsFalse(testWithDifferentStudio);
        }

        [Test]
        public void UserTokenValidationFromParentNamespaceUsingDefaultValidator()
        {
            //first sdk object is for oauth client which has ADMIN:ROLE [READ] permission, since we will assume that default user doesn't have this permission.
            using IAccelByteSdk sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .UseDefaultTokenValidator()
                .Build();
            sdk.LoginClient();

            var user = _SimulateAdminPortalLogin(IntegrationTestCredentialRepository.StudioAdmin);

            string tPermission = $"NAMESPACE:{sdk.Namespace}:PROFILE";
            int tAction = 2;

            //validate user's token against expected permission.
            bool b = sdk.ValidateToken(user.AccessToken, tPermission, tAction);
            Assert.IsTrue(b);

            user.Logout();
        }

        [Test]
        public void UserTokenValidationFromDifferentStudioUsingDefaultValidator()
        {
            if (!IsUsingAGSStarter(IntegrationTestConfigRepository.Admin))
                Assert.Inconclusive("This test currently available for AGS Shared Cloud only");

            //first sdk object is for oauth client which has ADMIN:ROLE [READ] permission, since we will assume that default user doesn't have this permission.
            using IAccelByteSdk sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.DifferentStudio)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .UseDefaultTokenValidator()
                .Build();
            sdk.LoginClient();

            var user = _SimulateAdminPortalLogin(IntegrationTestCredentialRepository.StudioAdmin);

            string tPermission = $"NAMESPACE:{sdk.Namespace}:PROFILE";
            int tAction = 2;

            //validate user's token against expected permission.
            bool b = sdk.ValidateToken(user.AccessToken, tPermission, tAction);

            //Token should invalid because it is not intended for sdk's namespace.
            Assert.IsFalse(b);

            user.Logout();
        }
    }
}
