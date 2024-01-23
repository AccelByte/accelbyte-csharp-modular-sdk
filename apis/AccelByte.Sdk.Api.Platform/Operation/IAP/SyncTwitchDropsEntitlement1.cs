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
    /// syncTwitchDropsEntitlement_1
    ///
    /// Sync twitch drops entitlements.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:IAP", action=4 (UPDATE)
    ///   *  Returns :
    /// </summary>
    public class SyncTwitchDropsEntitlement1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncTwitchDropsEntitlement1Builder Builder { get => new SyncTwitchDropsEntitlement1Builder(); }

        public class SyncTwitchDropsEntitlement1Builder
            : OperationBuilder<SyncTwitchDropsEntitlement1Builder>
        {


            public Model.TwitchSyncRequest? Body { get; set; }




            internal SyncTwitchDropsEntitlement1Builder() { }

            internal SyncTwitchDropsEntitlement1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public SyncTwitchDropsEntitlement1Builder SetBody(Model.TwitchSyncRequest _body)
            {
                Body = _body;
                return this;
            }




            public SyncTwitchDropsEntitlement1 Build(
                string namespace_,
                string userId
            )
            {
                SyncTwitchDropsEntitlement1 op = new SyncTwitchDropsEntitlement1(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<SyncTwitchDropsEntitlement1Builder>(this);
                return op;
            }

            public void Execute(
                string namespace_,
                string userId
            )
            {
                SyncTwitchDropsEntitlement1 op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private SyncTwitchDropsEntitlement1(SyncTwitchDropsEntitlement1Builder builder,
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

        public SyncTwitchDropsEntitlement1(
            string namespace_,
            string userId,
            Model.TwitchSyncRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/iap/twitch/sync";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}