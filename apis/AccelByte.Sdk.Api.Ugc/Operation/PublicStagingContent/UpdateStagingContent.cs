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
    /// UpdateStagingContent
    ///
    /// Update staging content
    /// </summary>
    public class UpdateStagingContent : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateStagingContentBuilder Builder { get => new UpdateStagingContentBuilder(); }

        public class UpdateStagingContentBuilder
            : OperationBuilder<UpdateStagingContentBuilder>
        {





            internal UpdateStagingContentBuilder() { }

            internal UpdateStagingContentBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateStagingContent Build(
                ModelsUpdateStagingContentRequest body,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UpdateStagingContent op = new UpdateStagingContent(this,
                    body,
                    contentId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<UpdateStagingContentBuilder>(this);
                return op;
            }

            public Model.ModelsStagingContentResponse? Execute(
                ModelsUpdateStagingContentRequest body,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UpdateStagingContent op = Build(
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
            public async Task<Model.ModelsStagingContentResponse?> ExecuteAsync(
                ModelsUpdateStagingContentRequest body,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UpdateStagingContent op = Build(
                    body,
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

            public Model.ModelsStagingContentResponse<T1>? Execute<T1>(
                ModelsUpdateStagingContentRequest body,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UpdateStagingContent op = Build(
                    body,
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
            public async Task<Model.ModelsStagingContentResponse<T1>?> ExecuteAsync<T1>(
                ModelsUpdateStagingContentRequest body,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UpdateStagingContent op = Build(
                    body,
                    contentId,
                    namespace_,
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

        private UpdateStagingContent(UpdateStagingContentBuilder builder,
            ModelsUpdateStagingContentRequest body,
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

        public UpdateStagingContent(
            string contentId,
            string namespace_,
            string userId,
            Model.ModelsUpdateStagingContentRequest body
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/public/namespaces/{namespace}/users/{userId}/staging-contents/{contentId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json", "application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsStagingContentResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsStagingContentResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsStagingContentResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsStagingContentResponse<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsStagingContentResponse<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsStagingContentResponse<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}