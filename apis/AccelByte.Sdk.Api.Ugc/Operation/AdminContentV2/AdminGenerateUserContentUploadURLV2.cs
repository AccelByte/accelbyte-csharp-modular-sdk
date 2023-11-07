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
    /// AdminGenerateUserContentUploadURLV2
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENT [UPDATE].
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
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsGenerateContentUploadURLResponse? Execute(
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

        public Model.ModelsGenerateContentUploadURLResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGenerateContentUploadURLResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGenerateContentUploadURLResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}