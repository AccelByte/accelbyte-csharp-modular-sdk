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
    /// RetrieveAllActiveThirdPartyLoginPlatformCredentialV3
    ///
    /// This is the API to Get All Active 3rd Platform Credential.
    /// </summary>
    public class RetrieveAllActiveThirdPartyLoginPlatformCredentialV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveAllActiveThirdPartyLoginPlatformCredentialV3Builder Builder { get => new RetrieveAllActiveThirdPartyLoginPlatformCredentialV3Builder(); }

        public class RetrieveAllActiveThirdPartyLoginPlatformCredentialV3Builder
            : OperationBuilder<RetrieveAllActiveThirdPartyLoginPlatformCredentialV3Builder>
        {





            internal RetrieveAllActiveThirdPartyLoginPlatformCredentialV3Builder() { }

            internal RetrieveAllActiveThirdPartyLoginPlatformCredentialV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RetrieveAllActiveThirdPartyLoginPlatformCredentialV3 Build(
                string namespace_
            )
            {
                RetrieveAllActiveThirdPartyLoginPlatformCredentialV3 op = new RetrieveAllActiveThirdPartyLoginPlatformCredentialV3(this,
                    namespace_
                );

                op.SetBaseFields<RetrieveAllActiveThirdPartyLoginPlatformCredentialV3Builder>(this);
                return op;
            }

            public List<Model.ModelThirdPartyLoginPlatformCredentialResponse>? Execute(
                string namespace_
            )
            {
                RetrieveAllActiveThirdPartyLoginPlatformCredentialV3 op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<List<Model.ModelThirdPartyLoginPlatformCredentialResponse>?> ExecuteAsync(
                string namespace_
            )
            {
                RetrieveAllActiveThirdPartyLoginPlatformCredentialV3 op = Build(
                    namespace_
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

        private RetrieveAllActiveThirdPartyLoginPlatformCredentialV3(RetrieveAllActiveThirdPartyLoginPlatformCredentialV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveAllActiveThirdPartyLoginPlatformCredentialV3(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/all/clients/active";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ModelThirdPartyLoginPlatformCredentialResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelThirdPartyLoginPlatformCredentialResponse>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelThirdPartyLoginPlatformCredentialResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}