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
    /// DeleteContentScreenshot
    ///
    /// Delete existing screenshot from a content
    /// </summary>
    public class DeleteContentScreenshot : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteContentScreenshotBuilder Builder { get => new DeleteContentScreenshotBuilder(); }

        public class DeleteContentScreenshotBuilder
            : OperationBuilder<DeleteContentScreenshotBuilder>
        {





            internal DeleteContentScreenshotBuilder() { }

            internal DeleteContentScreenshotBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteContentScreenshot Build(
                string contentId,
                string namespace_,
                string screenshotId,
                string userId
            )
            {
                DeleteContentScreenshot op = new DeleteContentScreenshot(this,
                    contentId,
                    namespace_,
                    screenshotId,
                    userId
                );

                op.SetBaseFields<DeleteContentScreenshotBuilder>(this);
                return op;
            }

            public void Execute(
                string contentId,
                string namespace_,
                string screenshotId,
                string userId
            )
            {
                DeleteContentScreenshot op = Build(
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
            public async Task ExecuteAsync(
                string contentId,
                string namespace_,
                string screenshotId,
                string userId
            )
            {
                DeleteContentScreenshot op = Build(
                    contentId,
                    namespace_,
                    screenshotId,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private DeleteContentScreenshot(DeleteContentScreenshotBuilder builder,
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

        public DeleteContentScreenshot(
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

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots/{screenshotId}";

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