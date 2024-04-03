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

using AccelByte.Sdk.Api.Matchmaking.Model;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// DequeueSessionHandler
    ///
    /// Dequeues joinable session so that it will not be matched with player's match request tickets.
    /// 
    /// This endpoint is intended to be called by game server to let matchmaker know that
    /// the game server does not want more players to its session, even though it is not full.
    /// </summary>
    public class DequeueSessionHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DequeueSessionHandlerBuilder Builder { get => new DequeueSessionHandlerBuilder(); }

        public class DequeueSessionHandlerBuilder
            : OperationBuilder<DequeueSessionHandlerBuilder>
        {





            internal DequeueSessionHandlerBuilder() { }

            internal DequeueSessionHandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DequeueSessionHandler Build(
                ModelsDequeueRequest body,
                string namespace_
            )
            {
                DequeueSessionHandler op = new DequeueSessionHandler(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<DequeueSessionHandlerBuilder>(this);
                return op;
            }

            public void Execute(
                ModelsDequeueRequest body,
                string namespace_
            )
            {
                DequeueSessionHandler op = Build(
                    body,
                    namespace_
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
                ModelsDequeueRequest body,
                string namespace_
            )
            {
                DequeueSessionHandler op = Build(
                    body,
                    namespace_
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

        private DequeueSessionHandler(DequeueSessionHandlerBuilder builder,
            ModelsDequeueRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DequeueSessionHandler(
            string namespace_,
            Model.ModelsDequeueRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/namespaces/{namespace}/sessions/dequeue";

        public override HttpMethod Method => HttpMethod.Post;

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