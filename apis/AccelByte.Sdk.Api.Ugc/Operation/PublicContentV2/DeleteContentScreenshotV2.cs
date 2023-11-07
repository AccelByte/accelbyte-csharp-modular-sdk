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
    /// DeleteContentScreenshotV2
    ///
    /// Required permission NAMESPACE:{namespace}:USER:{userId}:CONTENT [DELETE].
    /// </summary>
    public class DeleteContentScreenshotV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteContentScreenshotV2Builder Builder { get => new DeleteContentScreenshotV2Builder(); }

        public class DeleteContentScreenshotV2Builder
            : OperationBuilder<DeleteContentScreenshotV2Builder>
        {





            internal DeleteContentScreenshotV2Builder() { }

            internal DeleteContentScreenshotV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteContentScreenshotV2 Build(
                string contentId,
                string namespace_,
                string screenshotId,
                string userId
            )
            {
                DeleteContentScreenshotV2 op = new DeleteContentScreenshotV2(this,
                    contentId,
                    namespace_,
                    screenshotId,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string contentId,
                string namespace_,
                string screenshotId,
                string userId
            )
            {
                DeleteContentScreenshotV2 op = Build(
                    contentId,
                    namespace_,
                    screenshotId,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private DeleteContentScreenshotV2(DeleteContentScreenshotV2Builder builder,
            string contentId,
            string namespace_,
            string screenshotId,
            string userId
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["screenshotId"] = screenshotId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteContentScreenshotV2(
            string contentId,
            string namespace_,
            string screenshotId,
            string userId
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["screenshotId"] = screenshotId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots/{screenshotId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json", "application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}