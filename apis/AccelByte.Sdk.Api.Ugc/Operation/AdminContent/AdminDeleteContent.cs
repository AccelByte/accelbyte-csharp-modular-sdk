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
    /// AdminDeleteContent
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENT [DELETE].
    /// </summary>
    public class AdminDeleteContent : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteContentBuilder Builder { get => new AdminDeleteContentBuilder(); }

        public class AdminDeleteContentBuilder
            : OperationBuilder<AdminDeleteContentBuilder>
        {





            internal AdminDeleteContentBuilder() { }

            internal AdminDeleteContentBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteContent Build(
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                AdminDeleteContent op = new AdminDeleteContent(this,
                    channelId,
                    contentId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminDeleteContentBuilder>(this);
                return op;
            }

            public AdminDeleteContent.Response Execute(
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                AdminDeleteContent op = Build(
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
            public async Task<AdminDeleteContent.Response> ExecuteAsync(
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                AdminDeleteContent op = Build(
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

        private AdminDeleteContent(AdminDeleteContentBuilder builder,
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







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::AdminContent::AdminDeleteContent";
        }

        #endregion

        public AdminDeleteContent(
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







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminDeleteContent.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminDeleteContent.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)401)

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