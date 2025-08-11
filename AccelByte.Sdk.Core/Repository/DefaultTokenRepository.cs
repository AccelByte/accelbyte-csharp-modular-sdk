// Copyright (c) 2022-2025 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using AccelByte.Sdk.Core.Security;

namespace AccelByte.Sdk.Core.Repository
{
    public class DefaultTokenRepository : ITokenRepository, IObservableTokenRepository
    {
        private object _TokenLock = new object();

        public long CurrentTimestamp
        {
            get => (new DateTimeOffset(DateTime.UtcNow)).ToUnixTimeSeconds();
        }

        private string _Token = "";
        public string Token
        {
            get
            {
                lock (_TokenLock)
                {
                    if (_Token != "")
                        return _Token;
                    else
                        throw new Exception("No token stored.");
                }
            }
            protected set
            {
                lock (_TokenLock)
                {
                    _Token = value;
                }
            }
        }

        public string RefreshToken { get; protected set; } = "";

        private int _TokenExpiryIn = 0;

        public int TokenExpiryIn { get => _TokenExpiryIn; }

        public int RefreshExpireIn { get; protected set; } = 0;

        public int SecondsUntilExpiry
        {
            get => (int)((IssuedTimestamp + _TokenExpiryIn) - CurrentTimestamp);
        }

        public long IssuedTimestamp { get; set; } = 0;

        public bool HasToken
        {
            get
            {
                lock (_TokenLock)
                    return (_Token != "");
            }
        }

        public bool HasRefreshToken { get => RefreshToken != ""; }

        public bool IsTokenExpired
        {
            get => (CurrentTimestamp >= (IssuedTimestamp + _TokenExpiryIn));
        }

        private LoginType _LoginType = LoginType.User;
        public LoginType LoginType
        {
            get
            {
                lock (_TokenLock)
                    return _LoginType;
            }
        }

        public ITokenResponse? TokenData { get; private set; } = null;

        private List<ITokenRepositoryObserver> _Observers = new List<ITokenRepositoryObserver>();

        public virtual void RemoveToken()
        {
            lock (_TokenLock)
            {
                _Token = "";
                _TokenExpiryIn = 0;
                IssuedTimestamp = 0;
                TokenData = null;
                RefreshToken = "";
            }
        }

        public void StoreToken(LoginType loginType, ITokenResponse tokenResponse)
        {
            if (tokenResponse.AccessToken == null)
                throw new Exception("Access token is null");

            lock (_TokenLock)
            {
                TokenData = tokenResponse;
                _Token = tokenResponse.AccessToken;
                _LoginType = loginType;
                IssuedTimestamp = CurrentTimestamp;
                if (tokenResponse.ExpiresIn != null)
                    _TokenExpiryIn = tokenResponse.ExpiresIn.Value;

                RefreshToken = tokenResponse.RefreshToken;
                if (tokenResponse.RefreshExpiresIn != null)
                    RefreshExpireIn = tokenResponse.RefreshExpiresIn.Value;
            }            
        }

        public void UpdateToken(ITokenResponse tokenResponse)
        {
            if (tokenResponse.AccessToken == null)
                throw new Exception("Access token is null");

            lock (_TokenLock)
            {
                TokenData = tokenResponse;
                _Token = tokenResponse.AccessToken;
                IssuedTimestamp = CurrentTimestamp;
                if (tokenResponse.ExpiresIn != null)
                    _TokenExpiryIn = tokenResponse.ExpiresIn.Value;

                RefreshToken = tokenResponse.RefreshToken;
                if (tokenResponse.RefreshExpiresIn != null)
                    RefreshExpireIn = tokenResponse.RefreshExpiresIn.Value;
            }
        }

        public void SetTokenExpiry(int value)
        {
            _TokenExpiryIn = value;
        }

        public bool IsTokenExpiring(float rate)
        {
            long tExpiry = (long)Math.Round((rate * TokenExpiryIn), 0);
            long tgt = IssuedTimestamp + tExpiry;
            return (CurrentTimestamp >= tgt);
        }

        public void RegisterObserver(ITokenRepositoryObserver observer)
        {
            _Observers.Add(observer);
        }

        public void UnregisterObserver(ITokenRepositoryObserver observer)
        {
            _Observers.Remove(observer);
        }

        public async Task UpdateObserversWithNewToken()
        {
            string newToken = Token;
            foreach (var observer in _Observers)
                await observer.OnAccessTokenChanged(newToken);
        }
    }

    public static class DefaultTokenRepository_SdkBuilderExts
    {
        public static IAccelByteSdkBuilder<T> UseDefaultTokenRepository<T>(this IAccelByteSdkBuilder<T> builder)
        {
            return builder.SetTokenRepository(new DefaultTokenRepository());
        }
    }
}