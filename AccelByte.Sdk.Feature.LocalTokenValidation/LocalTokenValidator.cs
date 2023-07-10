﻿// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
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

namespace AccelByte.Sdk.Feature.LocalTokenValidation
{
    public class LocalTokenValidator : TokenValidator, ITokenValidator
    {
        protected static void FetchJWKS(IAccelByteSdk sdk)
        {
            OauthcommonJWKSet? tempResp = sdk.GetIamApi().OAuth20.GetJWKSV3Op
                .SetPreferredSecurityMethod(Operation.SECURITY_BASIC)
                .Execute()
                ?? throw new Exception("Get JWKS response is NULL");

            JsonWebKeySets keys = new JsonWebKeySets(tempResp);
            sdk.LocalData[JsonWebKeySets.DATA_KEY] = keys;
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

                if (payload.Permissions == null)
                    return false;

                bool foundMatchingPermission = false;
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

                if (!foundMatchingPermission)
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}