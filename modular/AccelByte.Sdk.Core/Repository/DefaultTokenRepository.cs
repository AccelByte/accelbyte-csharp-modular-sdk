// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core.Security;

namespace AccelByte.Sdk.Core.Repository
{
    public class DefaultTokenRepository : ITokenRepository
    {
        private object _TokenLock = new object();

        public long CurrentTimestamp
        {
            get => (new DateTimeOffset(DateTime.UtcNow)).ToUnixTimeSeconds();
        }

        private string _Token = String.Empty;
        public string Token
        {
            get
            {
                lock (_TokenLock)
                {
                    if (_Token != String.Empty)
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

        private int _TokenExpiryIn = 0;

        public int TokenExpiryIn { get => _TokenExpiryIn; }

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
                {
                    return (_Token != String.Empty);
                }
            }
        }

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
                {
                    return _LoginType;
                }
            }
        }

        public virtual void RemoveToken()
        {
            lock (_TokenLock)
            {
                _Token = String.Empty;
                _TokenExpiryIn = 0;
                IssuedTimestamp = 0;
            }
        }

        public void StoreToken(LoginType loginType, ITokenResponse tokenResponse)
        {
            if (tokenResponse.AccessToken == null)
                throw new Exception("Access token is null");

            lock (_TokenLock)
            {
                _Token = tokenResponse.AccessToken;
                _LoginType = loginType;
                IssuedTimestamp = CurrentTimestamp;
                if (tokenResponse.ExpiresIn != null)
                    _TokenExpiryIn = tokenResponse.ExpiresIn.Value;
            }
        }

        public void UpdateToken(ITokenResponse tokenResponse)
        {
            if (tokenResponse.AccessToken == null)
                throw new Exception("Access token is null");

            lock (_TokenLock)
            {
                _Token = tokenResponse.AccessToken;
                IssuedTimestamp = CurrentTimestamp;
                if (tokenResponse.ExpiresIn != null)
                    _TokenExpiryIn = tokenResponse.ExpiresIn.Value;
            }
        }

        public void SetTokenExpiry(int value)
        {
            _TokenExpiryIn = value;
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