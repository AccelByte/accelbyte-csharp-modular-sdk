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
    /// DeleteContentScreenshot
    ///
    /// Delete existing screenshot from a content
    /// </summary>
    public class DeleteContentScreenshot : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteContentScreenshotBuilder Builder { get => new DeleteContentScreenshotBuilder(); }

        public class DeleteContentScreenshotBuilder
            : OperationBuilder<DeleteContentScreenshotBuilder>
        {





            internal DeleteContentScreenshotBuilder() { }

            internal DeleteContentScreenshotBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteContentScreenshot Build(
                string contentId,
                string namespace_,
                string screenshotId,
                string userId
            )
            {
                DeleteContentScreenshot op = new DeleteContentScreenshot(this,
                    contentId,                    
                    namespace_,                    
                    screenshotId,                    
                    userId                    
                );

                op.SetBaseFields<DeleteContentScreenshotBuilder>(this);
                return op;
            }

            public DeleteContentScreenshot.Response Execute(
                string contentId,
                string namespace_,
                string screenshotId,
                string userId
            )
            {
                DeleteContentScreenshot op = Build(
                    contentId,
                    namespace_,
                    screenshotId,
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
            public async Task<DeleteContentScreenshot.Response> ExecuteAsync(
                string contentId,
                string namespace_,
                string screenshotId,
                string userId
            )
            {
                DeleteContentScreenshot op = Build(
                    contentId,
                    namespace_,
                    screenshotId,
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

        private DeleteContentScreenshot(DeleteContentScreenshotBuilder builder,
            string contentId,
            string namespace_,
            string screenshotId,
            string userId
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["screenshotId"] = screenshotId;
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


            protected override string GetFullOperationId() => "Ugc::PublicContentLegacy::DeleteContentScreenshot";
        }

        #endregion

        public DeleteContentScreenshot(
            string contentId,            
            string namespace_,            
            string screenshotId,            
            string userId            
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["screenshotId"] = screenshotId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots/{screenshotId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json","application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteContentScreenshot.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteContentScreenshot.Response()
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