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
    /// PublicUpdateContentByShareCode
    ///
    /// Required permission NAMESPACE:{namespace}:USER:{userId}:CONTENT [UPDATE].
    /// 
    /// All request body are required except `payload`, `preview`, `tags`,`contentType`, `updateContentFile`, `customAttributes` and `shareCode`.
    /// 
    /// `contentType` values is used to enforce the Content-Type header needed by the client to upload the content using the S3 presigned URL.
    /// 
    /// If not specified, it will use `fileExtension` value.
    /// 
    /// To update content file, set `updateContentFile` to `true` and upload the file using URL in `payloadURL.url` in response body.
    /// 
    /// 
    /// 
    /// 
    ///  NOTE: Preview is Legacy Code, please use Screenshot for better solution to display preview of a content
    /// </summary>
    public class PublicUpdateContentByShareCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateContentByShareCodeBuilder Builder { get => new PublicUpdateContentByShareCodeBuilder(); }

        public class PublicUpdateContentByShareCodeBuilder
            : OperationBuilder<PublicUpdateContentByShareCodeBuilder>
        {





            internal PublicUpdateContentByShareCodeBuilder() { }

            internal PublicUpdateContentByShareCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicUpdateContentByShareCode Build(
                ModelsUpdateContentRequest body,
                string channelId,
                string namespace_,
                string shareCode,
                string userId
            )
            {
                PublicUpdateContentByShareCode op = new PublicUpdateContentByShareCode(this,
                    body,
                    channelId,
                    namespace_,
                    shareCode,
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
                string namespace_,
                string shareCode,
                string userId
            )
            {
                PublicUpdateContentByShareCode op = Build(
                    body,
                    channelId,
                    namespace_,
                    shareCode,
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
                string namespace_,
                string shareCode,
                string userId
            )
            {
                PublicUpdateContentByShareCode op = Build(
                    body,
                    channelId,
                    namespace_,
                    shareCode,
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

        private PublicUpdateContentByShareCode(PublicUpdateContentByShareCodeBuilder builder,
            ModelsUpdateContentRequest body,
            string channelId,
            string namespace_,
            string shareCode,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpdateContentByShareCode(
            string channelId,
            string namespace_,
            string shareCode,
            string userId,
            Model.ModelsUpdateContentRequest body
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/sharecodes/{shareCode}";

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