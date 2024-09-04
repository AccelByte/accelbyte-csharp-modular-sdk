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
    /// AdminCopyContent
    /// </summary>
    public class AdminCopyContent : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCopyContentBuilder Builder { get => new AdminCopyContentBuilder(); }

        public class AdminCopyContentBuilder
            : OperationBuilder<AdminCopyContentBuilder>
        {





            internal AdminCopyContentBuilder() { }

            internal AdminCopyContentBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCopyContent Build(
                ModelsCopyContentRequest body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminCopyContent op = new AdminCopyContent(this,
                    body,
                    channelId,
                    contentId,
                    namespace_
                );

                op.SetBaseFields<AdminCopyContentBuilder>(this);
                return op;
            }

            public Model.ModelsContentDownloadResponseV2? Execute(
                ModelsCopyContentRequest body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminCopyContent op = Build(
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
            public async Task<Model.ModelsContentDownloadResponseV2?> ExecuteAsync(
                ModelsCopyContentRequest body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminCopyContent op = Build(
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

            public Model.ModelsContentDownloadResponseV2<T1>? Execute<T1>(
                ModelsCopyContentRequest body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminCopyContent op = Build(
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
            public async Task<Model.ModelsContentDownloadResponseV2<T1>?> ExecuteAsync<T1>(
                ModelsCopyContentRequest body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminCopyContent op = Build(
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

        private AdminCopyContent(AdminCopyContentBuilder builder,
            ModelsCopyContentRequest body,
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

        public AdminCopyContent(
            string channelId,
            string contentId,
            string namespace_,
            Model.ModelsCopyContentRequest body
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}/copy";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsContentDownloadResponseV2? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponseV2>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponseV2>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsContentDownloadResponseV2<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponseV2<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponseV2<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}