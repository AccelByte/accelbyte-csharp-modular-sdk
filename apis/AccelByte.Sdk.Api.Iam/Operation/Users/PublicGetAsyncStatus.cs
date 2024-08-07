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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicGetAsyncStatus
    ///
    /// This endpoint is used to get linking status.
    /// This API need logged user and user can only request its own linking status.
    /// </summary>
    public class PublicGetAsyncStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetAsyncStatusBuilder Builder { get => new PublicGetAsyncStatusBuilder(); }

        public class PublicGetAsyncStatusBuilder
            : OperationBuilder<PublicGetAsyncStatusBuilder>
        {





            internal PublicGetAsyncStatusBuilder() { }

            internal PublicGetAsyncStatusBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetAsyncStatus Build(
                string namespace_,
                string requestId
            )
            {
                PublicGetAsyncStatus op = new PublicGetAsyncStatus(this,
                    namespace_,
                    requestId
                );

                op.SetBaseFields<PublicGetAsyncStatusBuilder>(this);
                return op;
            }

            public Model.ModelLinkRequest? Execute(
                string namespace_,
                string requestId
            )
            {
                PublicGetAsyncStatus op = Build(
                    namespace_,
                    requestId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelLinkRequest?> ExecuteAsync(
                string namespace_,
                string requestId
            )
            {
                PublicGetAsyncStatus op = Build(
                    namespace_,
                    requestId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public Model.ModelLinkRequest<T1>? Execute<T1>(
                string namespace_,
                string requestId
            )
            {
                PublicGetAsyncStatus op = Build(
                    namespace_,
                    requestId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelLinkRequest<T1>?> ExecuteAsync<T1>(
                string namespace_,
                string requestId
            )
            {
                PublicGetAsyncStatus op = Build(
                    namespace_,
                    requestId
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

        private PublicGetAsyncStatus(PublicGetAsyncStatusBuilder builder,
            string namespace_,
            string requestId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["requestId"] = requestId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetAsyncStatus(
            string namespace_,
            string requestId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["requestId"] = requestId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/requests/{requestId}/async/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelLinkRequest? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelLinkRequest>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelLinkRequest>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelLinkRequest<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelLinkRequest<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelLinkRequest<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}