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
    /// AdminUploadContentScreenshotV2
    ///
    /// This endpoint used to request upload URL from content's screenshot.
    /// If *contentType* is not specified, it will use *fileExtension* value.
    /// Supported file extensions: pjp, jpg, jpeg, jfif, bmp, png.
    /// Maximum description length: 1024
    /// </summary>
    public class AdminUploadContentScreenshotV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUploadContentScreenshotV2Builder Builder { get => new AdminUploadContentScreenshotV2Builder(); }

        public class AdminUploadContentScreenshotV2Builder
            : OperationBuilder<AdminUploadContentScreenshotV2Builder>
        {





            internal AdminUploadContentScreenshotV2Builder() { }

            internal AdminUploadContentScreenshotV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUploadContentScreenshotV2 Build(
                ModelsCreateScreenshotRequest body,
                string contentId,
                string namespace_
            )
            {
                AdminUploadContentScreenshotV2 op = new AdminUploadContentScreenshotV2(this,
                    body,                    
                    contentId,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminUploadContentScreenshotV2Builder>(this);
                return op;
            }

            public AdminUploadContentScreenshotV2.Response Execute(
                ModelsCreateScreenshotRequest body,
                string contentId,
                string namespace_
            )
            {
                AdminUploadContentScreenshotV2 op = Build(
                    body,
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
            public async Task<AdminUploadContentScreenshotV2.Response> ExecuteAsync(
                ModelsCreateScreenshotRequest body,
                string contentId,
                string namespace_
            )
            {
                AdminUploadContentScreenshotV2 op = Build(
                    body,
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

        private AdminUploadContentScreenshotV2(AdminUploadContentScreenshotV2Builder builder,
            ModelsCreateScreenshotRequest body,
            string contentId,
            string namespace_
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            
            

            
            
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


            protected override string GetFullOperationId() => "Ugc::AdminContentV2::AdminUploadContentScreenshotV2";
        }

        #endregion

        public AdminUploadContentScreenshotV2(
            string contentId,            
            string namespace_,            
            Model.ModelsCreateScreenshotRequest body            
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/contents/{contentId}/screenshots";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminUploadContentScreenshotV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminUploadContentScreenshotV2.Response()
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