// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// UploadContentScreenshot
    ///
    /// Required permission NAMESPACE:{namespace}:USER:{userId}:CONTENT [CREATE].
    /// 
    /// All request body are required except for contentType field.
    /// contentType values is used to enforce the Content-Type header needed by the client to upload the content using the presigned URL.
    /// If not specified, it will use fileExtension value.
    /// Supported file extensions: pjp, jpg, jpeg, jfif, bmp, png.
    /// 
    /// Maximum description length: 1024.
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
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsCreateScreenshotResponse? Execute(
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

        public override List<string> Consumes => new() { "application/json", "application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsCreateScreenshotResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateScreenshotResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateScreenshotResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}