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
    /// AdminUpdateContentHideStatusV2
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENT [UPDATE].
    /// </summary>
    public class AdminUpdateContentHideStatusV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateContentHideStatusV2Builder Builder { get => new AdminUpdateContentHideStatusV2Builder(); }

        public class AdminUpdateContentHideStatusV2Builder
            : OperationBuilder<AdminUpdateContentHideStatusV2Builder>
        {





            internal AdminUpdateContentHideStatusV2Builder() { }

            internal AdminUpdateContentHideStatusV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateContentHideStatusV2 Build(
                ModelsHideContentRequest body,
                string contentId,
                string namespace_,
                string userId
            )
            {
                AdminUpdateContentHideStatusV2 op = new AdminUpdateContentHideStatusV2(this,
                    body,
                    contentId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminUpdateContentHideStatusV2Builder>(this);
                return op;
            }

            public Model.ModelsCreateContentResponseV2? Execute(
                ModelsHideContentRequest body,
                string contentId,
                string namespace_,
                string userId
            )
            {
                AdminUpdateContentHideStatusV2 op = Build(
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

            public Model.ModelsCreateContentResponseV2<T1>? Execute<T1>(
                ModelsHideContentRequest body,
                string contentId,
                string namespace_,
                string userId
            )
            {
                AdminUpdateContentHideStatusV2 op = Build(
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
        }

        private AdminUpdateContentHideStatusV2(AdminUpdateContentHideStatusV2Builder builder,
            ModelsHideContentRequest body,
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

        public AdminUpdateContentHideStatusV2(
            string contentId,
            string namespace_,
            string userId,
            Model.ModelsHideContentRequest body
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/users/{userId}/contents/{contentId}/hide";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsCreateContentResponseV2? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateContentResponseV2>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateContentResponseV2>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsCreateContentResponseV2<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateContentResponseV2<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateContentResponseV2<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}