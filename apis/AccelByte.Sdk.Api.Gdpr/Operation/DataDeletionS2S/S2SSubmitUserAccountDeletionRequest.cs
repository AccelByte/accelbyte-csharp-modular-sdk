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

using AccelByte.Sdk.Api.Gdpr.Model;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// S2SSubmitUserAccountDeletionRequest
    ///
    /// Scope: account
    /// 
    /// Submit user's account deletion request.
    /// 
    /// **Limitation:** This API only accepts requests with a publisher userId and does not support game userId requests at this time.
    /// 
    /// ---
    /// ## This API for S2S integration purpose only
    /// 
    /// **Notes:**
    /// 
    /// 1. This API will **not send GDPR email notification** both for player and admin notification.
    /// 2. This API will **perform account deletion immediately** without GDPR grace period (i.e. 28 days grace period).
    /// </summary>
    public class S2SSubmitUserAccountDeletionRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static S2SSubmitUserAccountDeletionRequestBuilder Builder { get => new S2SSubmitUserAccountDeletionRequestBuilder(); }

        public class S2SSubmitUserAccountDeletionRequestBuilder
            : OperationBuilder<S2SSubmitUserAccountDeletionRequestBuilder>
        {





            internal S2SSubmitUserAccountDeletionRequestBuilder() { }

            internal S2SSubmitUserAccountDeletionRequestBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public S2SSubmitUserAccountDeletionRequest Build(
                string namespace_,
                string userId
            )
            {
                S2SSubmitUserAccountDeletionRequest op = new S2SSubmitUserAccountDeletionRequest(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<S2SSubmitUserAccountDeletionRequestBuilder>(this);
                return op;
            }

            public S2SSubmitUserAccountDeletionRequest.Response Execute(
                string namespace_,
                string userId
            )
            {
                S2SSubmitUserAccountDeletionRequest op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<S2SSubmitUserAccountDeletionRequest.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                S2SSubmitUserAccountDeletionRequest op = Build(
                    namespace_,
                    userId
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

        private S2SSubmitUserAccountDeletionRequest(S2SSubmitUserAccountDeletionRequestBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsS2SRequestDeleteResponse>
        {

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error409 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Gdpr::DataDeletionS2S::S2SSubmitUserAccountDeletionRequest";
        }

        #endregion

        public S2SSubmitUserAccountDeletionRequest(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/s2s/namespaces/{namespace}/users/{userId}/deletions";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "*/*" };

        public override List<string> Produces => new() { "application/json" };
        
        public S2SSubmitUserAccountDeletionRequest.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new S2SSubmitUserAccountDeletionRequest.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsS2SRequestDeleteResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}