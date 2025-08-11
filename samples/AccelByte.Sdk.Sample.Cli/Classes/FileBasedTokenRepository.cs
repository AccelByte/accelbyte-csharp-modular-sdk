// Copyright (c) 2022-2025 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Security;

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Sample.Cli
{
    public class FileBasedTokenRepository : ITokenRepository, IObservableTokenRepository
    {
        private class _TokenStore
        {
            [JsonPropertyName("token")]
            public string Token { get; set; } = "";

            [JsonPropertyName("refresh_token")]
            public string RefreshToken { get; set; } = "";

            [JsonPropertyName("expiry_in")]
            public int TokenExpiryIn { get; set; } = 0;

            [JsonPropertyName("refresh_expiry_in")]
            public int RefreshTokenExpiryIn { get; set; } = 0;

            [JsonPropertyName("type")]
            public LoginType Type { get; set; } = LoginType.User;

            [JsonPropertyName("issued")]
            public long IssuedTimestamp { get; set; } = 0;

            public static _TokenStore? LoadFromFile(string fileName)
            {
                if (!File.Exists(fileName))
                    return null;

                string content = File.ReadAllText(fileName);
                return JsonSerializer.Deserialize<_TokenStore>(content, new JsonSerializerOptions()
                {
                    AllowTrailingCommas = true,
                    ReadCommentHandling = JsonCommentHandling.Skip
                })!;
            }

            public void SaveToFile(string fileName)
            {
                string content = JsonSerializer.Serialize(this);
                File.WriteAllText(fileName, content);
            }
        }

        private string _FileName;

        private _TokenStore? _Store = null;

        private object _TokenLock = new object();

        private List<ITokenRepositoryObserver> _Observers = new List<ITokenRepositoryObserver>();

        public long CurrentTimestamp
        {
            get => (new DateTimeOffset(DateTime.UtcNow)).ToUnixTimeSeconds();
        }

        public string Token
        {
            get
            {
                lock (_TokenLock)
                {
                    if (_Store == null)
                        _Store = _TokenStore.LoadFromFile(_FileName);

                    if (_Store == null)
                        throw new Exception("No token stored.");

                    return _Store.Token;
                }
            }
        }

        public string RefreshToken
        {
            get
            {
                lock (_TokenLock)
                {
                    if (_Store == null)
                        _Store = _TokenStore.LoadFromFile(_FileName);

                    if (_Store == null)
                        throw new Exception("No token stored.");

                    return _Store.RefreshToken;
                }
            }
        }

        public int TokenExpiryIn
        {
            get
            {
                lock (_TokenLock)
                {
                    return (_Store != null ? _Store.TokenExpiryIn : 0);
                }
            }
        }

        public int RefreshExpireIn
        {
            get
            {
                lock (_TokenLock)
                {
                    return (_Store != null ? _Store.RefreshTokenExpiryIn : 0);
                }
            }
        }

        public int SecondsUntilExpiry
        {
            get => (int)((IssuedTimestamp + TokenExpiryIn) - CurrentTimestamp);
        }

        public long IssuedTimestamp
        {
            get
            {
                lock (_TokenLock)
                {
                    return (_Store != null ? _Store.IssuedTimestamp : 0);
                }
            }
            set
            {
                lock (_TokenLock)
                {
                    if (_Store != null)
                        _Store.IssuedTimestamp = value;
                }
            }
        }

        public bool HasToken
        {
            get
            {
                lock (_TokenLock)
                {
                    if (_Store == null)
                        _Store = _TokenStore.LoadFromFile(_FileName);
                    return (_Store != null);
                }
            }
        }

        public bool HasRefreshToken
        {
            get
            {
                lock (_TokenLock)
                {
                    if (_Store == null)
                        _Store = _TokenStore.LoadFromFile(_FileName);
                    if (_Store != null)
                        return _Store.RefreshToken != "";
                    return false;
                }
            }
        }

        public bool IsTokenExpired
        {
            get => (CurrentTimestamp >= (IssuedTimestamp + TokenExpiryIn));
        }

        public LoginType LoginType
        {
            get => (_Store != null ? _Store.Type : LoginType.User);
        }

        public ITokenResponse? TokenData { get; private set; } = null;

        public FileBasedTokenRepository(string fileName)
        {
            _FileName = fileName;
            _Store = _TokenStore.LoadFromFile(_FileName);
        }

        public FileBasedTokenRepository()
        {
            string aLoc = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!;
            _FileName = (aLoc + Path.DirectorySeparatorChar + "token.json");
            _Store = _TokenStore.LoadFromFile(_FileName);
        }

        public string GetToken()
        {
            return Token;
        }

        public void RemoveToken()
        {
            lock (_TokenLock)
            {
                if (File.Exists(_FileName))
                    File.Delete(_FileName);
                _Store = null;
            }
        }

        public void StoreToken(LoginType loginType, ITokenResponse tokenResponse)
        {
            if (tokenResponse.AccessToken == null)
                throw new Exception("Access token is null");

            lock (_TokenLock)
            {
                TokenData = tokenResponse;
                _Store = new _TokenStore()
                {
                    Token = tokenResponse.AccessToken,
                    Type = LoginType,
                    IssuedTimestamp = CurrentTimestamp,
                    RefreshToken = tokenResponse.RefreshToken
                };

                if (tokenResponse.ExpiresIn != null)
                    _Store.TokenExpiryIn = tokenResponse.ExpiresIn.Value;
                if (tokenResponse.RefreshExpiresIn != null)
                    _Store.RefreshTokenExpiryIn = tokenResponse.RefreshExpiresIn.Value;

                _Store.SaveToFile(_FileName);
            }
        }

        public void UpdateToken(ITokenResponse tokenResponse)
        {
            if (tokenResponse.AccessToken == null)
                throw new Exception("Access token is null");

            lock (_TokenLock)
            {
                TokenData = tokenResponse;
                if (_Store == null)
                    _Store = new _TokenStore();

                _Store.Token = tokenResponse.AccessToken;
                _Store.RefreshToken = tokenResponse.RefreshToken;
                _Store.IssuedTimestamp = CurrentTimestamp;
                if (tokenResponse.ExpiresIn != null)
                    _Store.TokenExpiryIn = tokenResponse.ExpiresIn.Value;
                if (tokenResponse.RefreshExpiresIn != null)
                    _Store.RefreshTokenExpiryIn = tokenResponse.RefreshExpiresIn.Value;

                _Store.SaveToFile(_FileName);
            }
        }

        public void SetTokenExpiry(int value)
        {
            lock (_TokenLock)
            {
                if (_Store != null)
                    _Store.TokenExpiryIn = value;
            }
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
}