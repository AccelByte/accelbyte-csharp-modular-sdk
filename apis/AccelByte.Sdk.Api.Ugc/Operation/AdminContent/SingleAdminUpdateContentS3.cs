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
    /// SingleAdminUpdateContentS3
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENT [UPDATE].
    /// 
    /// All request body are required except `payload`, `preview`, `tags`,`contentType`, `updateContentFile`, `customAttributes` and `shareCode`.
    /// 
    /// `contentType` values is used to enforce the Content-Type header needed by the client to upload the content using the S3 presigned URL.
    /// 
    /// If not specified, it will use `fileExtension` value.
    /// 
    /// To update content file, set `updateContentFile` to `true` and upload the file using URL in `payloadURL.url` in response body.
    /// 
    /// `shareCode` format should follows:
    /// 
    /// Max length: 7
    /// Available characters: abcdefhkpqrstuxyz
    /// 
    /// 
    /// 
    /// 
    ///  NOTE: Preview is Legacy Code, please use Screenshot for better solution to display preview of a content
    /// </summary>
    public class SingleAdminUpdateContentS3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SingleAdminUpdateContentS3Builder Builder { get => new SingleAdminUpdateContentS3Builder(); }

        public class SingleAdminUpdateContentS3Builder
            : OperationBuilder<SingleAdminUpdateContentS3Builder>
        {





            internal SingleAdminUpdateContentS3Builder() { }

            internal SingleAdminUpdateContentS3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SingleAdminUpdateContentS3 Build(
                ModelsAdminUpdateContentRequest body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                SingleAdminUpdateContentS3 op = new SingleAdminUpdateContentS3(this,
                    body,
                    channelId,
                    contentId,
                    namespace_
                );

                op.SetBaseFields<SingleAdminUpdateContentS3Builder>(this);
                return op;
            }

            public SingleAdminUpdateContentS3.Response Execute(
                ModelsAdminUpdateContentRequest body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                SingleAdminUpdateContentS3 op = Build(
                    body,
                    channelId,
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
            public async Task<SingleAdminUpdateContentS3.Response> ExecuteAsync(
                ModelsAdminUpdateContentRequest body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                SingleAdminUpdateContentS3 op = Build(
                    body,
                    channelId,
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

            public SingleAdminUpdateContentS3.Response<T1> Execute<T1>(
                ModelsAdminUpdateContentRequest body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                SingleAdminUpdateContentS3 op = Build(
                    body,
                    channelId,
                    contentId,
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
            public async Task<SingleAdminUpdateContentS3.Response<T1>> ExecuteAsync<T1>(
                ModelsAdminUpdateContentRequest body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                SingleAdminUpdateContentS3 op = Build(
                    body,
                    channelId,
                    contentId,
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

        private SingleAdminUpdateContentS3(SingleAdminUpdateContentS3Builder builder,
            ModelsAdminUpdateContentRequest body,
            string channelId,
            string contentId,
            string namespace_
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsCreateContentResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error409 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::AdminContent::SingleAdminUpdateContentS3";
        }

        public class Response<T1> : ApiResponse<Model.ModelsCreateContentResponse<T1>>
        {
            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error409 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::AdminContent::SingleAdminUpdateContentS3";
        }
        #endregion

        public SingleAdminUpdateContentS3(
            string channelId,
            string contentId,
            string namespace_,
            Model.ModelsAdminUpdateContentRequest body
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/s3/{contentId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public SingleAdminUpdateContentS3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new SingleAdminUpdateContentS3.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsCreateContentResponse>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }

        public SingleAdminUpdateContentS3.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new SingleAdminUpdateContentS3.Response<T1>()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsCreateContentResponse<T1>>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
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