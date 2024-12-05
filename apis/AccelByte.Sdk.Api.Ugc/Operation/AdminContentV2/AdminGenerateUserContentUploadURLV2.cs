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
    /// AdminGenerateUserContentUploadURLV2
    ///
    /// generate user content upload URL
    /// </summary>
    public class AdminGenerateUserContentUploadURLV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGenerateUserContentUploadURLV2Builder Builder { get => new AdminGenerateUserContentUploadURLV2Builder(); }

        public class AdminGenerateUserContentUploadURLV2Builder
            : OperationBuilder<AdminGenerateUserContentUploadURLV2Builder>
        {





            internal AdminGenerateUserContentUploadURLV2Builder() { }

            internal AdminGenerateUserContentUploadURLV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGenerateUserContentUploadURLV2 Build(
                ModelsGenerateContentUploadURLRequest body,
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                AdminGenerateUserContentUploadURLV2 op = new AdminGenerateUserContentUploadURLV2(this,
                    body,
                    channelId,
                    contentId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminGenerateUserContentUploadURLV2Builder>(this);
                return op;
            }

            public AdminGenerateUserContentUploadURLV2.Response Execute(
                ModelsGenerateContentUploadURLRequest body,
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                AdminGenerateUserContentUploadURLV2 op = Build(
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
            public async Task<AdminGenerateUserContentUploadURLV2.Response> ExecuteAsync(
                ModelsGenerateContentUploadURLRequest body,
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                AdminGenerateUserContentUploadURLV2 op = Build(
                    body,
                    channelId,
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

        private AdminGenerateUserContentUploadURLV2(AdminGenerateUserContentUploadURLV2Builder builder,
            ModelsGenerateContentUploadURLRequest body,
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

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsGenerateContentUploadURLResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::AdminContentV2::AdminGenerateUserContentUploadURLV2";
        }

        #endregion

        public AdminGenerateUserContentUploadURLV2(
            string channelId,
            string contentId,
            string namespace_,
            string userId,
            Model.ModelsGenerateContentUploadURLRequest body
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}/uploadUrl";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminGenerateUserContentUploadURLV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGenerateUserContentUploadURLV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsGenerateContentUploadURLResponse>(payload, ResponseJsonOptions);
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