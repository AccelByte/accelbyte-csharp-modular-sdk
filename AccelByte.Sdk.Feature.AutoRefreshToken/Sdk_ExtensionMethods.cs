// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Feature.AutoTokenRefresh
{
    public static class Sdk_ExtensionMethods
    {
        public static bool LoginUser(this IAccelByteSdk sdk, string username, string password, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return sdk.LoginUser(username, password, (token) =>
            {
                if (autoRefresh)
                {
                    if (sdk.Configuration.Credential == null)
                        sdk.Configuration.Credential = new DefaultCredentialRepository();

                    ICredentialRepository credentialRepo = sdk.Configuration.Credential;
                    if (credentialRepo is IResettableCredentialRepository)
                    {
                        ((IResettableCredentialRepository)credentialRepo).Username = username;
                        ((IResettableCredentialRepository)credentialRepo).Password = password;
                    }

                    ITokenRepository tokenRepo = sdk.Configuration.TokenRepository;
                    if (tokenRepo is IRefreshTokenRepository)
                    {
                        IRefreshTokenRepository refreshTokenRepo = (IRefreshTokenRepository)tokenRepo;
                        refreshTokenRepo.RefreshTokenEnabled = true;
                        refreshTokenRepo.StoreRefreshToken(token.RefreshToken!, refreshThreshold);
                    }
                }
            });
        }

        public static bool LoginUser(this IAccelByteSdk sdk, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return sdk.LoginUser((token) =>
            {
                if (autoRefresh)
                {
                    ITokenRepository tokenRepo = sdk.Configuration.TokenRepository;
                    if (tokenRepo is IRefreshTokenRepository)
                    {
                        IRefreshTokenRepository refreshTokenRepo = (IRefreshTokenRepository)tokenRepo;
                        refreshTokenRepo.RefreshTokenEnabled = true;
                        refreshTokenRepo.StoreRefreshToken(token.RefreshToken!, refreshThreshold);
                    }
                }
            });
        }

        public static async Task<bool> LoginUserAsync(this IAccelByteSdk sdk, string username, string password, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return await sdk.LoginUserAsync(username, password, (token) =>
            {
                if (autoRefresh)
                {
                    if (sdk.Configuration.Credential == null)
                        sdk.Configuration.Credential = new DefaultCredentialRepository();

                    ICredentialRepository credentialRepo = sdk.Configuration.Credential;
                    if (credentialRepo is IResettableCredentialRepository)
                    {
                        ((IResettableCredentialRepository)credentialRepo).Username = username;
                        ((IResettableCredentialRepository)credentialRepo).Password = password;
                    }

                    ITokenRepository tokenRepo = sdk.Configuration.TokenRepository;
                    if (tokenRepo is IRefreshTokenRepository)
                    {
                        IRefreshTokenRepository refreshTokenRepo = (IRefreshTokenRepository)tokenRepo;
                        refreshTokenRepo.RefreshTokenEnabled = true;
                        refreshTokenRepo.StoreRefreshToken(token.RefreshToken!, refreshThreshold);
                    }
                }
            });
        }

        public static async Task<bool> LoginUserAsync(this IAccelByteSdk sdk, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return await sdk.LoginUserAsync((token) =>
            {
                if (autoRefresh)
                {
                    ITokenRepository tokenRepo = sdk.Configuration.TokenRepository;
                    if (tokenRepo is IRefreshTokenRepository)
                    {
                        IRefreshTokenRepository refreshTokenRepo = (IRefreshTokenRepository)tokenRepo;
                        refreshTokenRepo.RefreshTokenEnabled = true;
                        refreshTokenRepo.StoreRefreshToken(token.RefreshToken!, refreshThreshold);
                    }
                }
            });
        }

        public static bool LoginClient(this IAccelByteSdk sdk, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return sdk.LoginClient((token) =>
            {
                if (autoRefresh)
                {
                    ITokenRepository tokenRepo = sdk.Configuration.TokenRepository;
                    if (tokenRepo is IRefreshTokenRepository)
                    {
                        IRefreshTokenRepository refreshTokenRepo = (IRefreshTokenRepository)tokenRepo;
                        refreshTokenRepo.RefreshTokenEnabled = true;
                        refreshTokenRepo.StoreRefreshToken(String.Empty, refreshThreshold);
                    }
                }
            });
        }

        public static async Task<bool> LoginClientAsync(this IAccelByteSdk sdk, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return await sdk.LoginClientAsync((token) =>
            {
                if (autoRefresh)
                {
                    ITokenRepository tokenRepo = sdk.Configuration.TokenRepository;
                    if (tokenRepo is IRefreshTokenRepository)
                    {
                        IRefreshTokenRepository refreshTokenRepo = (IRefreshTokenRepository)tokenRepo;
                        refreshTokenRepo.RefreshTokenEnabled = true;
                        refreshTokenRepo.StoreRefreshToken(String.Empty, refreshThreshold);
                    }
                }
            });
        }

        public static bool LoginPlatform(this IAccelByteSdk sdk, string platformId, string platformToken, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return sdk.LoginPlatform(platformId, platformToken, (token) =>
              {
                  if (autoRefresh)
                  {
                      ITokenRepository tokenRepo = sdk.Configuration.TokenRepository;
                      if (tokenRepo is IRefreshTokenRepository)
                      {
                          IRefreshTokenRepository refreshTokenRepo = (IRefreshTokenRepository)tokenRepo;
                          refreshTokenRepo.RefreshTokenEnabled = true;
                          refreshTokenRepo.StoreRefreshToken(token.RefreshToken!, refreshThreshold);
                      }
                  }
              });
        }

        public static async Task<bool> LoginPlatformAsync(this IAccelByteSdk sdk, string platformId, string platformToken, bool autoRefresh, float refreshThreshold = 0.8f)
        {
            return await sdk.LoginPlatformAsync(platformId, platformToken, (token) =>
            {
                if (autoRefresh)
                {
                    ITokenRepository tokenRepo = sdk.Configuration.TokenRepository;
                    if (tokenRepo is IRefreshTokenRepository)
                    {
                        IRefreshTokenRepository refreshTokenRepo = (IRefreshTokenRepository)tokenRepo;
                        refreshTokenRepo.RefreshTokenEnabled = true;
                        refreshTokenRepo.StoreRefreshToken(token.RefreshToken!, refreshThreshold);
                    }
                }
            });
        }
    }

    public static class SdkBuilder_ExtensionMethods
    {
        public static IAccelByteSdkBuilder<T> UseAutoTokenRefresh<T>(this IAccelByteSdkBuilder<T> builder)
        {
            builder.SetTokenRepository(new RefreshableTokenRepository());
            builder.AddOperationProcess(new AutoTokenRefreshOperationProcess());
            return builder;
        }

        public static IAccelByteSdkBuilder<T> UseScheduledTokenRefresh<T>(this IAccelByteSdkBuilder<T> builder)
        {
            builder.SetTokenRepository(new ScheduledRefreshTokenRepository());
            return builder;
        }

        public static IAccelByteSdkBuilder<T> UseScheduledTokenRefresh<T>(this IAccelByteSdkBuilder<T> builder, Action onTokenRefreshed)
        {
            builder.SetTokenRepository(new ScheduledRefreshTokenRepository(onTokenRefreshed));
            return builder;
        }
    }
}