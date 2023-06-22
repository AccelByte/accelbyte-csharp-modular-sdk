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
    /// DeleteThirdPartyLoginPlatformCredentialV3
    ///
    /// This is the API to Delete 3rd Platform Credential. It needs ADMIN:NAMESPACE:{namespace}:PLATFORM:{platformId}:CLIENT [DELETE] resource
    /// </summary>
    public class DeleteThirdPartyLoginPlatformCredentialV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteThirdPartyLoginPlatformCredentialV3Builder Builder { get => new DeleteThirdPartyLoginPlatformCredentialV3Builder(); }

        public class DeleteThirdPartyLoginPlatformCredentialV3Builder
            : OperationBuilder<DeleteThirdPartyLoginPlatformCredentialV3Builder>
        {





            internal DeleteThirdPartyLoginPlatformCredentialV3Builder() { }

            internal DeleteThirdPartyLoginPlatformCredentialV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteThirdPartyLoginPlatformCredentialV3 Build(
                string namespace_,
                string platformId
            )
            {
                DeleteThirdPartyLoginPlatformCredentialV3 op = new DeleteThirdPartyLoginPlatformCredentialV3(this,
                    namespace_,
                    platformId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string namespace_,
                string platformId
            )
            {
                DeleteThirdPartyLoginPlatformCredentialV3 op = Build(
                    namespace_,
                    platformId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private DeleteThirdPartyLoginPlatformCredentialV3(DeleteThirdPartyLoginPlatformCredentialV3Builder builder,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteThirdPartyLoginPlatformCredentialV3(
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}