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
    /// syncOrders
    ///
    ///  [Not Supported Yet In Starter] Sync orders. If response contains nextEvaluatedKey, please use it as query param in the next call to fetch the next batch, a batch has 1000 elements or less.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:ORDER", action=2 (READ)
    ///   *  Returns : sync orders
    /// </summary>
    public class SyncOrders : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncOrdersBuilder Builder { get => new SyncOrdersBuilder(); }

        public class SyncOrdersBuilder
            : OperationBuilder<SyncOrdersBuilder>
        {

            public string? NextEvaluatedKey { get; set; }





            internal SyncOrdersBuilder() { }

            internal SyncOrdersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public SyncOrdersBuilder SetNextEvaluatedKey(string _nextEvaluatedKey)
            {
                NextEvaluatedKey = _nextEvaluatedKey;
                return this;
            }





            public SyncOrders Build(
                string end,
                string start
            )
            {
                SyncOrders op = new SyncOrders(this,
                    end,
                    start
                );

                op.SetBaseFields<SyncOrdersBuilder>(this);
                return op;
            }

            public Model.OrderSyncResult? Execute(
                string end,
                string start
            )
            {
                SyncOrders op = Build(
                    end,
                    start
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

        private SyncOrders(SyncOrdersBuilder builder,
            string end,
            string start
        )
        {

            if (builder.NextEvaluatedKey is not null) QueryParams["nextEvaluatedKey"] = builder.NextEvaluatedKey;
            if (end is not null) QueryParams["end"] = end;
            if (start is not null) QueryParams["start"] = start;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SyncOrders(
            string? nextEvaluatedKey,
            string end,
            string start
        )
        {

            if (nextEvaluatedKey is not null) QueryParams["nextEvaluatedKey"] = nextEvaluatedKey;
            if (end is not null) QueryParams["end"] = end;
            if (start is not null) QueryParams["start"] = start;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/orders";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.OrderSyncResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OrderSyncResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OrderSyncResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}