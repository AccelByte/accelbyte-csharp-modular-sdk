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
    /// syncXboxDLC
    ///
    /// Sync Xbox inventory's dlc items.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource=NAMESPACE:{namespace}:USER:{userId}:DLC, action=4 (UPDATE)
    ///   *  Returns :
    /// </summary>
    public class SyncXboxDLC : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncXboxDLCBuilder Builder { get => new SyncXboxDLCBuilder(); }

        public class SyncXboxDLCBuilder
            : OperationBuilder<SyncXboxDLCBuilder>
        {


            public Model.XblDLCSyncRequest? Body { get; set; }




            internal SyncXboxDLCBuilder() { }

            internal SyncXboxDLCBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public SyncXboxDLCBuilder SetBody(Model.XblDLCSyncRequest _body)
            {
                Body = _body;
                return this;
            }




            public SyncXboxDLC Build(
                string namespace_,
                string userId
            )
            {
                SyncXboxDLC op = new SyncXboxDLC(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<SyncXboxDLCBuilder>(this);
                return op;
            }

            public void Execute(
                string namespace_,
                string userId
            )
            {
                SyncXboxDLC op = Build(
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
            public async Task ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                SyncXboxDLC op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private SyncXboxDLC(SyncXboxDLCBuilder builder,
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

        public SyncXboxDLC(
            string namespace_,
            string userId,
            Model.XblDLCSyncRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/dlc/xbl/sync";

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