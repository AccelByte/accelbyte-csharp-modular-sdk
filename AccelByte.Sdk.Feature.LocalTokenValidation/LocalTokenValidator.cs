// Copyright (c) 2023-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IdentityModel.Tokens.Jwt;

using Microsoft.IdentityModel.Tokens;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Security;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Feature.LocalTokenValidation
{
    public class LocalTokenValidator : TokenValidator, ITokenValidator, IAsyncTokenValidator
    {
        private Func<IAccelByteSdk, string, List<LocalPermissionItem>> _FetchFunction = ((sdk, roleId) =>
        {
            var response = sdk.GetIamApi().Roles.AdminGetRoleV4Op.Execute(roleId).Ok();

            List<LocalPermissionItem> permissions = new List<LocalPermissionItem>();
            foreach (var item in response.Permissions!)
            {
                permissions.Add(new LocalPermissionItem()
                {
                    Resource = item.Resource!,
                    Action = item.Action!.Value
                });
            }

            return permissions;
        });

        private Func<IAccelByteSdk, string, Task<List<LocalPermissionItem>>> _FetchFunctionAsync = (async (sdk, roleId) =>
        {
            var response = await sdk.GetIamApi().Roles.AdminGetRoleV4Op.ExecuteAsync(roleId);
            var responseData = response.Ok();

            List<LocalPermissionItem> permissions = new List<LocalPermissionItem>();
            foreach (var item in responseData.Permissions!)
            {
                permissions.Add(new LocalPermissionItem()
                {
                    Resource = item.Resource!,
                    Action = item.Action!.Value
                });
            }

            return permissions;
        });

        private Func<IAccelByteSdk, string, LocalNamespaceContext> _NamespaceFetchFunction = ((sdk, aNamespace) =>
        {
            var response = sdk.GetBasicApi().Namespace.GetNamespaceContextOp.Execute(aNamespace).Ok();            

            var context = new LocalNamespaceContext();
            if (response.Namespace != null)
                context.Namespace = response.Namespace;

            string sourceType = response.Type!.Value;
            if (sourceType == NamespaceContextType.Publisher.Value)
                context.Type = NamespaceType.Publisher;
            else if (sourceType == NamespaceContextType.Studio.Value)
                context.Type = NamespaceType.Studio;
            else if (sourceType == NamespaceContextType.Game.Value)
                context.Type = NamespaceType.Game;

            if (response.PublisherNamespace != null)
                context.PublisherNamespace = response.PublisherNamespace;

            if (response.StudioNamespace != null)
                context.StudioNamespace = response.StudioNamespace;

            return context;
        });

        private Func<IAccelByteSdk, string, Task<LocalNamespaceContext>> _NamespaceFetchFunctionAsync = (async (sdk, aNamespace) =>
        {
            var response = await sdk.GetBasicApi().Namespace.GetNamespaceContextOp.ExecuteAsync(aNamespace);
            var responseData = response.Ok();

            var context = new LocalNamespaceContext();
            if (responseData.Namespace != null)
                context.Namespace = responseData.Namespace;

            string sourceType = responseData.Type!.Value;
            if (sourceType == NamespaceContextType.Publisher.Value)
                context.Type = NamespaceType.Publisher;
            else if (sourceType == NamespaceContextType.Studio.Value)
                context.Type = NamespaceType.Studio;
            else if (sourceType == NamespaceContextType.Game.Value)
                context.Type = NamespaceType.Game;

            if (responseData.PublisherNamespace != null)
                context.PublisherNamespace = responseData.PublisherNamespace;

            if (responseData.StudioNamespace != null)
                context.StudioNamespace = responseData.StudioNamespace;

            return context;
        });

        protected static void FetchJWKS(IAccelByteSdk sdk)
        {
            OauthcommonJWKSet tempResp = sdk.GetIamApi().OAuth20.GetJWKSV3Op
                .SetPreferredSecurityMethod(Operation.SECURITY_BASIC)
                .Execute().Ok();

            JsonWebKeySets keys = new JsonWebKeySets(tempResp);
            sdk.LocalData[JsonWebKeySets.DATA_KEY] = keys;
        }

        protected static async Task FetchJWKSAsync(IAccelByteSdk sdk)
        {
            var temp = await sdk.GetIamApi().OAuth20.GetJWKSV3Op
                .SetPreferredSecurityMethod(Operation.SECURITY_BASIC)
                .ExecuteAsync();
            OauthcommonJWKSet tempResp = temp.Ok();

            JsonWebKeySets keys = new JsonWebKeySets(tempResp);
            sdk.LocalData[JsonWebKeySets.DATA_KEY] = keys;
        }

        protected static void InternalReadToken(string accessToken, out JwtSecurityToken rawJwt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            if (!tokenHandler.CanReadToken(accessToken))
                throw new Exception("Invalid access token format.");
            rawJwt = tokenHandler.ReadJwtToken(accessToken);
        }

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

        public bool Validate(IAccelByteSdk sdk, string accessToken)
        {
            try
            {
                InternalValidateToken(sdk, accessToken, out JwtSecurityToken rawJwt);
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
                InternalValidateToken(sdk, accessToken, out JwtSecurityToken rawJwt);
                AccessTokenPayload payload = AccessTokenPayload.FromToken(rawJwt);

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

                            var permissions = GetRolePermission(sdk, r.RoleId, _FetchFunction);
                            foreach (var p in permissions)
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

                            if (foundMatchingPermission)
                                break;
                        }
                    }
                }

                return foundMatchingPermission;
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
                InternalValidateToken(sdk, accessToken, out JwtSecurityToken rawJwt);
                AccessTokenPayload payload = AccessTokenPayload.FromToken(rawJwt);

                Dictionary<string, string> pParams = new Dictionary<string, string>();
                if (aNamespace != null)
                {
                    GetNamespaceContext(sdk, aNamespace, _NamespaceFetchFunction);
                    pParams.Add("namespace", aNamespace);
                }
                if (userId != null)
                    pParams.Add("userId", userId);

                bool foundMatchingPermission = false;
                if ((payload.Permissions != null) && (payload.Permissions.Count > 0))
                {
                    foreach (var p in payload.Permissions)
                    {
                        string aPermission = p.Resource;
                        if (pParams.Count > 0)
                            aPermission = ReplacePlaceholder(p.Resource, pParams);

                        if (IsResourceAllowed(aPermission, permission))
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

                            var permissions = GetRolePermission(sdk, r.RoleId, _FetchFunction);
                            foreach (var p in permissions)
                            {
                                string aPermission = p.Resource;
                                if (pParams.Count > 0)
                                    aPermission = ReplacePlaceholder(p.Resource, pParams);

                                if (IsResourceAllowed(aPermission, permission))
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
                JwtSecurityToken rawJwt = await InternalValidateTokenAsync(sdk, accessToken);
                AccessTokenPayload payload = AccessTokenPayload.FromToken(rawJwt);

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

                            var permissions = await GetRolePermissionAsync(sdk, r.RoleId, _FetchFunctionAsync);
                            foreach (var p in permissions)
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

                            if (foundMatchingPermission)
                                break;
                        }
                    }
                }

                return foundMatchingPermission;
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
                JwtSecurityToken rawJwt = await InternalValidateTokenAsync(sdk, accessToken);
                AccessTokenPayload payload = AccessTokenPayload.FromToken(rawJwt);

                Dictionary<string, string> pParams = new Dictionary<string, string>();
                if (aNamespace != null)
                {
                    await GetNamespaceContextAsync(sdk, aNamespace, _NamespaceFetchFunctionAsync);
                    pParams.Add("namespace", aNamespace);
                }
                if (userId != null)
                    pParams.Add("userId", userId);

                bool foundMatchingPermission = false;
                if ((payload.Permissions != null) && (payload.Permissions.Count > 0))
                {
                    foreach (var p in payload.Permissions)
                    {
                        string aPermission = p.Resource;
                        if (pParams.Count > 0)
                            aPermission = ReplacePlaceholder(p.Resource, pParams);

                        if (IsResourceAllowed(aPermission, permission))
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

                            var permissions = await GetRolePermissionAsync(sdk, r.RoleId, _FetchFunctionAsync);
                            foreach (var p in permissions)
                            {
                                string aPermission = p.Resource;
                                if (pParams.Count > 0)
                                    aPermission = ReplacePlaceholder(p.Resource, pParams);

                                if (IsResourceAllowed(aPermission, permission))
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
            catch
            {
                return false;
            }
        }

        public AccessTokenPayload? ParseAccessToken(IAccelByteSdk sdk, string accessToken, bool validateFirst)
        {
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
        }
    }
}
