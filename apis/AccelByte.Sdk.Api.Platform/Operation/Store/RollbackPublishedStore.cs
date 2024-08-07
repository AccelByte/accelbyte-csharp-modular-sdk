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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// rollbackPublishedStore
    ///
    /// This API is used to rollback a published store.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : updated store info
    /// </summary>
    public class RollbackPublishedStore : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RollbackPublishedStoreBuilder Builder { get => new RollbackPublishedStoreBuilder(); }

        public class RollbackPublishedStoreBuilder
            : OperationBuilder<RollbackPublishedStoreBuilder>
        {





            internal RollbackPublishedStoreBuilder() { }

            internal RollbackPublishedStoreBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RollbackPublishedStore Build(
                string namespace_
            )
            {
                RollbackPublishedStore op = new RollbackPublishedStore(this,
                    namespace_
                );

                op.SetBaseFields<RollbackPublishedStoreBuilder>(this);
                return op;
            }

            public Model.StoreInfo? Execute(
                string namespace_
            )
            {
                RollbackPublishedStore op = Build(
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
            public async Task<Model.StoreInfo?> ExecuteAsync(
                string namespace_
            )
            {
                RollbackPublishedStore op = Build(
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
        }

        private RollbackPublishedStore(RollbackPublishedStoreBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RollbackPublishedStore(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/published/rollback";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.StoreInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StoreInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StoreInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}