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
    /// RetrieveThirdPartyLoginPlatformCredentialV3
    ///
    /// This is the API to Get 3rd Platform Credential.
    /// </summary>
    public class RetrieveThirdPartyLoginPlatformCredentialV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveThirdPartyLoginPlatformCredentialV3Builder Builder { get => new RetrieveThirdPartyLoginPlatformCredentialV3Builder(); }

        public class RetrieveThirdPartyLoginPlatformCredentialV3Builder
            : OperationBuilder<RetrieveThirdPartyLoginPlatformCredentialV3Builder>
        {





            internal RetrieveThirdPartyLoginPlatformCredentialV3Builder() { }

            internal RetrieveThirdPartyLoginPlatformCredentialV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RetrieveThirdPartyLoginPlatformCredentialV3 Build(
                string namespace_,
                string platformId
            )
            {
                RetrieveThirdPartyLoginPlatformCredentialV3 op = new RetrieveThirdPartyLoginPlatformCredentialV3(this,
                    namespace_,
                    platformId
                );

                op.SetBaseFields<RetrieveThirdPartyLoginPlatformCredentialV3Builder>(this);
                return op;
            }

            public RetrieveThirdPartyLoginPlatformCredentialV3.Response Execute(
                string namespace_,
                string platformId
            )
            {
                RetrieveThirdPartyLoginPlatformCredentialV3 op = Build(
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
            public async Task<RetrieveThirdPartyLoginPlatformCredentialV3.Response> ExecuteAsync(
                string namespace_,
                string platformId
            )
            {
                RetrieveThirdPartyLoginPlatformCredentialV3 op = Build(
                    namespace_,
                    platformId
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

        private RetrieveThirdPartyLoginPlatformCredentialV3(RetrieveThirdPartyLoginPlatformCredentialV3Builder builder,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelThirdPartyLoginPlatformCredentialResponse>
        {

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::ThirdPartyCredential::RetrieveThirdPartyLoginPlatformCredentialV3";
        }

        #endregion

        public RetrieveThirdPartyLoginPlatformCredentialV3(
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public RetrieveThirdPartyLoginPlatformCredentialV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RetrieveThirdPartyLoginPlatformCredentialV3.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelThirdPartyLoginPlatformCredentialResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}