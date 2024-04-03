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
    /// AdminGetContentByContentIDV2
    ///
    /// Get content by content ID
    /// </summary>
    public class AdminGetContentByContentIDV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetContentByContentIDV2Builder Builder { get => new AdminGetContentByContentIDV2Builder(); }

        public class AdminGetContentByContentIDV2Builder
            : OperationBuilder<AdminGetContentByContentIDV2Builder>
        {





            internal AdminGetContentByContentIDV2Builder() { }

            internal AdminGetContentByContentIDV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetContentByContentIDV2 Build(
                string contentId,
                string namespace_
            )
            {
                AdminGetContentByContentIDV2 op = new AdminGetContentByContentIDV2(this,
                    contentId,
                    namespace_
                );

                op.SetBaseFields<AdminGetContentByContentIDV2Builder>(this);
                return op;
            }

            public Model.ModelsContentDownloadResponseV2? Execute(
                string contentId,
                string namespace_
            )
            {
                AdminGetContentByContentIDV2 op = Build(
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
            public async Task<Model.ModelsContentDownloadResponseV2?> ExecuteAsync(
                string contentId,
                string namespace_
            )
            {
                AdminGetContentByContentIDV2 op = Build(
                    contentId,
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

            public Model.ModelsContentDownloadResponseV2<T1>? Execute<T1>(
                string contentId,
                string namespace_
            )
            {
                AdminGetContentByContentIDV2 op = Build(
                    contentId,
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
            public async Task<Model.ModelsContentDownloadResponseV2<T1>?> ExecuteAsync<T1>(
                string contentId,
                string namespace_
            )
            {
                AdminGetContentByContentIDV2 op = Build(
                    contentId,
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

        private AdminGetContentByContentIDV2(AdminGetContentByContentIDV2Builder builder,
            string contentId,
            string namespace_
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetContentByContentIDV2(
            string contentId,
            string namespace_
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/contents/{contentId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

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