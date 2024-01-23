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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// adminSetDSReady
    ///
    /// When the session template has ds_manual_set_ready as true. Then the DS need to calls this end point in order to notify game client if the DS is ready to accept any game client connection.
    /// </summary>
    public class AdminSetDSReady : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSetDSReadyBuilder Builder { get => new AdminSetDSReadyBuilder(); }

        public class AdminSetDSReadyBuilder
            : OperationBuilder<AdminSetDSReadyBuilder>
        {





            internal AdminSetDSReadyBuilder() { }

            internal AdminSetDSReadyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminSetDSReady Build(
                ApimodelsSetDSReadyRequest body,
                string namespace_,
                string sessionId
            )
            {
                AdminSetDSReady op = new AdminSetDSReady(this,
                    body,
                    namespace_,
                    sessionId
                );

                op.SetBaseFields<AdminSetDSReadyBuilder>(this);
                return op;
            }

            public void Execute(
                ApimodelsSetDSReadyRequest body,
                string namespace_,
                string sessionId
            )
            {
                AdminSetDSReady op = Build(
                    body,
                    namespace_,
                    sessionId
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

        private AdminSetDSReady(AdminSetDSReadyBuilder builder,
            ApimodelsSetDSReadyRequest body,
            string namespace_,
            string sessionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminSetDSReady(
            string namespace_,
            string sessionId,
            Model.ApimodelsSetDSReadyRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/gamesessions/{sessionId}/ds";

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