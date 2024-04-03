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
    /// AdminUpdateOfficialContentV2
    ///
    /// Update existing official content
    /// </summary>
    public class AdminUpdateOfficialContentV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateOfficialContentV2Builder Builder { get => new AdminUpdateOfficialContentV2Builder(); }

        public class AdminUpdateOfficialContentV2Builder
            : OperationBuilder<AdminUpdateOfficialContentV2Builder>
        {





            internal AdminUpdateOfficialContentV2Builder() { }

            internal AdminUpdateOfficialContentV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateOfficialContentV2 Build(
                ModelsAdminUpdateContentRequestV2 body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminUpdateOfficialContentV2 op = new AdminUpdateOfficialContentV2(this,
                    body,
                    channelId,
                    contentId,
                    namespace_
                );

                op.SetBaseFields<AdminUpdateOfficialContentV2Builder>(this);
                return op;
            }

            public Model.ModelsUpdateContentResponseV2? Execute(
                ModelsAdminUpdateContentRequestV2 body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminUpdateOfficialContentV2 op = Build(
                    body,
                    channelId,
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
            public async Task<Model.ModelsUpdateContentResponseV2?> ExecuteAsync(
                ModelsAdminUpdateContentRequestV2 body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminUpdateOfficialContentV2 op = Build(
                    body,
                    channelId,
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

            public Model.ModelsUpdateContentResponseV2<T1>? Execute<T1>(
                ModelsAdminUpdateContentRequestV2 body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminUpdateOfficialContentV2 op = Build(
                    body,
                    channelId,
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
            public async Task<Model.ModelsUpdateContentResponseV2<T1>?> ExecuteAsync<T1>(
                ModelsAdminUpdateContentRequestV2 body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminUpdateOfficialContentV2 op = Build(
                    body,
                    channelId,
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

        private AdminUpdateOfficialContentV2(AdminUpdateOfficialContentV2Builder builder,
            ModelsAdminUpdateContentRequestV2 body,
            string channelId,
            string contentId,
            string namespace_
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateOfficialContentV2(
            string channelId,
            string contentId,
            string namespace_,
            Model.ModelsAdminUpdateContentRequestV2 body
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}";

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