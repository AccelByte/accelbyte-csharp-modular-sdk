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
    /// UpdateScreenshots
    ///
    /// Maximum description length: 1024
    /// </summary>
    public class UpdateScreenshots : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateScreenshotsBuilder Builder { get => new UpdateScreenshotsBuilder(); }

        public class UpdateScreenshotsBuilder
            : OperationBuilder<UpdateScreenshotsBuilder>
        {





            internal UpdateScreenshotsBuilder() { }

            internal UpdateScreenshotsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateScreenshots Build(
                ModelsUpdateScreenshotRequest body,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UpdateScreenshots op = new UpdateScreenshots(this,
                    body,
                    contentId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<UpdateScreenshotsBuilder>(this);
                return op;
            }

            public Model.ModelsUpdateScreenshotResponse? Execute(
                ModelsUpdateScreenshotRequest body,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UpdateScreenshots op = Build(
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
        }

        private UpdateScreenshots(UpdateScreenshotsBuilder builder,
            ModelsUpdateScreenshotRequest body,
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

        public UpdateScreenshots(
            string contentId,
            string namespace_,
            string userId,
            Model.ModelsUpdateScreenshotRequest body
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json", "application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsUpdateScreenshotResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateScreenshotResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateScreenshotResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}