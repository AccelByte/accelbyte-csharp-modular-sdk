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
    /// PublicDownloadContentByShareCode
    ///
    /// Public user can access without token or if token specified, requires valid user token
    /// </summary>
    public class PublicDownloadContentByShareCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDownloadContentByShareCodeBuilder Builder { get => new PublicDownloadContentByShareCodeBuilder(); }

        public class PublicDownloadContentByShareCodeBuilder
            : OperationBuilder<PublicDownloadContentByShareCodeBuilder>
        {





            internal PublicDownloadContentByShareCodeBuilder() { }

            internal PublicDownloadContentByShareCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicDownloadContentByShareCode Build(
                string namespace_,
                string shareCode
            )
            {
                PublicDownloadContentByShareCode op = new PublicDownloadContentByShareCode(this,
                    namespace_,
                    shareCode
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsContentDownloadResponse? Execute(
                string namespace_,
                string shareCode
            )
            {
                PublicDownloadContentByShareCode op = Build(
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

            public Model.ModelsContentDownloadResponse<T1>? Execute<T1>(
                string namespace_,
                string shareCode
            )
            {
                PublicDownloadContentByShareCode op = Build(
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

        private PublicDownloadContentByShareCode(PublicDownloadContentByShareCodeBuilder builder,
            string namespace_,
            string shareCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicDownloadContentByShareCode(
            string namespace_,
            string shareCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/contents/sharecodes/{shareCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json", "application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsContentDownloadResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponse>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsContentDownloadResponse<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponse<T1>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponse<T1>>(payload);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}