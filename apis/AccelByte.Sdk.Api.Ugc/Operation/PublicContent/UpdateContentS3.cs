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
    /// UpdateContentS3
    ///
    /// Required permission NAMESPACE:{namespace}:USER:{userId}:CONTENT [UPDATE].
    /// All request body are required except payload, preview, tags, contentType, updateContentFile and customAttributes.
    /// contentType values is used to enforce the Content-Type header needed by the client to upload the content using the S3 presigned URL.
    /// If not specified, it will use fileExtension value.
    /// To update content's file, set `updateContentFile` to `true` and upload the file using URL in `payloadURL.url` in response body.
    /// 
    /// 
    /// 
    /// NOTE: Preview is Legacy Code, please use Screenshot for better solution to display preview of a content
    /// </summary>
    public class UpdateContentS3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateContentS3Builder Builder { get => new UpdateContentS3Builder(); }

        public class UpdateContentS3Builder
            : OperationBuilder<UpdateContentS3Builder>
        {





            internal UpdateContentS3Builder() { }

            internal UpdateContentS3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateContentS3 Build(
                ModelsUpdateContentRequest body,
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UpdateContentS3 op = new UpdateContentS3(this,
                    body,
                    channelId,
                    contentId,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsCreateContentResponse? Execute(
                ModelsUpdateContentRequest body,
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UpdateContentS3 op = Build(
                    body,
                    channelId,
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

            public Model.ModelsCreateContentResponse<T1>? Execute<T1>(
                ModelsUpdateContentRequest body,
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UpdateContentS3 op = Build(
                    body,
                    channelId,
                    contentId,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private UpdateContentS3(UpdateContentS3Builder builder,
            ModelsUpdateContentRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateContentS3(
            string channelId,
            string contentId,
            string namespace_,
            string userId,
            Model.ModelsUpdateContentRequest body
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/{contentId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json", "application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsCreateContentResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateContentResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateContentResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsCreateContentResponse<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateContentResponse<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateContentResponse<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}