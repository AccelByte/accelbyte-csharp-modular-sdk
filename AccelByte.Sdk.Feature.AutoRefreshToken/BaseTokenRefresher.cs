// Copyright (c) 2025 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Feature.AutoTokenRefresh
{
    public abstract class BaseTokenRefresher
    {
        private object _ROPLock = new object();

        private bool _IsRefreshOnProgress = false;

        private readonly ITokenRefreshOptions _Options;

        public bool IsRefreshOnProgress
        {
            get
            {
                lock (_ROPLock)
                    return _IsRefreshOnProgress;
            }
            set
            {
                lock (_ROPLock)
                    _IsRefreshOnProgress = value;
            }
        }

        public BaseTokenRefresher(ITokenRefreshOptions options)
        {
            _Options = options;
        }

        public bool TryToSetRefreshOnProgressToTrue()
        {
            lock (_ROPLock)
            {
                if (_IsRefreshOnProgress)
                    return false;
                else
                {
                    _IsRefreshOnProgress = true;
                    return _IsRefreshOnProgress;
                }
            }
        }

        public void DoRefreshToken(IAccelByteSdk sdk, Action? onUpdated, Action<Exception>? onFailed, bool rethrowOnError)
        {
            if (!_Options.IsEnabled)
                return;

            ITokenRepository tokenRepo = sdk.Configuration.TokenRepository;
            if (tokenRepo.HasToken && tokenRepo.IsTokenExpiring(_Options.Rate) && !IsRefreshOnProgress)
            {
                //only try refresh if token exists and it is near expired.
                if (TryToSetRefreshOnProgressToTrue())
                {
                    int retryCount = 0;
                    while (true)
                    {
                        try
                        {
                            if (tokenRepo.LoginType == LoginType.User ||
                                tokenRepo.LoginType == LoginType.Platform)
                            {
                                if (!tokenRepo.HasRefreshToken)
                                    throw new Exception("No refresh token stored.");
                                sdk.RefreshAccessToken(tokenRepo.RefreshToken, token =>
                                {
                                    onUpdated?.Invoke();
                                    IsRefreshOnProgress = false;
                                });
                            }
                            else if (tokenRepo.LoginType == LoginType.Client)
                            {
                                sdk.LoginClient(token =>
                                {
                                    onUpdated?.Invoke();
                                    IsRefreshOnProgress = false;
                                });
                                if (tokenRepo is IObservableTokenRepository otr)
                                    _ = otr.UpdateObserversWithNewToken();
                            }

                            break; //retry success, get out of the loop
                        }
                        catch (Exception x)
                        {
                            retryCount++;
                            if (retryCount >= _Options.MaxRetry)
                            {
                                onFailed?.Invoke(x);
                                if (rethrowOnError)
                                    throw;
                                else
                                    break; //this should break the loop and continue
                            }
                        }
                    }
                }
            }
        }

        public async Task DoRefreshTokenAsync(IAccelByteSdk sdk, Action? onUpdated, Action<Exception>? onFailed, bool rethrowOnError)
        {
            if (!_Options.IsEnabled)
                await Task.CompletedTask;
            else
            {
                ITokenRepository tokenRepo = sdk.Configuration.TokenRepository;
                if (tokenRepo.HasToken && tokenRepo.IsTokenExpiring(_Options.Rate) && !IsRefreshOnProgress)
                {
                    //only try refresh if token exists and it is near expired.
                    if (TryToSetRefreshOnProgressToTrue())
                    {
                        int retryCount = 0;
                        while (true)
                        {
                            try
                            {
                                if (tokenRepo.LoginType == LoginType.User ||
                                    tokenRepo.LoginType == LoginType.Platform)
                                {
                                    if (!tokenRepo.HasRefreshToken)
                                        throw new Exception("No refresh token stored.");
                                    await sdk.RefreshAccessTokenAsync(tokenRepo.RefreshToken, token =>
                                    {
                                        onUpdated?.Invoke();
                                        IsRefreshOnProgress = false;
                                    });
                                }
                                else if (tokenRepo.LoginType == LoginType.Client)
                                {
                                    await sdk.LoginClientAsync(token =>
                                    {
                                        onUpdated?.Invoke();
                                        IsRefreshOnProgress = false;
                                    });
                                    if (tokenRepo is IObservableTokenRepository otr)
                                        await otr.UpdateObserversWithNewToken();
                                }

                                break; //retry success, get out of the loop
                            }
                            catch (Exception x)
                            {
                                retryCount++;
                                if (retryCount >= _Options.MaxRetry)
                                {
                                    onFailed?.Invoke(x);
                                    if (rethrowOnError)
                                        throw;
                                    else
                                        break; //this should break the loop and continue
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
