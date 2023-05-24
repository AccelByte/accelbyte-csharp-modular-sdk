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
    /// RetrieveSSOLoginPlatformCredential
    ///
    /// This is the API to Get SSO Platform Credential. It needs ADMIN:NAMESPACE:{namespace}:PLATFORM:{platformId}:SSO [READ] resource
    /// </summary>
    public class RetrieveSSOLoginPlatformCredential : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveSSOLoginPlatformCredentialBuilder Builder { get => new RetrieveSSOLoginPlatformCredentialBuilder(); }

        public class RetrieveSSOLoginPlatformCredentialBuilder
            : OperationBuilder<RetrieveSSOLoginPlatformCredentialBuilder>
        {





            internal RetrieveSSOLoginPlatformCredentialBuilder() { }

            internal RetrieveSSOLoginPlatformCredentialBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RetrieveSSOLoginPlatformCredential Build(
                string namespace_,
                string platformId
            )
            {
                RetrieveSSOLoginPlatformCredential op = new RetrieveSSOLoginPlatformCredential(this,
                    namespace_,
                    platformId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelSSOPlatformCredentialResponse? Execute(
                string namespace_,
                string platformId
            )
            {
                RetrieveSSOLoginPlatformCredential op = Build(
                    namespace_,
                    platformId
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

        private RetrieveSSOLoginPlatformCredential(RetrieveSSOLoginPlatformCredentialBuilder builder,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveSSOLoginPlatformCredential(
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/sso";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelSSOPlatformCredentialResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelSSOPlatformCredentialResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelSSOPlatformCredentialResponse>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}