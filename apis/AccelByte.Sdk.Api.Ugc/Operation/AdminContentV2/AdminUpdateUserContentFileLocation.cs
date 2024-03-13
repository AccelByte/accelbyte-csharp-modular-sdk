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
    /// AdminUpdateUserContentFileLocation
    ///
    /// This endpoint should be used after calling generate user content upload url endpoint to commit the changes
    /// </summary>
    public class AdminUpdateUserContentFileLocation : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateUserContentFileLocationBuilder Builder { get => new AdminUpdateUserContentFileLocationBuilder(); }

        public class AdminUpdateUserContentFileLocationBuilder
            : OperationBuilder<AdminUpdateUserContentFileLocationBuilder>
        {





            internal AdminUpdateUserContentFileLocationBuilder() { }

            internal AdminUpdateUserContentFileLocationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateUserContentFileLocation Build(
                ModelsUpdateFileLocationRequest body,
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserContentFileLocation op = new AdminUpdateUserContentFileLocation(this,
                    body,
                    channelId,
                    contentId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminUpdateUserContentFileLocationBuilder>(this);
                return op;
            }

            public Model.ModelsUpdateContentResponseV2? Execute(
                ModelsUpdateFileLocationRequest body,
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserContentFileLocation op = Build(
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

            public Model.ModelsUpdateContentResponseV2<T1>? Execute<T1>(
                ModelsUpdateFileLocationRequest body,
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserContentFileLocation op = Build(
                    body,
                    channelId,
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

        private AdminUpdateUserContentFileLocation(AdminUpdateUserContentFileLocationBuilder builder,
            ModelsUpdateFileLocationRequest body,
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

        public AdminUpdateUserContentFileLocation(
            string channelId,
            string contentId,
            string namespace_,
            string userId,
            Model.ModelsUpdateFileLocationRequest body
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}/fileLocation";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsUpdateContentResponseV2? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateContentResponseV2>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateContentResponseV2>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsUpdateContentResponseV2<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateContentResponseV2<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateContentResponseV2<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}