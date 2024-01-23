// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3
    ///
    /// This is the Public API to Get All Active 3rd Platform Credential.
    /// </summary>
    public class RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder Builder { get => new RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder(); }

        public class RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder
            : OperationBuilder<RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder>
        {





            internal RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder() { }

            internal RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 Build(
                string namespace_
            )
            {
                RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 op = new RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3(this,
                    namespace_
                );

                op.SetBaseFields<RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder>(this);
                return op;
            }

            public List<Model.ModelPublicThirdPartyPlatformInfo>? Execute(
                string namespace_
            )
            {
                RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 op = Build(
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
        }

        private RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3(RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/platforms/clients/active";

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