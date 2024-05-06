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
    /// syncTwitchDropsEntitlement
    ///
    /// Sync my game twitch drops entitlements.
    /// </summary>
    public class SyncTwitchDropsEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncTwitchDropsEntitlementBuilder Builder { get => new SyncTwitchDropsEntitlementBuilder(); }

        public class SyncTwitchDropsEntitlementBuilder
            : OperationBuilder<SyncTwitchDropsEntitlementBuilder>
        {


            public Model.TwitchSyncRequest? Body { get; set; }




            internal SyncTwitchDropsEntitlementBuilder() { }

            internal SyncTwitchDropsEntitlementBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public SyncTwitchDropsEntitlementBuilder SetBody(Model.TwitchSyncRequest _body)
            {
                Body = _body;
                return this;
            }




            public SyncTwitchDropsEntitlement Build(
                string namespace_
            )
            {
                SyncTwitchDropsEntitlement op = new SyncTwitchDropsEntitlement(this,
                    namespace_
                );

                op.SetBaseFields<SyncTwitchDropsEntitlementBuilder>(this);
                return op;
            }

            public List<Model.TwitchSyncResult>? Execute(
                string namespace_
            )
            {
                SyncTwitchDropsEntitlement op = Build(
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
            public async Task<List<Model.TwitchSyncResult>?> ExecuteAsync(
                string namespace_
            )
            {
                SyncTwitchDropsEntitlement op = Build(
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

        private SyncTwitchDropsEntitlement(SyncTwitchDropsEntitlementBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SyncTwitchDropsEntitlement(
            string namespace_,
            Model.TwitchSyncRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/me/iap/twitch/sync";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.TwitchSyncResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.TwitchSyncResult>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.TwitchSyncResult>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}