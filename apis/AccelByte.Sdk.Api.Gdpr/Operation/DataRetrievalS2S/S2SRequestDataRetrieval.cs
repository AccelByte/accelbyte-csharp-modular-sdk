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
    /// S2SRequestDataRetrieval
    ///
    /// Scope: account
    /// 
    /// Submit user personal data retrieval request.
    /// 
    /// **Limitation:** This API only accepts requests with a publisher userId and does not support game userId requests at this time.
    /// 
    /// ---
    /// ## This API for S2S integration purpose only
    /// 
    /// **Notes:**
    /// 
    /// 1. This API will **not send GDPR email notification** both for player and admin notification.
    /// </summary>
    public class S2SRequestDataRetrieval : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static S2SRequestDataRetrievalBuilder Builder { get => new S2SRequestDataRetrievalBuilder(); }

        public class S2SRequestDataRetrievalBuilder
            : OperationBuilder<S2SRequestDataRetrievalBuilder>
        {





            internal S2SRequestDataRetrievalBuilder() { }

            internal S2SRequestDataRetrievalBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public S2SRequestDataRetrieval Build(
                string namespace_,
                string userId
            )
            {
                S2SRequestDataRetrieval op = new S2SRequestDataRetrieval(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<S2SRequestDataRetrievalBuilder>(this);
                return op;
            }

            public S2SRequestDataRetrieval.Response Execute(
                string namespace_,
                string userId
            )
            {
                S2SRequestDataRetrieval op = Build(
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
            public async Task<S2SRequestDataRetrieval.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                S2SRequestDataRetrieval op = Build(
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

        private S2SRequestDataRetrieval(S2SRequestDataRetrievalBuilder builder,
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
        public class Response : ApiResponse<Model.ModelsS2SDataRetrievalResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Gdpr::DataRetrievalS2S::S2SRequestDataRetrieval";
        }

        #endregion

        public S2SRequestDataRetrieval(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/s2s/namespaces/{namespace}/users/{userId}/requests";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "*/*" };

        public override List<string> Produces => new() { "application/json" };
        
        public S2SRequestDataRetrieval.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new S2SRequestDataRetrieval.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsS2SDataRetrievalResponse>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}