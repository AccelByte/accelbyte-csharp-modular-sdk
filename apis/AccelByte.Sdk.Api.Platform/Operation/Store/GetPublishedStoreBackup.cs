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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getPublishedStoreBackup
    ///
    /// This API is used to get a store's backup.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=2 (READ)
    ///   *  Returns : store backup info
    /// </summary>
    public class GetPublishedStoreBackup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPublishedStoreBackupBuilder Builder { get => new GetPublishedStoreBackupBuilder(); }

        public class GetPublishedStoreBackupBuilder
            : OperationBuilder<GetPublishedStoreBackupBuilder>
        {





            internal GetPublishedStoreBackupBuilder() { }

            internal GetPublishedStoreBackupBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetPublishedStoreBackup Build(
                string namespace_
            )
            {
                GetPublishedStoreBackup op = new GetPublishedStoreBackup(this,
                    namespace_
                );

                op.SetBaseFields<GetPublishedStoreBackupBuilder>(this);
                return op;
            }

            public Model.StoreBackupInfo? Execute(
                string namespace_
            )
            {
                GetPublishedStoreBackup op = Build(
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

        private GetPublishedStoreBackup(GetPublishedStoreBackupBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetPublishedStoreBackup(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/published/backup";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.StoreBackupInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StoreBackupInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StoreBackupInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}