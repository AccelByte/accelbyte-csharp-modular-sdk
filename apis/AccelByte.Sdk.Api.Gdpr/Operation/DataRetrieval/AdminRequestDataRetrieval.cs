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
    /// AdminRequestDataRetrieval
    ///
    /// Submit user personal data retrieval request.
    /// Scope: account
    /// 
    /// ### Request Header:
    /// - **Content-Type: application/x-www-form-urlencoded**
    /// </summary>
    public class AdminRequestDataRetrieval : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRequestDataRetrievalBuilder Builder { get => new AdminRequestDataRetrievalBuilder(); }

        public class AdminRequestDataRetrievalBuilder
            : OperationBuilder<AdminRequestDataRetrievalBuilder>
        {



            public string? Password { get; set; }



            internal AdminRequestDataRetrievalBuilder() { }

            internal AdminRequestDataRetrievalBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public AdminRequestDataRetrievalBuilder SetPassword(string _password)
            {
                Password = _password;
                return this;
            }



            public AdminRequestDataRetrieval Build(
                string namespace_,
                string userId
            )
            {
                AdminRequestDataRetrieval op = new AdminRequestDataRetrieval(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<AdminRequestDataRetrievalBuilder>(this);
                return op;
            }

            public AdminRequestDataRetrieval.Response Execute(
                string namespace_,
                string userId
            )
            {
                AdminRequestDataRetrieval op = Build(
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
            public async Task<AdminRequestDataRetrieval.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                AdminRequestDataRetrieval op = Build(
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

        private AdminRequestDataRetrieval(AdminRequestDataRetrievalBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            if (builder.Password is not null) FormParams["password"] = builder.Password;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsDataRetrievalResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error429 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Gdpr::DataRetrieval::AdminRequestDataRetrieval";
        }

        #endregion

        public AdminRequestDataRetrieval(
            string namespace_,            
            string userId,            
            string? password            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            if (password is not null) FormParams["password"] = password;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/users/{userId}/requests";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminRequestDataRetrieval.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminRequestDataRetrieval.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsDataRetrievalResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)429)
            {
                response.Error429 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error429!.TranslateToApiError();
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