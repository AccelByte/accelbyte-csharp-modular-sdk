// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Authentication;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Security;

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Core
{
    public static class Auth_SdkExtensions
    {
        public static bool LoginUser(this IAccelByteSdk sdk)
        {
            if (sdk.Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = sdk.Configuration.Credential;
            return sdk.LoginUser(cred.Username, cred.Password, null);
        }

        public static bool LoginUser(this IAccelByteSdk sdk, Action<ITokenResponse>? onTokenReceived)
        {
            if (sdk.Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = sdk.Configuration.Credential;
            return sdk.LoginUser(cred.Username, cred.Password, onTokenReceived);
        }

        public static bool LoginUser(this IAccelByteSdk sdk, string username, string password)
        {
            return sdk.LoginUser(username, password, null);
        }

        public static bool LoginUser(this IAccelByteSdk sdk, string username, string password, Action<ITokenResponse>? onTokenReceived)
        {
            sdk.Configuration.TokenRepository.RemoveToken();
            Random random = new Random();


            var codeVerifier = random.GenerateCodeVerifier();
            var codeChallenge = codeVerifier.GenerateCodeChallenge();
            var clientId = sdk.Configuration.ConfigRepository.ClientId;

            var authorizeV3 = sdk.GetIamApi().OAuth20.AuthorizeV3Op
                .SetCodeChallenge(codeChallenge)
                .SetCodeChallengeMethod(AuthorizeV3CodeChallengeMethod.S256)
                .SetScope("commerce account social publishing analytics")
                .Build(clientId, AuthorizeV3ResponseType.Code);

            var authorizeV3Response = sdk.GetIamApi().OAuth20.AuthorizeV3(authorizeV3);

            var authorizeV3Query = HttpUtility.ParseQueryString(new Uri(authorizeV3Response).Query);
            var requestId = authorizeV3Query[authorizeV3.LocationQuery] ??
                    throw new Exception($"Not getting the expected value from backend (key: {authorizeV3.LocationQuery})"); ;

            var userAuthenticationV3 = sdk.GetIamApi().OAuth20Extension.UserAuthenticationV3Op
                .SetClientId(clientId)
                .Build(password, requestId, username);
            var userAuthenticationResponse = sdk.GetIamApi().OAuth20Extension.UserAuthenticationV3(userAuthenticationV3);

            authorizeV3Query = HttpUtility.ParseQueryString(new Uri(userAuthenticationResponse).Query);
            var code = authorizeV3Query[userAuthenticationV3.LocationQuery] ??
                    throw new Exception($"Not getting the expected value from backend (key: {userAuthenticationV3.LocationQuery})"); ;

            var token = sdk.GetIamApi().OAuth20.TokenGrantV3Op
                .SetClientId(clientId)
                .SetCode(code)
                .SetCodeVerifier(codeVerifier)
                .Execute("authorization_code")
                ?? throw new Exception($"TokenGrantV3 returned null");

            var tokenResponse = new AuthTokenResponse(token);

            sdk.Configuration.TokenRepository.StoreToken(LoginType.User, tokenResponse);
            if ((sdk.Configuration.Credential != null) && (token.UserId != null))
                sdk.Configuration.Credential.UserId = token.UserId;

            onTokenReceived?.Invoke(tokenResponse);
            return true;
        }

        public static bool LoginClient(this IAccelByteSdk sdk)
        {
            return sdk.LoginClient(null);
        }

        public static bool LoginClient(this IAccelByteSdk sdk, Action<ITokenResponse>? onTokenReceived)
        {
            sdk.Configuration.TokenRepository.RemoveToken();

            var token = sdk.GetIamApi().OAuth20.TokenGrantV3Op.Execute("client_credentials")
                ?? throw new Exception($"TokenGrantV3 returned null");
            var tokenResponse = new AuthTokenResponse(token);

            sdk.Configuration.TokenRepository.StoreToken(LoginType.Client, tokenResponse);
            onTokenReceived?.Invoke(tokenResponse);
            return true;
        }

        public static bool LoginPlatform(this IAccelByteSdk sdk, string platformId, string platformToken)
        {
            return sdk.LoginPlatform(platformId, platformToken, null);
        }

        public static bool LoginPlatform(this IAccelByteSdk sdk, string platformId, string platformToken, Action<ITokenResponse>? onTokenReceived)
        {
            sdk.Configuration.TokenRepository.RemoveToken();

            var token = sdk.GetIamApi().OAuth20.PlatformTokenGrantV3Op
                .SetPlatformToken(platformToken)
                .Execute(platformId)
                ?? throw new Exception($"PlatformTokenGrantV3 returned null");
            var tokenResponse = new AuthTokenResponse(token);

            sdk.Configuration.TokenRepository.StoreToken(LoginType.Platform, tokenResponse);
            onTokenReceived?.Invoke(tokenResponse);
            return true;
        }

        public static bool RefreshAccessToken(this IAccelByteSdk sdk, string refreshToken)
        {
            return sdk.RefreshAccessToken(refreshToken, null);
        }

        public static bool RefreshAccessToken(this IAccelByteSdk sdk, string refreshToken, Action<ITokenResponse>? onTokenReceived)
        {
            var token = sdk.GetIamApi().OAuth20.TokenGrantV3Op
                .SetRefreshToken(refreshToken)
                .Execute("refresh_token")
                ?? throw new Exception("TokenGrantV3 for RefreshToken returned null");
            var tokenResponse = new AuthTokenResponse(token);

            sdk.Configuration.TokenRepository.UpdateToken(tokenResponse);
            onTokenReceived?.Invoke(tokenResponse);
            return true;
        }

        public static bool Logout(this IAccelByteSdk sdk)
        {
            sdk.Configuration.TokenRepository.RemoveToken();
            return true;
        }
    }

    public static class Auth_SdkBuilderExtensions
    {
        public static IAccelByteSdkBuilder<T> UseDefaultTokenValidator<T>(IAccelByteSdkBuilder<T> builder)
        {
            return builder.SetTokenValidator(new DefaultTokenValidator());
        }
    }
}
