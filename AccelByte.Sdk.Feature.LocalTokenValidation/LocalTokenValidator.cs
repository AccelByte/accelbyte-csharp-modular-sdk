// Copyright (c) 2023-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

#if NET6_0
using System.IdentityModel.Tokens.Jwt;
#elif NET8_0_OR_GREATER
using Microsoft.IdentityModel.JsonWebTokens;
#endif
using Microsoft.IdentityModel.Tokens;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Security;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Authentication;

namespace AccelByte.Sdk.Feature.LocalTokenValidation
{
    public class LocalTokenValidator : IamBaseTokenValidator, ITokenValidator, IAsyncTokenValidator
    {
        protected static void FetchJWKS(IAccelByteSdk sdk)
        {
            OauthcommonJWKSet tempResp = sdk.GetIamApi().OAuth20.GetJWKSV3Op
                .SetPreferredSecurityMethod(Operation.SECURITY_BASIC)
                .Execute().EnsureSuccess();

            JsonWebKeySets keys = new JsonWebKeySets(tempResp);
            sdk.LocalData[JsonWebKeySets.DATA_KEY] = keys;
        }

        protected static async Task FetchJWKSAsync(IAccelByteSdk sdk)
        {
            var temp = await sdk.GetIamApi().OAuth20.GetJWKSV3Op
                .SetPreferredSecurityMethod(Operation.SECURITY_BASIC)
                .ExecuteAsync();
            OauthcommonJWKSet tempResp = temp.EnsureSuccess();

            JsonWebKeySets keys = new JsonWebKeySets(tempResp);
            sdk.LocalData[JsonWebKeySets.DATA_KEY] = keys;
        }

#if NET6_0
        protected static void InternalReadToken(string accessToken, out JwtSecurityToken rawJwt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            if (!tokenHandler.CanReadToken(accessToken))
                throw new Exception("Invalid access token format.");
            rawJwt = tokenHandler.ReadJwtToken(accessToken);
        }
#elif NET8_0_OR_GREATER
        protected static JsonWebToken InternalReadToken(string accessToken)
        {
            var tokenHandler = new JsonWebTokenHandler();
            if (!tokenHandler.CanReadToken(accessToken))
                throw new Exception("Invalid access token format.");
            return tokenHandler.ReadJsonWebToken(accessToken);
        }
#endif

#if NET6_0
        protected static void InternalValidateToken(IAccelByteSdk sdk, string accessToken, out JwtSecurityToken rawJwt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            if (!tokenHandler.CanReadToken(accessToken))
                throw new Exception("Invalid access token format.");

            TokenRevocationData? tokenData = sdk.LocalData.GetData<TokenRevocationData>(TokenRevocationData.DATA_KEY);
            if (tokenData != null)
            {
                bool isRevoked = tokenData.IsTokenRevoked(accessToken);
                if (isRevoked)
                    throw new Exception("Access token is revoked.");
            }

            rawJwt = tokenHandler.ReadJwtToken(accessToken);
            if (!rawJwt.Header.ContainsKey("kid"))
                throw new Exception("missing 'kid' value in jwt header.");
            string keyId = rawJwt.Header["kid"].ToString()!.ToLower();
            if (keyId == String.Empty)
                throw new Exception("empty 'kid' value in jwt header.");

            JsonWebKeySets? keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
            if (keySets == null)
            {
                FetchJWKS(sdk);
                keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
                if (keySets == null)
                    throw new Exception("Could not fetch JWKS");
            }

            if (!keySets.ContainsKey(keyId))
            {
                FetchJWKS(sdk);
                keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
                if (keySets == null)
                    throw new Exception("Could not fetch JWKS");

                if (!keySets.ContainsKey(keyId))
                    throw new Exception("No matching JWK set for this token");
            }

            OauthcommonJWKKey key = keySets[keyId];

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(
              new RSAParameters()
              {
                  Modulus = (key.N != null ? key.N.DecodeBase64Url() : new byte[] { }),
                  Exponent = (key.E != null ? key.E.DecodeBase64Url() : new byte[] { })
              });

            tokenHandler.ValidateToken(accessToken, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new RsaSecurityKey(rsa),
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);
        }

        protected static async Task<JwtSecurityToken> InternalValidateTokenAsync(IAccelByteSdk sdk, string accessToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            if (!tokenHandler.CanReadToken(accessToken))
                throw new Exception("Invalid access token format.");

            TokenRevocationData? tokenData = sdk.LocalData.GetData<TokenRevocationData>(TokenRevocationData.DATA_KEY);
            if (tokenData != null)
            {
                bool isRevoked = tokenData.IsTokenRevoked(accessToken);
                if (isRevoked)
                    throw new Exception("Access token is revoked.");
            }

            JwtSecurityToken rawJwt = tokenHandler.ReadJwtToken(accessToken);
            if (!rawJwt.Header.ContainsKey("kid"))
                throw new Exception("missing 'kid' value in jwt header.");
            string keyId = rawJwt.Header["kid"].ToString()!.ToLower();
            if (keyId == String.Empty)
                throw new Exception("empty 'kid' value in jwt header.");

            JsonWebKeySets? keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
            if (keySets == null)
            {
                await FetchJWKSAsync(sdk);
                keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
                if (keySets == null)
                    throw new Exception("Could not fetch JWKS");
            }

            if (!keySets.ContainsKey(keyId))
            {
                await FetchJWKSAsync(sdk);
                keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
                if (keySets == null)
                    throw new Exception("Could not fetch JWKS");

                if (!keySets.ContainsKey(keyId))
                    throw new Exception("No matching JWK set for this token");
            }

            OauthcommonJWKKey key = keySets[keyId];

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(
              new RSAParameters()
              {
                  Modulus = (key.N != null ? key.N.DecodeBase64Url() : new byte[] { }),
                  Exponent = (key.E != null ? key.E.DecodeBase64Url() : new byte[] { })
              });

            await tokenHandler.ValidateTokenAsync(accessToken, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new RsaSecurityKey(rsa),
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            });

            return rawJwt;
        }
#elif NET8_0_OR_GREATER
        protected static JsonWebToken InternalValidateToken(IAccelByteSdk sdk, string accessToken)
        {
            var tokenHandler = new JsonWebTokenHandler();
            if (!tokenHandler.CanReadToken(accessToken))
                throw new Exception("Invalid access token format.");

            TokenRevocationData? tokenData = sdk.LocalData.GetData<TokenRevocationData>(TokenRevocationData.DATA_KEY);
            if (tokenData != null)
            {
                bool isRevoked = tokenData.IsTokenRevoked(accessToken);
                if (isRevoked)
                    throw new Exception("Access token is revoked.");
            }

            var token = tokenHandler.ReadJsonWebToken(accessToken);
            string keyId = token.Kid.Trim().ToLower();
            if (keyId == "")
                throw new Exception("empty 'kid' value in jwt header.");

            JsonWebKeySets? keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
            if (keySets == null)
            {
                FetchJWKS(sdk);
                keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
                if (keySets == null)
                    throw new Exception("Could not fetch JWKS");
            }

            if (!keySets.ContainsKey(keyId))
            {
                FetchJWKS(sdk);
                keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
                if (keySets == null)
                    throw new Exception("Could not fetch JWKS");

                if (!keySets.ContainsKey(keyId))
                    throw new Exception("No matching JWK set for this token");
            }

            OauthcommonJWKKey key = keySets[keyId];

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(
              new RSAParameters()
              {
                  Modulus = (key.N != null ? key.N.DecodeBase64Url() : new byte[] { }),
                  Exponent = (key.E != null ? key.E.DecodeBase64Url() : new byte[] { })
              });

            var validationResult = tokenHandler.ValidateTokenAsync(accessToken, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new RsaSecurityKey(rsa),
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            }).Result;

            if (validationResult == null)
                throw new Exception("Token validation returns null.");

            if (validationResult.IsValid)
                return token;
            else
                throw validationResult.Exception;
        }

        protected static async Task<JsonWebToken> InternalValidateTokenAsync(IAccelByteSdk sdk, string accessToken)
        {
            var tokenHandler = new JsonWebTokenHandler();
            if (!tokenHandler.CanReadToken(accessToken))
                throw new Exception("Invalid access token format.");

            TokenRevocationData? tokenData = sdk.LocalData.GetData<TokenRevocationData>(TokenRevocationData.DATA_KEY);
            if (tokenData != null)
            {
                bool isRevoked = tokenData.IsTokenRevoked(accessToken);
                if (isRevoked)
                    throw new Exception("Access token is revoked.");
            }

            var rawJwt = tokenHandler.ReadJsonWebToken(accessToken);
            if (rawJwt.TryGetHeaderValue("kid", out string kidValue))
                throw new Exception("missing 'kid' value in jwt header.");
            string keyId = kidValue.ToString().ToLower();
            if (keyId == "")
                throw new Exception("empty 'kid' value in jwt header.");

            JsonWebKeySets? keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
            if (keySets == null)
            {
                await FetchJWKSAsync(sdk);
                keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
                if (keySets == null)
                    throw new Exception("Could not fetch JWKS");
            }

            if (!keySets.ContainsKey(keyId))
            {
                await FetchJWKSAsync(sdk);
                keySets = sdk.LocalData.GetData<JsonWebKeySets>(JsonWebKeySets.DATA_KEY);
                if (keySets == null)
                    throw new Exception("Could not fetch JWKS");

                if (!keySets.ContainsKey(keyId))
                    throw new Exception("No matching JWK set for this token");
            }

            OauthcommonJWKKey key = keySets[keyId];

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(
              new RSAParameters()
              {
                  Modulus = (key.N != null ? key.N.DecodeBase64Url() : new byte[] { }),
                  Exponent = (key.E != null ? key.E.DecodeBase64Url() : new byte[] { })
              });

            var validationResult = await tokenHandler.ValidateTokenAsync(accessToken, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new RsaSecurityKey(rsa),
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            });

            if (validationResult.IsValid)
                return rawJwt;
            else
                throw validationResult.Exception;
        }
#endif

        protected bool InternalValidatePermission(IAccelByteSdk sdk, AccessTokenPayload payload, string permission, int action, Dictionary<string, string> pParams)
        {
            bool foundMatchingPermission = false;
            if ((payload.Permissions != null) && (payload.Permissions.Count > 0))
            {
                foreach (var p in payload.Permissions)
                {
                    if (IsResourceAllowed(p.Resource, permission))
                    {
                        if (PermissionAction.Has(p.Action, action))
                        {
                            foundMatchingPermission = true;
                            break;
                        }
                    }
                }
            }

            if (!foundMatchingPermission)
            {
                if ((payload.NamespaceRoles != null) && (payload.NamespaceRoles.Count > 0))
                {
                    foreach (var r in payload.NamespaceRoles)
                    {
                        if (r.RoleId == null)
                            continue;
                        string roleNamespace = r.Namespace!;

                        pParams["namespace"] = roleNamespace;
                        var permissions = GetRolePermission(sdk, r.RoleId, roleNamespace, _PermissionFetchFunction);
                        foreach (var p in permissions)
                        {
                            string aResource = ReplacePlaceholder(p.Resource, pParams);
                            if (IsResourceAllowed(aResource, permission))
                            {
                                if (PermissionAction.Has(p.Action, action))
                                {
                                    foundMatchingPermission = true;
                                    break;
                                }
                            }
                        }

                        if (foundMatchingPermission)
                            break;
                    }
                }
            }

            return foundMatchingPermission;
        }

        protected async Task<bool> InternalValidatePermissionAsync(IAccelByteSdk sdk, AccessTokenPayload payload, string permission, int action, Dictionary<string, string> pParams)
        {
            bool foundMatchingPermission = false;
            if ((payload.Permissions != null) && (payload.Permissions.Count > 0))
            {
                foreach (var p in payload.Permissions)
                {
                    if (IsResourceAllowed(p.Resource, permission))
                    {
                        if (PermissionAction.Has(p.Action, action))
                        {
                            foundMatchingPermission = true;
                            break;
                        }
                    }
                }
            }

            if (!foundMatchingPermission)
            {
                if ((payload.NamespaceRoles != null) && (payload.NamespaceRoles.Count > 0))
                {
                    foreach (var r in payload.NamespaceRoles)
                    {
                        if (r.RoleId == null)
                            continue;
                        string roleNamespace = r.Namespace!;

                        pParams["namespace"] = roleNamespace;
                        var permissions = await GetRolePermissionAsync(sdk, r.RoleId, roleNamespace, _PermissionFetchFunctionAsync);
                        foreach (var p in permissions)
                        {
                            string aResource = ReplacePlaceholder(p.Resource, pParams);
                            if (IsResourceAllowed(aResource, permission))
                            {
                                if (PermissionAction.Has(p.Action, action))
                                {
                                    foundMatchingPermission = true;
                                    break;
                                }
                            }
                        }

                        if (foundMatchingPermission)
                            break;
                    }
                }
            }

            return foundMatchingPermission;
        }

        public bool Validate(IAccelByteSdk sdk, string accessToken)
        {
            try
            {
#if NET6_0
                InternalValidateToken(sdk, accessToken, out JwtSecurityToken rawJwt);
#elif NET8_0_OR_GREATER
                _ = InternalValidateToken(sdk, accessToken);
#endif
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Validate(IAccelByteSdk sdk, string accessToken, string permission, int action)
        {
            try
            {
#if NET6_0
                InternalValidateToken(sdk, accessToken, out JwtSecurityToken rawJwt);
                AccessTokenPayload payload = AccessTokenPayload.FromToken(rawJwt);
#elif NET8_0_OR_GREATER
                var jsonWebToken = InternalValidateToken(sdk, accessToken);
                AccessTokenPayload payload = AccessTokenPayload.FromToken(jsonWebToken);
#endif

                string claimedNamespace = payload.Namespace!;

                var result = GetNamespaceContext(sdk, claimedNamespace, _NamespaceFetchFunction);
                if (result.IsError)
                    return false; //Access denied to namespace context error

                //Default filled with sdk's namespace.
                Dictionary<string, string> pParams = new() { { "namespace", sdk.Namespace } };

                return InternalValidatePermission(sdk, payload, permission, action, pParams);
            }
            catch
            {
                return false;
            }
        }

        public bool Validate(IAccelByteSdk sdk, string accessToken, string permission, int action, string? aNamespace, string? userId)
        {
            try
            {
#if NET6_0
                InternalValidateToken(sdk, accessToken, out JwtSecurityToken rawJwt);
                AccessTokenPayload payload = AccessTokenPayload.FromToken(rawJwt);
#elif NET8_0_OR_GREATER
                var jsonWebToken = InternalValidateToken(sdk, accessToken);
                AccessTokenPayload payload = AccessTokenPayload.FromToken(jsonWebToken);
#endif

                Dictionary<string, string> pParams = new Dictionary<string, string>();
                if (aNamespace != null)
                {
                    var result = GetNamespaceContext(sdk, aNamespace, _NamespaceFetchFunction);
                    if (result.IsError)
                        return false; //Access denied to namespace context error
                    pParams.Add("namespace", aNamespace);
                }
                if (userId != null)
                    pParams.Add("userId", userId);

                return InternalValidatePermission(sdk, payload, permission, action, pParams);
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> ValidateAsync(IAccelByteSdk sdk, string accessToken)
        {
            try
            {
                await InternalValidateTokenAsync(sdk, accessToken);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> ValidateAsync(IAccelByteSdk sdk, string accessToken, string permission, int action)
        {
            try
            {
#if NET6_0
                InternalValidateToken(sdk, accessToken, out JwtSecurityToken rawJwt);
                AccessTokenPayload payload = AccessTokenPayload.FromToken(rawJwt);
#elif NET8_0_OR_GREATER
                var jsonWebToken = InternalValidateToken(sdk, accessToken);
                AccessTokenPayload payload = AccessTokenPayload.FromToken(jsonWebToken);
#endif

                string claimedNamespace = payload.Namespace!;

                var result = await GetNamespaceContextAsync(sdk, claimedNamespace, _NamespaceFetchFunctionAsync);
                if (result.IsError)
                    return false; //Access denied to namespace context error

                //Default filled with sdk's namespace.
                Dictionary<string, string> pParams = new() { { "namespace", sdk.Namespace } };

                return await InternalValidatePermissionAsync(sdk, payload, permission, action, pParams);
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> ValidateAsync(IAccelByteSdk sdk, string accessToken, string permission, int action, string? aNamespace, string? userId)
        {
            try
            {
#if NET6_0
                InternalValidateToken(sdk, accessToken, out JwtSecurityToken rawJwt);
                AccessTokenPayload payload = AccessTokenPayload.FromToken(rawJwt);
#elif NET8_0_OR_GREATER
                var jsonWebToken = InternalValidateToken(sdk, accessToken);
                AccessTokenPayload payload = AccessTokenPayload.FromToken(jsonWebToken);
#endif

                Dictionary<string, string> pParams = new Dictionary<string, string>();
                if (aNamespace != null)
                {
                    var result = await GetNamespaceContextAsync(sdk, aNamespace, _NamespaceFetchFunctionAsync);
                    if (result.IsError)
                        return false; //Access denied to namespace context error
                    pParams.Add("namespace", aNamespace);
                }
                if (userId != null)
                    pParams.Add("userId", userId);

                return await InternalValidatePermissionAsync(sdk, payload, permission, action, pParams);
            }
            catch
            {
                return false;
            }
        }

        public AccessTokenPayload? ParseAccessToken(IAccelByteSdk sdk, string accessToken, bool validateFirst)
        {
#if NET6_0
            JwtSecurityToken rawJwt;
            try
            {
                if (validateFirst)
                    InternalValidateToken(sdk, accessToken, out rawJwt);
                else
                    InternalReadToken(accessToken, out rawJwt);
            }
            catch
            {
                return null;
            }
            return AccessTokenPayload.FromToken(rawJwt);
#elif NET8_0_OR_GREATER
            try
            {
                JsonWebToken jwt;
                if (validateFirst)
                    jwt = InternalValidateToken(sdk, accessToken);
                else
                    jwt = InternalReadToken(accessToken);
                return AccessTokenPayload.FromToken(jwt);
            }
            catch
            {
                return null;
            }
#endif
        }
    }
}
