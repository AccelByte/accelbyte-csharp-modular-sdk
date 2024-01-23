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
    /// PublicGetContentByShareCodeV2
    ///
    /// Public user can access without token or if token specified, requires valid user token
    /// </summary>
    public class PublicGetContentByShareCodeV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetContentByShareCodeV2Builder Builder { get => new PublicGetContentByShareCodeV2Builder(); }

        public class PublicGetContentByShareCodeV2Builder
            : OperationBuilder<PublicGetContentByShareCodeV2Builder>
        {





            internal PublicGetContentByShareCodeV2Builder() { }

            internal PublicGetContentByShareCodeV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetContentByShareCodeV2 Build(
                string namespace_,
                string shareCode
            )
            {
                PublicGetContentByShareCodeV2 op = new PublicGetContentByShareCodeV2(this,
                    namespace_,
                    shareCode
                );

                op.SetBaseFields<PublicGetContentByShareCodeV2Builder>(this);
                return op;
            }

            public Model.ModelsContentDownloadResponseV2? Execute(
                string namespace_,
                string shareCode
            )
            {
                PublicGetContentByShareCodeV2 op = Build(
                    namespace_,
                    shareCode
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public Model.ModelsContentDownloadResponseV2<T1>? Execute<T1>(
                string namespace_,
                string shareCode
            )
            {
                PublicGetContentByShareCodeV2 op = Build(
                    namespace_,
                    shareCode
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

        private PublicGetContentByShareCodeV2(PublicGetContentByShareCodeV2Builder builder,
            string namespace_,
            string shareCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetContentByShareCodeV2(
            string namespace_,
            string shareCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/public/namespaces/{namespace}/contents/sharecodes/{shareCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json", "application/octet-stream" };

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