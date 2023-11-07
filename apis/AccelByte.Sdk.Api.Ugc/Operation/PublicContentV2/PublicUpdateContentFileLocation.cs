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
    /// PublicUpdateContentFileLocation
    ///
    /// This endpoint should be used after calling generate upload url endpoint to commit the changes.
    /// Required permission NAMESPACE:{namespace}:USER:{userId}:CONTENT [UPDATE].
    /// </summary>
    public class PublicUpdateContentFileLocation : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateContentFileLocationBuilder Builder { get => new PublicUpdateContentFileLocationBuilder(); }

        public class PublicUpdateContentFileLocationBuilder
            : OperationBuilder<PublicUpdateContentFileLocationBuilder>
        {





            internal PublicUpdateContentFileLocationBuilder() { }

            internal PublicUpdateContentFileLocationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicUpdateContentFileLocation Build(
                ModelsUpdateFileLocationRequest body,
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                PublicUpdateContentFileLocation op = new PublicUpdateContentFileLocation(this,
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

            public Model.ModelsUpdateContentResponseV2? Execute(
                ModelsUpdateFileLocationRequest body,
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                PublicUpdateContentFileLocation op = Build(
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
                PublicUpdateContentFileLocation op = Build(
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

        private PublicUpdateContentFileLocation(PublicUpdateContentFileLocationBuilder builder,
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

        public PublicUpdateContentFileLocation(
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

        public override string Path => "/ugc/v2/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}/fileLocation";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json", "application/octet-stream" };

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