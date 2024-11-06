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
    /// AdminUpdateContentS3ByShareCode
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
    public class AdminUpdateContentS3ByShareCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateContentS3ByShareCodeBuilder Builder { get => new AdminUpdateContentS3ByShareCodeBuilder(); }

        public class AdminUpdateContentS3ByShareCodeBuilder
            : OperationBuilder<AdminUpdateContentS3ByShareCodeBuilder>
        {





            internal AdminUpdateContentS3ByShareCodeBuilder() { }

            internal AdminUpdateContentS3ByShareCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateContentS3ByShareCode Build(
                ModelsAdminUpdateContentRequest body,
                string channelId,
                string namespace_,
                string shareCode,
                string userId
            )
            {
                AdminUpdateContentS3ByShareCode op = new AdminUpdateContentS3ByShareCode(this,
                    body,                    
                    channelId,                    
                    namespace_,                    
                    shareCode,                    
                    userId                    
                );

                op.SetBaseFields<AdminUpdateContentS3ByShareCodeBuilder>(this);
                return op;
            }

            public AdminUpdateContentS3ByShareCode.Response Execute(
                ModelsAdminUpdateContentRequest body,
                string channelId,
                string namespace_,
                string shareCode,
                string userId
            )
            {
                AdminUpdateContentS3ByShareCode op = Build(
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
            public async Task<AdminUpdateContentS3ByShareCode.Response> ExecuteAsync(
                ModelsAdminUpdateContentRequest body,
                string channelId,
                string namespace_,
                string shareCode,
                string userId
            )
            {
                AdminUpdateContentS3ByShareCode op = Build(
                    body,
                    channelId,
                    namespace_,
                    shareCode,
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

            public AdminUpdateContentS3ByShareCode.Response<T1> Execute<T1>(
                ModelsAdminUpdateContentRequest body,
                string channelId,
                string namespace_,
                string shareCode,
                string userId
            )
            {
                AdminUpdateContentS3ByShareCode op = Build(
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
            public async Task<AdminUpdateContentS3ByShareCode.Response<T1>> ExecuteAsync<T1>(
                ModelsAdminUpdateContentRequest body,
                string channelId,
                string namespace_,
                string shareCode,
                string userId
            )
            {
                AdminUpdateContentS3ByShareCode op = Build(
                    body,
                    channelId,
                    namespace_,
                    shareCode,
                    userId
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

        private AdminUpdateContentS3ByShareCode(AdminUpdateContentS3ByShareCodeBuilder builder,
            ModelsAdminUpdateContentRequest body,
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

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsCreateContentResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error409 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::AdminContent::AdminUpdateContentS3ByShareCode";
        }

        public class Response<T1> : ApiResponse<Model.ModelsCreateContentResponse<T1>>
        {
            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error409 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::AdminContent::AdminUpdateContentS3ByShareCode";
        }
        #endregion

        public AdminUpdateContentS3ByShareCode(
            string channelId,            
            string namespace_,            
            string shareCode,            
            string userId,            
            Model.ModelsAdminUpdateContentRequest body            
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/sharecodes/{shareCode}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminUpdateContentS3ByShareCode.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminUpdateContentS3ByShareCode.Response()
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

        public AdminUpdateContentS3ByShareCode.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminUpdateContentS3ByShareCode.Response<T1>()
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