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
    /// AdminDeletePlatformAccountClosureClient
    ///
    /// Delete platform account closure client.
    /// </summary>
    public class AdminDeletePlatformAccountClosureClient : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeletePlatformAccountClosureClientBuilder Builder { get => new AdminDeletePlatformAccountClosureClientBuilder(); }

        public class AdminDeletePlatformAccountClosureClientBuilder
            : OperationBuilder<AdminDeletePlatformAccountClosureClientBuilder>
        {





            internal AdminDeletePlatformAccountClosureClientBuilder() { }

            internal AdminDeletePlatformAccountClosureClientBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeletePlatformAccountClosureClient Build(
                string namespace_,
                string platform
            )
            {
                AdminDeletePlatformAccountClosureClient op = new AdminDeletePlatformAccountClosureClient(this,
                    namespace_,                    
                    platform                    
                );

                op.SetBaseFields<AdminDeletePlatformAccountClosureClientBuilder>(this);
                return op;
            }

            public AdminDeletePlatformAccountClosureClient.Response Execute(
                string namespace_,
                string platform
            )
            {
                AdminDeletePlatformAccountClosureClient op = Build(
                    namespace_,
                    platform
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminDeletePlatformAccountClosureClient.Response> ExecuteAsync(
                string namespace_,
                string platform
            )
            {
                AdminDeletePlatformAccountClosureClient op = Build(
                    namespace_,
                    platform
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

        private AdminDeletePlatformAccountClosureClient(AdminDeletePlatformAccountClosureClientBuilder builder,
            string namespace_,
            string platform
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platform"] = platform;
            
            

            
            
            

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


            protected override string GetFullOperationId() => "Gdpr::PlatformAccountClosureClient::AdminDeletePlatformAccountClosureClient";
        }

        #endregion

        public AdminDeletePlatformAccountClosureClient(
            string namespace_,            
            string platform            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platform"] = platform;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/platforms/{platform}/closure/client";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminDeletePlatformAccountClosureClient.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminDeletePlatformAccountClosureClient.Response()
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