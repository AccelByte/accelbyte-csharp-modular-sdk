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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// PublicBulkGetContentByIDV2
    ///
    /// Maximum requested Ids: 100.
    /// Public user can access without token or if token specified, requires valid user token
    /// </summary>
    public class PublicBulkGetContentByIDV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicBulkGetContentByIDV2Builder Builder { get => new PublicBulkGetContentByIDV2Builder(); }

        public class PublicBulkGetContentByIDV2Builder
            : OperationBuilder<PublicBulkGetContentByIDV2Builder>
        {





            internal PublicBulkGetContentByIDV2Builder() { }

            internal PublicBulkGetContentByIDV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicBulkGetContentByIDV2 Build(
                ModelsPublicGetContentBulkRequest body,
                string namespace_
            )
            {
                PublicBulkGetContentByIDV2 op = new PublicBulkGetContentByIDV2(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<PublicBulkGetContentByIDV2Builder>(this);
                return op;
            }

            public PublicBulkGetContentByIDV2.Response Execute(
                ModelsPublicGetContentBulkRequest body,
                string namespace_
            )
            {
                PublicBulkGetContentByIDV2 op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicBulkGetContentByIDV2.Response> ExecuteAsync(
                ModelsPublicGetContentBulkRequest body,
                string namespace_
            )
            {
                PublicBulkGetContentByIDV2 op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }

            public PublicBulkGetContentByIDV2.Response<T1> Execute<T1>(
                ModelsPublicGetContentBulkRequest body,
                string namespace_
            )
            {
                PublicBulkGetContentByIDV2 op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicBulkGetContentByIDV2.Response<T1>> ExecuteAsync<T1>(
                ModelsPublicGetContentBulkRequest body,
                string namespace_
            )
            {
                PublicBulkGetContentByIDV2 op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicBulkGetContentByIDV2(PublicBulkGetContentByIDV2Builder builder,
            ModelsPublicGetContentBulkRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.ModelsContentDownloadResponseV2>>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::PublicContentV2::PublicBulkGetContentByIDV2";
        }

        public class Response<T1> : ApiResponse<List<Model.ModelsContentDownloadResponseV2<T1>>>
        {
            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::PublicContentV2::PublicBulkGetContentByIDV2";
        }
        #endregion

        public PublicBulkGetContentByIDV2(
            string namespace_,            
            Model.ModelsPublicGetContentBulkRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/public/namespaces/{namespace}/contents/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json","application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicBulkGetContentByIDV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicBulkGetContentByIDV2.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponseV2>>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }

        public PublicBulkGetContentByIDV2.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicBulkGetContentByIDV2.Response<T1>()
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
                response.Data = JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponseV2<T1>>>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }
            
            return response;
        }
    }

}