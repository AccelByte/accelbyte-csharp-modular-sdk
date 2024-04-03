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
    /// PublicGetContentBulkByShareCodesV2
    ///
    /// Require valid user token.
    /// Maximum sharecodes per request 100
    /// </summary>
    public class PublicGetContentBulkByShareCodesV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetContentBulkByShareCodesV2Builder Builder { get => new PublicGetContentBulkByShareCodesV2Builder(); }

        public class PublicGetContentBulkByShareCodesV2Builder
            : OperationBuilder<PublicGetContentBulkByShareCodesV2Builder>
        {





            internal PublicGetContentBulkByShareCodesV2Builder() { }

            internal PublicGetContentBulkByShareCodesV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetContentBulkByShareCodesV2 Build(
                ModelsGetContentBulkByShareCodesRequest body,
                string namespace_
            )
            {
                PublicGetContentBulkByShareCodesV2 op = new PublicGetContentBulkByShareCodesV2(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<PublicGetContentBulkByShareCodesV2Builder>(this);
                return op;
            }

            public List<Model.ModelsContentDownloadResponseV2>? Execute(
                ModelsGetContentBulkByShareCodesRequest body,
                string namespace_
            )
            {
                PublicGetContentBulkByShareCodesV2 op = Build(
                    body,
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
            public async Task<List<Model.ModelsContentDownloadResponseV2>?> ExecuteAsync(
                ModelsGetContentBulkByShareCodesRequest body,
                string namespace_
            )
            {
                PublicGetContentBulkByShareCodesV2 op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public List<Model.ModelsContentDownloadResponseV2<T1>>? Execute<T1>(
                ModelsGetContentBulkByShareCodesRequest body,
                string namespace_
            )
            {
                PublicGetContentBulkByShareCodesV2 op = Build(
                    body,
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
            public async Task<List<Model.ModelsContentDownloadResponseV2<T1>>?> ExecuteAsync<T1>(
                ModelsGetContentBulkByShareCodesRequest body,
                string namespace_
            )
            {
                PublicGetContentBulkByShareCodesV2 op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicGetContentBulkByShareCodesV2(PublicGetContentBulkByShareCodesV2Builder builder,
            ModelsGetContentBulkByShareCodesRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetContentBulkByShareCodesV2(
            string namespace_,
            Model.ModelsGetContentBulkByShareCodesRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/public/namespaces/{namespace}/contents/sharecodes/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json", "application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ModelsContentDownloadResponseV2>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponseV2>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponseV2>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.ModelsContentDownloadResponseV2<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponseV2<T1>>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponseV2<T1>>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}