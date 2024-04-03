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
    /// syncEpicGamesInventory
    ///
    /// Sync epic games inventory's items.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:IAP", action=4 (UPDATE)
    ///   *  Returns :
    /// </summary>
    public class SyncEpicGamesInventory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncEpicGamesInventoryBuilder Builder { get => new SyncEpicGamesInventoryBuilder(); }

        public class SyncEpicGamesInventoryBuilder
            : OperationBuilder<SyncEpicGamesInventoryBuilder>
        {


            public Model.EpicGamesReconcileRequest? Body { get; set; }




            internal SyncEpicGamesInventoryBuilder() { }

            internal SyncEpicGamesInventoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public SyncEpicGamesInventoryBuilder SetBody(Model.EpicGamesReconcileRequest _body)
            {
                Body = _body;
                return this;
            }




            public SyncEpicGamesInventory Build(
                string namespace_,
                string userId
            )
            {
                SyncEpicGamesInventory op = new SyncEpicGamesInventory(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<SyncEpicGamesInventoryBuilder>(this);
                return op;
            }

            public List<Model.EpicGamesReconcileResult>? Execute(
                string namespace_,
                string userId
            )
            {
                SyncEpicGamesInventory op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<List<Model.EpicGamesReconcileResult>?> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                SyncEpicGamesInventory op = Build(
                    namespace_,
                    userId
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

        private SyncEpicGamesInventory(SyncEpicGamesInventoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SyncEpicGamesInventory(
            string namespace_,
            string userId,
            Model.EpicGamesReconcileRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/iap/epicgames/sync";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.EpicGamesReconcileResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.EpicGamesReconcileResult>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.EpicGamesReconcileResult>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}