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
    /// UpdateScreenshotsV2
    ///
    /// Maximum description length: 1024
    /// </summary>
    public class UpdateScreenshotsV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateScreenshotsV2Builder Builder { get => new UpdateScreenshotsV2Builder(); }

        public class UpdateScreenshotsV2Builder
            : OperationBuilder<UpdateScreenshotsV2Builder>
        {





            internal UpdateScreenshotsV2Builder() { }

            internal UpdateScreenshotsV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateScreenshotsV2 Build(
                ModelsUpdateScreenshotRequest body,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UpdateScreenshotsV2 op = new UpdateScreenshotsV2(this,
                    body,                    
                    contentId,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<UpdateScreenshotsV2Builder>(this);
                return op;
            }

            public UpdateScreenshotsV2.Response Execute(
                ModelsUpdateScreenshotRequest body,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UpdateScreenshotsV2 op = Build(
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
            public async Task<UpdateScreenshotsV2.Response> ExecuteAsync(
                ModelsUpdateScreenshotRequest body,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UpdateScreenshotsV2 op = Build(
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

        private UpdateScreenshotsV2(UpdateScreenshotsV2Builder builder,
            ModelsUpdateScreenshotRequest body,
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
        public class Response : ApiResponse<Model.ModelsUpdateScreenshotResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::PublicContentV2::UpdateScreenshotsV2";
        }

        #endregion

        public UpdateScreenshotsV2(
            string contentId,            
            string namespace_,            
            string userId,            
            Model.ModelsUpdateScreenshotRequest body            
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json","application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateScreenshotsV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateScreenshotsV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsUpdateScreenshotResponse>(payload, ResponseJsonOptions);
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