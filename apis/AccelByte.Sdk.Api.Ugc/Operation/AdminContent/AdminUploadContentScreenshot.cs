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
    /// AdminUploadContentScreenshot
    ///
    /// All request body are required except for *contentType* field.
    /// *contentType* values is used to enforce the *Content-Type* header needed by the client to upload the content using the presigned URL.
    /// If not specified, it will use *fileExtension* value.
    /// Supported file extensions: *pjp*, *jpg*, *jpeg*, *jfif*, *bmp*, *png*.
    /// Maximum description length: 1024
    /// </summary>
    public class AdminUploadContentScreenshot : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUploadContentScreenshotBuilder Builder { get => new AdminUploadContentScreenshotBuilder(); }

        public class AdminUploadContentScreenshotBuilder
            : OperationBuilder<AdminUploadContentScreenshotBuilder>
        {





            internal AdminUploadContentScreenshotBuilder() { }

            internal AdminUploadContentScreenshotBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUploadContentScreenshot Build(
                ModelsCreateScreenshotRequest body,
                string contentId,
                string namespace_
            )
            {
                AdminUploadContentScreenshot op = new AdminUploadContentScreenshot(this,
                    body,
                    contentId,
                    namespace_
                );

                op.SetBaseFields<AdminUploadContentScreenshotBuilder>(this);
                return op;
            }

            public Model.ModelsCreateScreenshotResponse? Execute(
                ModelsCreateScreenshotRequest body,
                string contentId,
                string namespace_
            )
            {
                AdminUploadContentScreenshot op = Build(
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
            public async Task<Model.ModelsCreateScreenshotResponse?> ExecuteAsync(
                ModelsCreateScreenshotRequest body,
                string contentId,
                string namespace_
            )
            {
                AdminUploadContentScreenshot op = Build(
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

        private AdminUploadContentScreenshot(AdminUploadContentScreenshotBuilder builder,
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

        public AdminUploadContentScreenshot(
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

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/screenshots";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

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