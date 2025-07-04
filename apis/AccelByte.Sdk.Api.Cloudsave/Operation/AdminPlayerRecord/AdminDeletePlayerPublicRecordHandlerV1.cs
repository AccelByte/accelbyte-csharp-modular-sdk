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

using AccelByte.Sdk.Api.Cloudsave.Model;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// adminDeletePlayerPublicRecordHandlerV1
    ///
    /// Delete player public record.
    /// 
    /// 
    /// ## Warning: This endpoint is going to deprecate
    /// 
    /// This endpoint is going to deprecate in the future please don't use it.
    /// 
    /// For alternative, please use these endpoints:
    /// - **POST /cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}** and utilizing **__META** functionality
    /// - **PUT /cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}** and utilizing **__META** functionality
    /// - **DELETE /cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}**
    /// </summary>
    public class AdminDeletePlayerPublicRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeletePlayerPublicRecordHandlerV1Builder Builder { get => new AdminDeletePlayerPublicRecordHandlerV1Builder(); }

        public class AdminDeletePlayerPublicRecordHandlerV1Builder
            : OperationBuilder<AdminDeletePlayerPublicRecordHandlerV1Builder>
        {





            internal AdminDeletePlayerPublicRecordHandlerV1Builder() { }

            internal AdminDeletePlayerPublicRecordHandlerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeletePlayerPublicRecordHandlerV1 Build(
                string key,
                string namespace_,
                string userId
            )
            {
                AdminDeletePlayerPublicRecordHandlerV1 op = new AdminDeletePlayerPublicRecordHandlerV1(this,
                    key,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<AdminDeletePlayerPublicRecordHandlerV1Builder>(this);
                return op;
            }

            public AdminDeletePlayerPublicRecordHandlerV1.Response Execute(
                string key,
                string namespace_,
                string userId
            )
            {
                AdminDeletePlayerPublicRecordHandlerV1 op = Build(
                    key,
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
            public async Task<AdminDeletePlayerPublicRecordHandlerV1.Response> ExecuteAsync(
                string key,
                string namespace_,
                string userId
            )
            {
                AdminDeletePlayerPublicRecordHandlerV1 op = Build(
                    key,
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

        private AdminDeletePlayerPublicRecordHandlerV1(AdminDeletePlayerPublicRecordHandlerV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ModelsResponseError? Error400 { get; set; } = null;

            public ModelsResponseError? Error401 { get; set; } = null;

            public ModelsResponseError? Error403 { get; set; } = null;

            public ModelsResponseError? Error404 { get; set; } = null;

            public ModelsResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Cloudsave::AdminPlayerRecord::AdminDeletePlayerPublicRecordHandlerV1";
        }

        #endregion

        public AdminDeletePlayerPublicRecordHandlerV1(
            string key,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminDeletePlayerPublicRecordHandlerV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminDeletePlayerPublicRecordHandlerV1.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            
            {
                response.Error403 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            
            {
                response.Error404 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}