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
    /// GetJWKS
    ///
    /// ## The endpoint is going to be deprecated
    /// This endpoint serves public keys for verifying JWT access tokens generated by this service.
    /// 
    /// When a client application wants to verify a JWT token, it needs to get the 'kid' value found in the JWT token header and use it
    /// to look up the corresponding public key from a set returned by this endpoint. The client application can then use that public key to verify the JWT.
    /// 
    /// A client application might cache the keys so it doesn't need to do request every time it needs to verify a JWT token. If a client application
    /// caches the keys and a key with the same 'kid' cannot be found in the cache, it should then try to refresh the keys by making a request to this
    /// endpoint again.
    /// 
    /// Please refer to the RFC for more information about JWK (JSON Web Key): https://tools.ietf.org/html/rfc7517
    /// 
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/oauth/jwks [GET]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetJWKS : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetJWKSBuilder Builder { get => new GetJWKSBuilder(); }

        public class GetJWKSBuilder
            : OperationBuilder<GetJWKSBuilder>
        {





            internal GetJWKSBuilder() { }

            internal GetJWKSBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetJWKS Build(
            )
            {
                GetJWKS op = new GetJWKS(this
                );

                op.SetBaseFields<GetJWKSBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public GetJWKS.Response Execute(
            )
            {
                GetJWKS op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GetJWKS.Response> ExecuteAsync(
            )
            {
                GetJWKS op = Build(
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

        private GetJWKS(GetJWKSBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.OauthcommonJWKSet>
        {


            protected override string GetFullOperationId() => "Iam::OAuth::GetJWKS";
        }

        #endregion

        public GetJWKS(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/oauth/jwks";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "" };

        public override List<string> Produces => new() { "application/json" };

        public GetJWKS.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetJWKS.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.OauthcommonJWKSet>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}