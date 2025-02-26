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
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
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

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public DequeueSessionHandler.Response Execute(
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
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<DequeueSessionHandler.Response> ExecuteAsync(
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
                return op.ParseResponse(
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

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Matchmaking::Matchmaking::DequeueSessionHandler";
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

        public DequeueSessionHandler.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DequeueSessionHandler.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)

            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)

            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)

            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)

            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)

            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}