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
    /// publicSyncPsnDlcInventory
    ///
    /// Synchronize with dlc entitlements in PSN Store.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource=NAMESPACE:{namespace}:USER:{userId}:DLC, action=4 (UPDATE)
    ///   *  Returns : result of synchronization
    /// </summary>
    public class PublicSyncPsnDlcInventory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSyncPsnDlcInventoryBuilder Builder { get => new PublicSyncPsnDlcInventoryBuilder(); }

        public class PublicSyncPsnDlcInventoryBuilder
            : OperationBuilder<PublicSyncPsnDlcInventoryBuilder>
        {


            public Model.PlayStationDLCSyncRequest? Body { get; set; }




            internal PublicSyncPsnDlcInventoryBuilder() { }

            internal PublicSyncPsnDlcInventoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public PublicSyncPsnDlcInventoryBuilder SetBody(Model.PlayStationDLCSyncRequest _body)
            {
                Body = _body;
                return this;
            }




            public PublicSyncPsnDlcInventory Build(
                string namespace_,
                string userId
            )
            {
                PublicSyncPsnDlcInventory op = new PublicSyncPsnDlcInventory(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string namespace_,
                string userId
            )
            {
                PublicSyncPsnDlcInventory op = Build(
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

        private PublicSyncPsnDlcInventory(PublicSyncPsnDlcInventoryBuilder builder,
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

        public PublicSyncPsnDlcInventory(
            string namespace_,
            string userId,
            Model.PlayStationDLCSyncRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/dlc/psn/sync";

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