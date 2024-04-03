// Copyright (c) 2023-2024 AccelByte Inc. All Rights Reserved.
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
        public const string DISABLE_REFRESH_IF_POSSIBLE_FLAGNAME = "disable_refresh_if_possible";

        public const string ON_AFTER_LOGIN_EVENT_KEY = "on_after_login";

        #region User Login

        public static bool LoginUser(this IAccelByteSdk sdk)
        {
            if (sdk.Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = sdk.Configuration.Credential;
            return sdk.LoginUser(cred.Username, cred.Password, "", null);
        }

        public static bool LoginUser(this IAccelByteSdk sdk, Action<ITokenResponse>? onTokenReceived)
        {
            if (sdk.Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = sdk.Configuration.Credential;
            return sdk.LoginUser(cred.Username, cred.Password, "", onTokenReceived);
        }

        public static bool LoginUser(this IAccelByteSdk sdk, string scopes)
        {
            if (sdk.Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = sdk.Configuration.Credential;
            return sdk.LoginUser(cred.Username, cred.Password, scopes, null);
        }

        public static bool LoginUser(this IAccelByteSdk sdk, string scopes, Action<ITokenResponse>? onTokenReceived)
        {
            if (sdk.Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = sdk.Configuration.Credential;
            return sdk.LoginUser(cred.Username, cred.Password, scopes, onTokenReceived);
        }

        public static bool LoginUser(this IAccelByteSdk sdk, string username, string password)
            => sdk.LoginUser(username, password, "", null);

        public static bool LoginUser(this IAccelByteSdk sdk, string username, string password, Action<ITokenResponse>? onTokenReceived)
            => sdk.LoginUser(username, password, "", onTokenReceived);

        public static bool LoginUser(this IAccelByteSdk sdk, string username, string password, string? scopes, Action<ITokenResponse>? onTokenReceived)
        {
            bool disableRefreshIfPossible = false;
            if (sdk.Configuration.Flags.ContainsKey(DISABLE_REFRESH_IF_POSSIBLE_FLAGNAME))
                disableRefreshIfPossible = sdk.Configuration.Flags[DISABLE_REFRESH_IF_POSSIBLE_FLAGNAME];

            var actObj = sdk.Events.GetEventAs<Action<LoginType, AuthActionType, ITokenResponse?, IAccelByteSdk>>(ON_AFTER_LOGIN_EVENT_KEY);

            if ((!disableRefreshIfPossible) && (sdk.Configuration.TokenRepository.TokenData != null))
            {
                if (sdk.Configuration.TokenRepository.IsTokenExpired)
                {
                    bool b = sdk.RefreshAccessToken(sdk.Configuration.TokenRepository.TokenData.RefreshToken, onTokenReceived);
                    actObj?.Invoke(LoginType.User, AuthActionType.TokenRefresh, sdk.Configuration.TokenRepository.TokenData, sdk);
                    return b;
                }
                else
                    return true;
            }
            else
                sdk.Configuration.TokenRepository.RemoveToken();

            Random random = new Random();
            var codeVerifier = random.GenerateCodeVerifier();
            var codeChallenge = codeVerifier.GenerateCodeChallenge();
            var clientId = sdk.Configuration.ConfigRepository.ClientId;

            AuthorizeV3 authorizeV3;
            if (scopes == null)
            {
                authorizeV3 = sdk.GetIamApi().OAuth20.AuthorizeV3Op
                    .SetCodeChallenge(codeChallenge)
                    .SetCodeChallengeMethod(AuthorizeV3CodeChallengeMethod.S256)
                    .Build(clientId, AuthorizeV3ResponseType.Code);
            }
            else if (scopes == "")
            {
                authorizeV3 = sdk.GetIamApi().OAuth20.AuthorizeV3Op
                    .SetCodeChallenge(codeChallenge)
                    .SetCodeChallengeMethod(AuthorizeV3CodeChallengeMethod.S256)
                    .SetScope("commerce account social publishing analytics")
                    .Build(clientId, AuthorizeV3ResponseType.Code);
            }
            else
            {
                authorizeV3 = sdk.GetIamApi().OAuth20.AuthorizeV3Op
                    .SetCodeChallenge(codeChallenge)
                    .SetCodeChallengeMethod(AuthorizeV3CodeChallengeMethod.S256)
                    .SetScope(scopes)
                    .Build(clientId, AuthorizeV3ResponseType.Code);
            }

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
            actObj?.Invoke(LoginType.User, AuthActionType.Login, sdk.Configuration.TokenRepository.TokenData, sdk);
            return true;
        }

        public static async Task<bool> LoginUserAsync(this IAccelByteSdk sdk, string username, string password, string? scopes, Action<ITokenResponse>? onTokenReceived)
        {
            bool disableRefreshIfPossible = false;
            if (sdk.Configuration.Flags.ContainsKey(DISABLE_REFRESH_IF_POSSIBLE_FLAGNAME))
                disableRefreshIfPossible = sdk.Configuration.Flags[DISABLE_REFRESH_IF_POSSIBLE_FLAGNAME];

            var actObj = sdk.Events.GetEventAs<Action<LoginType, AuthActionType, ITokenResponse?, IAccelByteSdk>>(ON_AFTER_LOGIN_EVENT_KEY);

            if ((!disableRefreshIfPossible) && (sdk.Configuration.TokenRepository.TokenData != null))
            {
                if (sdk.Configuration.TokenRepository.IsTokenExpired)
                {
                    bool b = await sdk.RefreshAccessTokenAsync(sdk.Configuration.TokenRepository.TokenData.RefreshToken, onTokenReceived);
                    actObj?.Invoke(LoginType.User, AuthActionType.TokenRefresh, sdk.Configuration.TokenRepository.TokenData, sdk);
                    return b;
                }
                else
                    return true;
            }
            else
                sdk.Configuration.TokenRepository.RemoveToken();

            Random random = new Random();
            var codeVerifier = random.GenerateCodeVerifier();
            var codeChallenge = codeVerifier.GenerateCodeChallenge();
            var clientId = sdk.Configuration.ConfigRepository.ClientId;

            AuthorizeV3 authorizeV3;
            if (scopes == null)
            {
                authorizeV3 = sdk.GetIamApi().OAuth20.AuthorizeV3Op
                    .SetCodeChallenge(codeChallenge)
                    .SetCodeChallengeMethod(AuthorizeV3CodeChallengeMethod.S256)
                    .Build(clientId, AuthorizeV3ResponseType.Code);
            }
            else if (scopes == "")
            {
                authorizeV3 = sdk.GetIamApi().OAuth20.AuthorizeV3Op
                    .SetCodeChallenge(codeChallenge)
                    .SetCodeChallengeMethod(AuthorizeV3CodeChallengeMethod.S256)
                    .SetScope("commerce account social publishing analytics")
                    .Build(clientId, AuthorizeV3ResponseType.Code);
            }
            else
            {
                authorizeV3 = sdk.GetIamApi().OAuth20.AuthorizeV3Op
                    .SetCodeChallenge(codeChallenge)
                    .SetCodeChallengeMethod(AuthorizeV3CodeChallengeMethod.S256)
                    .SetScope(scopes)
                    .Build(clientId, AuthorizeV3ResponseType.Code);
            }

            var authorizeV3Response = await sdk.GetIamApi().OAuth20.AuthorizeV3Async(authorizeV3);

            var authorizeV3Query = HttpUtility.ParseQueryString(new Uri(authorizeV3Response).Query);
            var requestId = authorizeV3Query[authorizeV3.LocationQuery] ??
                    throw new Exception($"Not getting the expected value from backend (key: {authorizeV3.LocationQuery})"); ;

            var userAuthenticationV3 = sdk.GetIamApi().OAuth20Extension.UserAuthenticationV3Op
                .SetClientId(clientId)
                .Build(password, requestId, username);
            var userAuthenticationResponse = await sdk.GetIamApi().OAuth20Extension.UserAuthenticationV3Async(userAuthenticationV3);

            authorizeV3Query = HttpUtility.ParseQueryString(new Uri(userAuthenticationResponse).Query);
            var code = authorizeV3Query[userAuthenticationV3.LocationQuery] ??
                    throw new Exception($"Not getting the expected value from backend (key: {userAuthenticationV3.LocationQuery})"); ;

            var token = await sdk.GetIamApi().OAuth20.TokenGrantV3Op
                .SetClientId(clientId)
                .SetCode(code)
                .SetCodeVerifier(codeVerifier)
                .ExecuteAsync("authorization_code")
                ?? throw new Exception($"TokenGrantV3 returned null");

            var tokenResponse = new AuthTokenResponse(token);

            sdk.Configuration.TokenRepository.StoreToken(LoginType.User, tokenResponse);
            if ((sdk.Configuration.Credential != null) && (token.UserId != null))
                sdk.Configuration.Credential.UserId = token.UserId;

            onTokenReceived?.Invoke(tokenResponse);
            actObj?.Invoke(LoginType.User, AuthActionType.Login, sdk.Configuration.TokenRepository.TokenData, sdk);
            return true;
        }

        public static async Task<bool> LoginUserAsync(this IAccelByteSdk sdk, string username, string password, Action<ITokenResponse>? onTokenReceived)
            => await sdk.LoginUserAsync(username, password, "", onTokenReceived);

        public static async Task<bool> LoginUserAsync(this IAccelByteSdk sdk, string username, string password)
            => await sdk.LoginUserAsync(username, password, "", null);

        public static async Task<bool> LoginUserAsync(this IAccelByteSdk sdk)
        {
            if (sdk.Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = sdk.Configuration.Credential;
            return await sdk.LoginUserAsync(cred.Username, cred.Password, "", null);
        }

        public static async Task<bool> LoginUserAsync(this IAccelByteSdk sdk, Action<ITokenResponse>? onTokenReceived)
        {
            if (sdk.Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = sdk.Configuration.Credential;
            return await sdk.LoginUserAsync(cred.Username, cred.Password, "", onTokenReceived);
        }

        public static async Task<bool> LoginUserAsync(this IAccelByteSdk sdk, string scopes)
        {
            if (sdk.Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = sdk.Configuration.Credential;
            return await sdk.LoginUserAsync(cred.Username, cred.Password, scopes, null);
        }

        public static async Task<bool> LoginUserAsync(this IAccelByteSdk sdk, string scopes, Action<ITokenResponse>? onTokenReceived)
        {
            if (sdk.Configuration.Credential == null)
                throw new Exception("Null credential repository");

            ICredentialRepository cred = sdk.Configuration.Credential;
            return await sdk.LoginUserAsync(cred.Username, cred.Password, scopes, onTokenReceived);
        }

        #endregion

        #region Client Login        

        public static bool LoginClient(this IAccelByteSdk sdk, Action<ITokenResponse>? onTokenReceived)
        {
            bool disableRefreshIfPossible = false;
            if (sdk.Configuration.Flags.ContainsKey(DISABLE_REFRESH_IF_POSSIBLE_FLAGNAME))
                disableRefreshIfPossible = sdk.Configuration.Flags[DISABLE_REFRESH_IF_POSSIBLE_FLAGNAME];

            var actObj = sdk.Events.GetEventAs<Action<LoginType, AuthActionType, ITokenResponse?, IAccelByteSdk>>(ON_AFTER_LOGIN_EVENT_KEY);

            if ((!disableRefreshIfPossible) && (sdk.Configuration.TokenRepository.TokenData != null))
            {
                if (!sdk.Configuration.TokenRepository.IsTokenExpired)
                    return true;
            }
            else
                sdk.Configuration.TokenRepository.RemoveToken();

            var token = sdk.GetIamApi().OAuth20.TokenGrantV3Op.Execute("client_credentials")
                ?? throw new Exception($"TokenGrantV3 returned null");
            var tokenResponse = new AuthTokenResponse(token);

            sdk.Configuration.TokenRepository.StoreToken(LoginType.Client, tokenResponse);
            onTokenReceived?.Invoke(tokenResponse);
            actObj?.Invoke(LoginType.Client, AuthActionType.Login, sdk.Configuration.TokenRepository.TokenData, sdk);
            return true;
        }

        public static bool LoginClient(this IAccelByteSdk sdk)
            => sdk.LoginClient(null);

        public static async Task<bool> LoginClientAsync(this IAccelByteSdk sdk, Action<ITokenResponse>? onTokenReceived)
        {
            bool disableRefreshIfPossible = false;
            if (sdk.Configuration.Flags.ContainsKey(DISABLE_REFRESH_IF_POSSIBLE_FLAGNAME))
                disableRefreshIfPossible = sdk.Configuration.Flags[DISABLE_REFRESH_IF_POSSIBLE_FLAGNAME];

            var actObj = sdk.Events.GetEventAs<Action<LoginType, AuthActionType, ITokenResponse?, IAccelByteSdk>>(ON_AFTER_LOGIN_EVENT_KEY);

            if ((!disableRefreshIfPossible) && (sdk.Configuration.TokenRepository.TokenData != null))
            {
                if (!sdk.Configuration.TokenRepository.IsTokenExpired)
                    return true;
            }
            else
                sdk.Configuration.TokenRepository.RemoveToken();

            var token = await sdk.GetIamApi().OAuth20.TokenGrantV3Op
                .ExecuteAsync("client_credentials")
                ?? throw new Exception($"TokenGrantV3 returned null");
            var tokenResponse = new AuthTokenResponse(token);

            sdk.Configuration.TokenRepository.StoreToken(LoginType.Client, tokenResponse);
            onTokenReceived?.Invoke(tokenResponse);
            actObj?.Invoke(LoginType.Client, AuthActionType.Login, sdk.Configuration.TokenRepository.TokenData, sdk);
            return true;
        }

        public static async Task<bool> LoginClientAsync(this IAccelByteSdk sdk)
            => await sdk.LoginClientAsync(null);

        #endregion

        #region Platform Login

        public static bool LoginPlatform(this IAccelByteSdk sdk, string platformId, string platformToken, Action<ITokenResponse>? onTokenReceived)
        {
            bool disableRefreshIfPossible = false;
            if (sdk.Configuration.Flags.ContainsKey(DISABLE_REFRESH_IF_POSSIBLE_FLAGNAME))
                disableRefreshIfPossible = sdk.Configuration.Flags[DISABLE_REFRESH_IF_POSSIBLE_FLAGNAME];

            var actObj = sdk.Events.GetEventAs<Action<LoginType, AuthActionType, ITokenResponse?, IAccelByteSdk>>(ON_AFTER_LOGIN_EVENT_KEY);

            if ((!disableRefreshIfPossible) && (sdk.Configuration.TokenRepository.TokenData != null))
            {
                if (sdk.Configuration.TokenRepository.IsTokenExpired)
                {
                    bool b = sdk.RefreshAccessToken(sdk.Configuration.TokenRepository.TokenData.RefreshToken, onTokenReceived);
                    actObj?.Invoke(LoginType.Platform, AuthActionType.TokenRefresh, sdk.Configuration.TokenRepository.TokenData, sdk);
                    return b;
                }
                else
                    return true;
            }
            else
                sdk.Configuration.TokenRepository.RemoveToken();

            var token = sdk.GetIamApi().OAuth20.PlatformTokenGrantV3Op
                .SetPlatformToken(platformToken)
                .Execute(platformId)
                ?? throw new Exception($"PlatformTokenGrantV3 returned null");
            var tokenResponse = new AuthTokenResponse(token);

            sdk.Configuration.TokenRepository.StoreToken(LoginType.Platform, tokenResponse);
            onTokenReceived?.Invoke(tokenResponse);
            actObj?.Invoke(LoginType.Platform, AuthActionType.Login, sdk.Configuration.TokenRepository.TokenData, sdk);
            return true;
        }

        public static bool LoginPlatform(this IAccelByteSdk sdk, string platformId, string platformToken)
            => sdk.LoginPlatform(platformId, platformToken, null);

        public static async Task<bool> LoginPlatformAsync(this IAccelByteSdk sdk, string platformId, string platformToken, Action<ITokenResponse>? onTokenReceived)
        {
            bool disableRefreshIfPossible = false;
            if (sdk.Configuration.Flags.ContainsKey(DISABLE_REFRESH_IF_POSSIBLE_FLAGNAME))
                disableRefreshIfPossible = sdk.Configuration.Flags[DISABLE_REFRESH_IF_POSSIBLE_FLAGNAME];

            var actObj = sdk.Events.GetEventAs<Action<LoginType, AuthActionType, ITokenResponse?, IAccelByteSdk>>(ON_AFTER_LOGIN_EVENT_KEY);

            if ((!disableRefreshIfPossible) && (sdk.Configuration.TokenRepository.TokenData != null))
            {
                if (sdk.Configuration.TokenRepository.IsTokenExpired)
                {
                    bool b = await sdk.RefreshAccessTokenAsync(sdk.Configuration.TokenRepository.TokenData.RefreshToken, onTokenReceived);
                    actObj?.Invoke(LoginType.Platform, AuthActionType.TokenRefresh, sdk.Configuration.TokenRepository.TokenData, sdk);
                    return b;
                }
                else
                    return true;
            }
            else
                sdk.Configuration.TokenRepository.RemoveToken();

            var token = await sdk.GetIamApi().OAuth20.PlatformTokenGrantV3Op
                .SetPlatformToken(platformToken)
                .ExecuteAsync(platformId)
                ?? throw new Exception($"PlatformTokenGrantV3 returned null");
            var tokenResponse = new AuthTokenResponse(token);

            sdk.Configuration.TokenRepository.StoreToken(LoginType.Platform, tokenResponse);
            onTokenReceived?.Invoke(tokenResponse);
            actObj?.Invoke(LoginType.Platform, AuthActionType.Login, sdk.Configuration.TokenRepository.TokenData, sdk);
            return true;
        }

        public static async Task<bool> LoginPlatformAsync(this IAccelByteSdk sdk, string platformId, string platformToken)
            => await sdk.LoginPlatformAsync(platformId, platformToken, null);

        #endregion

        #region Access Token Refresh

        public static bool RefreshAccessToken(this IAccelByteSdk sdk, string refreshToken, Action<ITokenResponse>? onTokenReceived)
        {
            var token = sdk.GetIamApi().OAuth20.TokenGrantV3Op
                .SetRefreshToken(refreshToken)
                .Execute("refresh_token")
                ?? throw new Exception("TokenGrantV3 for RefreshToken returned null");
            var tokenResponse = new AuthTokenResponse(token);

            sdk.Configuration.TokenRepository.UpdateToken(tokenResponse);
            onTokenReceived?.Invoke(tokenResponse);

            if (sdk.Configuration.TokenRepository is IObservableTokenRepository)
            {
                var oTokenRepo = (IObservableTokenRepository)sdk.Configuration.TokenRepository;
                _ = oTokenRepo.UpdateObserversWithNewToken();
            }

            return true;
        }

        public static bool RefreshAccessToken(this IAccelByteSdk sdk, string refreshToken)
            => sdk.RefreshAccessToken(refreshToken, null);

        public static async Task<bool> RefreshAccessTokenAsync(this IAccelByteSdk sdk, string refreshToken, Action<ITokenResponse>? onTokenReceived)
        {
            var token = await sdk.GetIamApi().OAuth20.TokenGrantV3Op
                .SetRefreshToken(refreshToken)
                .ExecuteAsync("refresh_token")
                ?? throw new Exception("TokenGrantV3 for RefreshToken returned null");
            var tokenResponse = new AuthTokenResponse(token);

            sdk.Configuration.TokenRepository.UpdateToken(tokenResponse);
            onTokenReceived?.Invoke(tokenResponse);

            if (sdk.Configuration.TokenRepository is IObservableTokenRepository)
            {
                var oTokenRepo = (IObservableTokenRepository)sdk.Configuration.TokenRepository;
                await oTokenRepo.UpdateObserversWithNewToken();
            }

            return true;
        }

        public static async Task<bool> RefreshAccessTokenAsync(this IAccelByteSdk sdk, string refreshToken)
            => await sdk.RefreshAccessTokenAsync(refreshToken, null);

        #endregion

        public static bool Logout(this IAccelByteSdk sdk)
        {
            sdk.Configuration.TokenRepository.RemoveToken();
            return true;
        }
    }

    public static class Auth_SdkBuilderExtensions
    {
        public static IAccelByteSdkBuilder<T> UseDefaultTokenValidator<T>(this IAccelByteSdkBuilder<T> builder)
        {
            return builder.SetTokenValidator(new DefaultTokenValidator());
        }

        public static IAccelByteSdkBuilder<T> DisableRefreshIfPossible<T>(this IAccelByteSdkBuilder<T> builder)
        {
            return builder.SetFlag(Auth_SdkExtensions.DISABLE_REFRESH_IF_POSSIBLE_FLAGNAME, true);
        }

        public static IAccelByteSdkBuilder<T> EnableRefreshIfPossible<T>(this IAccelByteSdkBuilder<T> builder)
        {
            return builder.SetFlag(Auth_SdkExtensions.DISABLE_REFRESH_IF_POSSIBLE_FLAGNAME, false);
        }

        public static IAccelByteSdkBuilder<T> SetOnAfterLoginEventHandler<T>(this IAccelByteSdkBuilder<T> builder, Action<LoginType, AuthActionType, ITokenResponse?, IAccelByteSdk> eventAction)
        {
            builder.RegisterEvent(Auth_SdkExtensions.ON_AFTER_LOGIN_EVENT_KEY, eventAction);
            return builder;
        }
    }
}
