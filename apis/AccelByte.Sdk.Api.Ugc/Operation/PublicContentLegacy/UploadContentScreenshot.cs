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
    /// UploadContentScreenshot
    ///
    /// All request body are required except for *contentType* field.
    /// *contentType* values is used to enforce the *Content-Type* header needed by the client to upload the content using the presigned URL.
    /// If not specified, it will use *fileExtension* value.
    /// Supported file extensions: *pjp*, *jpg*, *jpeg*, *jfif*, *bmp*, *png*.
    /// Maximum description length: 1024
    /// </summary>
    public class UploadContentScreenshot : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UploadContentScreenshotBuilder Builder { get => new UploadContentScreenshotBuilder(); }

        public class UploadContentScreenshotBuilder
            : OperationBuilder<UploadContentScreenshotBuilder>
        {





            internal UploadContentScreenshotBuilder() { }

            internal UploadContentScreenshotBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UploadContentScreenshot Build(
                ModelsCreateScreenshotRequest body,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UploadContentScreenshot op = new UploadContentScreenshot(this,
                    body,                    
                    contentId,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<UploadContentScreenshotBuilder>(this);
                return op;
            }

            public UploadContentScreenshot.Response Execute(
                ModelsCreateScreenshotRequest body,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UploadContentScreenshot op = Build(
                    body,
                    contentId,
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
            public async Task<UploadContentScreenshot.Response> ExecuteAsync(
                ModelsCreateScreenshotRequest body,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UploadContentScreenshot op = Build(
                    body,
                    contentId,
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

        private UploadContentScreenshot(UploadContentScreenshotBuilder builder,
            ModelsCreateScreenshotRequest body,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsCreateScreenshotResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::PublicContentLegacy::UploadContentScreenshot";
        }

        #endregion

        public UploadContentScreenshot(
            string contentId,            
            string namespace_,            
            string userId,            
            Model.ModelsCreateScreenshotRequest body            
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json","application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };
        
        public UploadContentScreenshot.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UploadContentScreenshot.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsCreateScreenshotResponse>(payload, ResponseJsonOptions);
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