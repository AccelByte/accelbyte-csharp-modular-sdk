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
    /// AdminCancelUserAccountDeletionRequest
    ///
    /// Cancel user's account deletion request
    /// Scope: account
    /// </summary>
    public class AdminCancelUserAccountDeletionRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCancelUserAccountDeletionRequestBuilder Builder { get => new AdminCancelUserAccountDeletionRequestBuilder(); }

        public class AdminCancelUserAccountDeletionRequestBuilder
            : OperationBuilder<AdminCancelUserAccountDeletionRequestBuilder>
        {





            internal AdminCancelUserAccountDeletionRequestBuilder() { }

            internal AdminCancelUserAccountDeletionRequestBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCancelUserAccountDeletionRequest Build(
                string namespace_,
                string userId
            )
            {
                AdminCancelUserAccountDeletionRequest op = new AdminCancelUserAccountDeletionRequest(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<AdminCancelUserAccountDeletionRequestBuilder>(this);
                return op;
            }

            public AdminCancelUserAccountDeletionRequest.Response Execute(
                string namespace_,
                string userId
            )
            {
                AdminCancelUserAccountDeletionRequest op = Build(
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
            public async Task<AdminCancelUserAccountDeletionRequest.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                AdminCancelUserAccountDeletionRequest op = Build(
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

        private AdminCancelUserAccountDeletionRequest(AdminCancelUserAccountDeletionRequestBuilder builder,
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
        public class Response : ApiResponse
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Gdpr::DataDeletion::AdminCancelUserAccountDeletionRequest";
        }

        #endregion

        public AdminCancelUserAccountDeletionRequest(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/users/{userId}/deletions";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminCancelUserAccountDeletionRequest.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminCancelUserAccountDeletionRequest.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
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
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}