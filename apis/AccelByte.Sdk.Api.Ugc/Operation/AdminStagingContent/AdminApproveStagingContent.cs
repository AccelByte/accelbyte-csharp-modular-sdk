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
    /// AdminApproveStagingContent
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:CONTENT:APPROVAL [CREATE].
    /// </summary>
    public class AdminApproveStagingContent : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminApproveStagingContentBuilder Builder { get => new AdminApproveStagingContentBuilder(); }

        public class AdminApproveStagingContentBuilder
            : OperationBuilder<AdminApproveStagingContentBuilder>
        {





            internal AdminApproveStagingContentBuilder() { }

            internal AdminApproveStagingContentBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminApproveStagingContent Build(
                ModelsApproveStagingContentRequest body,
                string contentId,
                string namespace_
            )
            {
                AdminApproveStagingContent op = new AdminApproveStagingContent(this,
                    body,
                    contentId,
                    namespace_
                );

                op.SetBaseFields<AdminApproveStagingContentBuilder>(this);
                return op;
            }

            public Model.ModelsStagingContentResponse? Execute(
                ModelsApproveStagingContentRequest body,
                string contentId,
                string namespace_
            )
            {
                AdminApproveStagingContent op = Build(
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

            public Model.ModelsStagingContentResponse<T1>? Execute<T1>(
                ModelsApproveStagingContentRequest body,
                string contentId,
                string namespace_
            )
            {
                AdminApproveStagingContent op = Build(
                    body,
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
        }

        private AdminApproveStagingContent(AdminApproveStagingContentBuilder builder,
            ModelsApproveStagingContentRequest body,
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

        public AdminApproveStagingContent(
            string contentId,
            string namespace_,
            Model.ModelsApproveStagingContentRequest body
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/staging-contents/{contentId}/approve";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

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