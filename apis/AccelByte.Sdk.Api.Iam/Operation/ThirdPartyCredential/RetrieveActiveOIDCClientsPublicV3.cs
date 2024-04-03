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
    /// RetrieveActiveOIDCClientsPublicV3
    ///
    /// This is the Public API to Get All Active OIDC Platform Credential By Client ID
    /// </summary>
    public class RetrieveActiveOIDCClientsPublicV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveActiveOIDCClientsPublicV3Builder Builder { get => new RetrieveActiveOIDCClientsPublicV3Builder(); }

        public class RetrieveActiveOIDCClientsPublicV3Builder
            : OperationBuilder<RetrieveActiveOIDCClientsPublicV3Builder>
        {





            internal RetrieveActiveOIDCClientsPublicV3Builder() { }

            internal RetrieveActiveOIDCClientsPublicV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RetrieveActiveOIDCClientsPublicV3 Build(
                string namespace_,
                string clientId
            )
            {
                RetrieveActiveOIDCClientsPublicV3 op = new RetrieveActiveOIDCClientsPublicV3(this,
                    namespace_,
                    clientId
                );

                op.SetBaseFields<RetrieveActiveOIDCClientsPublicV3Builder>(this);
                return op;
            }

            public List<Model.ModelPublicThirdPartyPlatformInfo>? Execute(
                string namespace_,
                string clientId
            )
            {
                RetrieveActiveOIDCClientsPublicV3 op = Build(
                    namespace_,
                    clientId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<List<Model.ModelPublicThirdPartyPlatformInfo>?> ExecuteAsync(
                string namespace_,
                string clientId
            )
            {
                RetrieveActiveOIDCClientsPublicV3 op = Build(
                    namespace_,
                    clientId
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

        private RetrieveActiveOIDCClientsPublicV3(RetrieveActiveOIDCClientsPublicV3Builder builder,
            string namespace_,
            string clientId
        )
        {
            PathParams["namespace"] = namespace_;

            if (clientId is not null) QueryParams["clientId"] = clientId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveActiveOIDCClientsPublicV3(
            string namespace_,
            string clientId
        )
        {
            PathParams["namespace"] = namespace_;

            if (clientId is not null) QueryParams["clientId"] = clientId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/platforms/clients/oidc";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ModelPublicThirdPartyPlatformInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelPublicThirdPartyPlatformInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelPublicThirdPartyPlatformInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}