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
    /// PublicDownloadContentPreview
    ///
    /// 
    /// 
    /// Requires valid user token
    /// 
    ///  NOTE: Preview is Legacy Code, please use Screenshot for better solution to display preview of a content
    /// </summary>
    public class PublicDownloadContentPreview : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDownloadContentPreviewBuilder Builder { get => new PublicDownloadContentPreviewBuilder(); }

        public class PublicDownloadContentPreviewBuilder
            : OperationBuilder<PublicDownloadContentPreviewBuilder>
        {





            internal PublicDownloadContentPreviewBuilder() { }

            internal PublicDownloadContentPreviewBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicDownloadContentPreview Build(
                string contentId,
                string namespace_
            )
            {
                PublicDownloadContentPreview op = new PublicDownloadContentPreview(this,
                    contentId,                    
                    namespace_                    
                );

                op.SetBaseFields<PublicDownloadContentPreviewBuilder>(this);
                return op;
            }

            public PublicDownloadContentPreview.Response Execute(
                string contentId,
                string namespace_
            )
            {
                PublicDownloadContentPreview op = Build(
                    contentId,
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
            public async Task<PublicDownloadContentPreview.Response> ExecuteAsync(
                string contentId,
                string namespace_
            )
            {
                PublicDownloadContentPreview op = Build(
                    contentId,
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
        }

        private PublicDownloadContentPreview(PublicDownloadContentPreviewBuilder builder,
            string contentId,
            string namespace_
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsGetContentPreviewResponse>
        {

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::PublicContentLegacy::PublicDownloadContentPreview";
        }

        #endregion

        public PublicDownloadContentPreview(
            string contentId,            
            string namespace_            
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/contents/{contentId}/preview";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json","application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicDownloadContentPreview.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicDownloadContentPreview.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsGetContentPreviewResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
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