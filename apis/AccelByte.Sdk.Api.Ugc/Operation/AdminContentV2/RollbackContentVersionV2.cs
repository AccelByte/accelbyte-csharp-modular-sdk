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
    /// RollbackContentVersionV2
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENT [UPDATE]
    /// Rollback content's payload to specified version.
    /// </summary>
    public class RollbackContentVersionV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RollbackContentVersionV2Builder Builder { get => new RollbackContentVersionV2Builder(); }

        public class RollbackContentVersionV2Builder
            : OperationBuilder<RollbackContentVersionV2Builder>
        {





            internal RollbackContentVersionV2Builder() { }

            internal RollbackContentVersionV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RollbackContentVersionV2 Build(
                string contentId,
                string namespace_,
                string versionId
            )
            {
                RollbackContentVersionV2 op = new RollbackContentVersionV2(this,
                    contentId,
                    namespace_,
                    versionId
                );

                op.SetBaseFields<RollbackContentVersionV2Builder>(this);
                return op;
            }

            public Model.ModelsContentDownloadResponse? Execute(
                string contentId,
                string namespace_,
                string versionId
            )
            {
                RollbackContentVersionV2 op = Build(
                    contentId,
                    namespace_,
                    versionId
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
                string contentId,
                string namespace_,
                string versionId
            )
            {
                RollbackContentVersionV2 op = Build(
                    contentId,
                    namespace_,
                    versionId
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

        private RollbackContentVersionV2(RollbackContentVersionV2Builder builder,
            string contentId,
            string namespace_,
            string versionId
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["versionId"] = versionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RollbackContentVersionV2(
            string contentId,
            string namespace_,
            string versionId
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["versionId"] = versionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/contents/{contentId}/rollback/{versionId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "*/*" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsContentDownloadResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponse>(payload, ResponseJsonOptions);
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
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponse<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentDownloadResponse<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}