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
    /// AdminUpdateScreenshotsV2
    ///
    /// Maximum description length: 1024
    /// </summary>
    public class AdminUpdateScreenshotsV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateScreenshotsV2Builder Builder { get => new AdminUpdateScreenshotsV2Builder(); }

        public class AdminUpdateScreenshotsV2Builder
            : OperationBuilder<AdminUpdateScreenshotsV2Builder>
        {





            internal AdminUpdateScreenshotsV2Builder() { }

            internal AdminUpdateScreenshotsV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateScreenshotsV2 Build(
                ModelsUpdateScreenshotRequest body,
                string contentId,
                string namespace_
            )
            {
                AdminUpdateScreenshotsV2 op = new AdminUpdateScreenshotsV2(this,
                    body,
                    contentId,
                    namespace_
                );

                op.SetBaseFields<AdminUpdateScreenshotsV2Builder>(this);
                return op;
            }

            public Model.ModelsUpdateScreenshotResponse? Execute(
                ModelsUpdateScreenshotRequest body,
                string contentId,
                string namespace_
            )
            {
                AdminUpdateScreenshotsV2 op = Build(
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
        }

        private AdminUpdateScreenshotsV2(AdminUpdateScreenshotsV2Builder builder,
            ModelsUpdateScreenshotRequest body,
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

        public AdminUpdateScreenshotsV2(
            string contentId,
            string namespace_,
            Model.ModelsUpdateScreenshotRequest body
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/contents/{contentId}/screenshots";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

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