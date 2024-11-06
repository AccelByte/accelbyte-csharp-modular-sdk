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
    /// UpdateSSOPlatformCredential
    ///
    /// This is the API to Delete SSO Platform Credential.
    /// </summary>
    public class UpdateSSOPlatformCredential : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateSSOPlatformCredentialBuilder Builder { get => new UpdateSSOPlatformCredentialBuilder(); }

        public class UpdateSSOPlatformCredentialBuilder
            : OperationBuilder<UpdateSSOPlatformCredentialBuilder>
        {





            internal UpdateSSOPlatformCredentialBuilder() { }

            internal UpdateSSOPlatformCredentialBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateSSOPlatformCredential Build(
                ModelSSOPlatformCredentialRequest body,
                string namespace_,
                string platformId
            )
            {
                UpdateSSOPlatformCredential op = new UpdateSSOPlatformCredential(this,
                    body,                    
                    namespace_,                    
                    platformId                    
                );

                op.SetBaseFields<UpdateSSOPlatformCredentialBuilder>(this);
                return op;
            }

            public UpdateSSOPlatformCredential.Response Execute(
                ModelSSOPlatformCredentialRequest body,
                string namespace_,
                string platformId
            )
            {
                UpdateSSOPlatformCredential op = Build(
                    body,
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
            public async Task<UpdateSSOPlatformCredential.Response> ExecuteAsync(
                ModelSSOPlatformCredentialRequest body,
                string namespace_,
                string platformId
            )
            {
                UpdateSSOPlatformCredential op = Build(
                    body,
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

        private UpdateSSOPlatformCredential(UpdateSSOPlatformCredentialBuilder builder,
            ModelSSOPlatformCredentialRequest body,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelSSOPlatformCredentialResponse>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::SSOCredential::UpdateSSOPlatformCredential";
        }

        #endregion

        public UpdateSSOPlatformCredential(
            string namespace_,            
            string platformId,            
            Model.ModelSSOPlatformCredentialRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/sso";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateSSOPlatformCredential.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateSSOPlatformCredential.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelSSOPlatformCredentialResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
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