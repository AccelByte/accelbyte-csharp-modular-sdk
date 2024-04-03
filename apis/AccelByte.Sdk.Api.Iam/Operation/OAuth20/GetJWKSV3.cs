// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// GetJWKSV3
    ///
    /// This endpoint serves public keys for verifying JWT access tokens generated by this service.
    /// When a client application wants to verify a JWT token, it needs to get the 'kid' value found in the JWT token header and use it
    /// to look up the corresponding public key from a set returned by this endpoint. The client application can then use that public key to verify the JWT.
    /// A client application might cache the keys so it doesn't need to do request every time it needs to verify a JWT token. If a client application
    /// caches the keys and a key with the same 'kid' cannot be found in the cache, it should then try to refresh the keys by making a request to this
    /// endpoint again.
    /// Please refer to the RFC for more information about JWK (JSON Web Key): https://tools.ietf.org/html/rfc7517
    /// action code : 10709
    /// </summary>
    public class GetJWKSV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetJWKSV3Builder Builder { get => new GetJWKSV3Builder(); }

        public class GetJWKSV3Builder
            : OperationBuilder<GetJWKSV3Builder>
        {





            internal GetJWKSV3Builder() { }

            internal GetJWKSV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetJWKSV3 Build(
            )
            {
                GetJWKSV3 op = new GetJWKSV3(this
                );

                op.SetBaseFields<GetJWKSV3Builder>(this);
                return op;
            }

            public Model.OauthcommonJWKSet? Execute(
            )
            {
                GetJWKSV3 op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.OauthcommonJWKSet?> ExecuteAsync(
            )
            {
                GetJWKSV3 op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private GetJWKSV3(GetJWKSV3Builder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetJWKSV3(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/oauth/jwks";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "" };

        public override List<string> Produces => new() { "application/json" };

        public Model.OauthcommonJWKSet? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthcommonJWKSet>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthcommonJWKSet>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}