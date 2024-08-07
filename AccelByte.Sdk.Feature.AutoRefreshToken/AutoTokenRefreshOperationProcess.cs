// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Pipeline;
using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Feature.AutoTokenRefresh
{
    public class AutoTokenRefreshOperationProcess : IOperationProcess, IOperationProcessAsync
    {
        public IOperationProcess? Next { get; set; }

        public IOperation Handle(IOperation operation, IAccelByteSdk sdk)
        {
            IAccelByteConfig config = sdk.Configuration;
            ITokenRepository tokenRepo = config.TokenRepository;

            if (config.TokenRepository is IRefreshTokenRepository)
            {
                IRefreshTokenRepository refreshTokenRepo = (IRefreshTokenRepository)config.TokenRepository;
                if (refreshTokenRepo.RefreshTokenEnabled)
                {
                    if (tokenRepo.HasToken)
                    {
                        if (refreshTokenRepo.IsTokenExpiring)
                        {
                            if (refreshTokenRepo.TryToSetRefreshOnProgressToTrue())
                            {
                                if (tokenRepo.LoginType == LoginType.User ||
                                    tokenRepo.LoginType == LoginType.Platform)
                                {
                                    if (refreshTokenRepo.HasRefreshToken)
                                    {
                                        sdk.RefreshAccessToken(refreshTokenRepo.RefreshToken, (token) =>
                                        {
                                            refreshTokenRepo.UpdateRefreshToken(token.RefreshToken!);
                                        });
                                    }
                                    else
                                    {
                                        sdk.LoginUser(true, refreshTokenRepo.RefreshThreshold);
                                        if (config.TokenRepository is IObservableTokenRepository)
                                        {
                                            var oTokenRepo = (IObservableTokenRepository)config.TokenRepository;
                                            _ = oTokenRepo.UpdateObserversWithNewToken();
                                        }
                                    }
                                }
                                else if (tokenRepo.LoginType == LoginType.Client)
                                {
                                    sdk.LoginClient(true, refreshTokenRepo.RefreshThreshold);
                                    if (config.TokenRepository is IObservableTokenRepository)
                                    {
                                        var oTokenRepo = (IObservableTokenRepository)config.TokenRepository;
                                        _ = oTokenRepo.UpdateObserversWithNewToken();
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return operation;
        }

        public async Task<IOperation> HandleAsync(IOperation operation, IAccelByteSdk sdk)
        {
            IAccelByteConfig config = sdk.Configuration;
            ITokenRepository tokenRepo = config.TokenRepository;

            if (config.TokenRepository is IRefreshTokenRepository)
            {
                IRefreshTokenRepository refreshTokenRepo = (IRefreshTokenRepository)config.TokenRepository;
                if (refreshTokenRepo.RefreshTokenEnabled)
                {
                    if (tokenRepo.HasToken)
                    {
                        if (refreshTokenRepo.IsTokenExpiring)
                        {
                            if (refreshTokenRepo.TryToSetRefreshOnProgressToTrue())
                            {
                                if (tokenRepo.LoginType == LoginType.User ||
                                    tokenRepo.LoginType == LoginType.Platform)
                                {
                                    if (refreshTokenRepo.HasRefreshToken)
                                    {
                                        await sdk.RefreshAccessTokenAsync(refreshTokenRepo.RefreshToken, (token) =>
                                        {
                                            refreshTokenRepo.UpdateRefreshToken(token.RefreshToken!);
                                        });
                                    }
                                    else
                                    {
                                        await sdk.LoginUserAsync(true, refreshTokenRepo.RefreshThreshold);
                                        if (config.TokenRepository is IObservableTokenRepository)
                                        {
                                            var oTokenRepo = (IObservableTokenRepository)config.TokenRepository;
                                            await oTokenRepo.UpdateObserversWithNewToken();
                                        }
                                    }
                                }
                                else if (tokenRepo.LoginType == LoginType.Client)
                                {
                                    await sdk.LoginClientAsync(true, refreshTokenRepo.RefreshThreshold);
                                    if (config.TokenRepository is IObservableTokenRepository)
                                    {
                                        var oTokenRepo = (IObservableTokenRepository)config.TokenRepository;
                                        await oTokenRepo.UpdateObserversWithNewToken();
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return operation;
        }
    }
}