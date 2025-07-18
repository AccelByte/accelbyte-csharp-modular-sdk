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
    /// DeleteSSOLoginPlatformCredentialV3
    ///
    /// This is the API to Delete SSO Platform Credential.
    /// </summary>
    public class DeleteSSOLoginPlatformCredentialV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteSSOLoginPlatformCredentialV3Builder Builder { get => new DeleteSSOLoginPlatformCredentialV3Builder(); }

        public class DeleteSSOLoginPlatformCredentialV3Builder
            : OperationBuilder<DeleteSSOLoginPlatformCredentialV3Builder>
        {





            internal DeleteSSOLoginPlatformCredentialV3Builder() { }

            internal DeleteSSOLoginPlatformCredentialV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteSSOLoginPlatformCredentialV3 Build(
                string namespace_,
                string platformId
            )
            {
                DeleteSSOLoginPlatformCredentialV3 op = new DeleteSSOLoginPlatformCredentialV3(this,
                    namespace_,                    
                    platformId                    
                );

                op.SetBaseFields<DeleteSSOLoginPlatformCredentialV3Builder>(this);
                return op;
            }

            public DeleteSSOLoginPlatformCredentialV3.Response Execute(
                string namespace_,
                string platformId
            )
            {
                DeleteSSOLoginPlatformCredentialV3 op = Build(
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
            public async Task<DeleteSSOLoginPlatformCredentialV3.Response> ExecuteAsync(
                string namespace_,
                string platformId
            )
            {
                DeleteSSOLoginPlatformCredentialV3 op = Build(
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

        private DeleteSSOLoginPlatformCredentialV3(DeleteSSOLoginPlatformCredentialV3Builder builder,
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
        public class Response : ApiResponse
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::SSOCredential::DeleteSSOLoginPlatformCredentialV3";
        }

        #endregion

        public DeleteSSOLoginPlatformCredentialV3(
            string namespace_,            
            string platformId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/sso";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteSSOLoginPlatformCredentialV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteSSOLoginPlatformCredentialV3.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
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