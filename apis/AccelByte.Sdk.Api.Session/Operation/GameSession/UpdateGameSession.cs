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
    /// updateGameSession
    ///
    /// Updates a game session, this endpoint will override stored gamesession data.
    /// To update only specified fields, please use following endpoint:
    /// method : PATCH
    /// API : /session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}
    /// 
    /// To update DS attributes (clientVersion, deployment, requestedRegions) it will only be applied only as long as no DS has been requested, otherwise ignored.
    /// </summary>
    public class UpdateGameSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateGameSessionBuilder Builder { get => new UpdateGameSessionBuilder(); }

        public class UpdateGameSessionBuilder
            : OperationBuilder<UpdateGameSessionBuilder>
        {





            internal UpdateGameSessionBuilder() { }

            internal UpdateGameSessionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateGameSession Build(
                ApimodelsUpdateGameSessionRequest body,
                string namespace_,
                string sessionId
            )
            {
                UpdateGameSession op = new UpdateGameSession(this,
                    body,
                    namespace_,
                    sessionId
                );

                op.SetBaseFields<UpdateGameSessionBuilder>(this);
                return op;
            }

            public Model.ApimodelsGameSessionResponse? Execute(
                ApimodelsUpdateGameSessionRequest body,
                string namespace_,
                string sessionId
            )
            {
                UpdateGameSession op = Build(
                    body,
                    namespace_,
                    sessionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public Model.ApimodelsGameSessionResponse<T1, T2>? Execute<T1, T2>(
                ApimodelsUpdateGameSessionRequest body,
                string namespace_,
                string sessionId
            )
            {
                UpdateGameSession op = Build(
                    body,
                    namespace_,
                    sessionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private UpdateGameSession(UpdateGameSessionBuilder builder,
            ApimodelsUpdateGameSessionRequest body,
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

        public UpdateGameSession(
            string namespace_,
            string sessionId,
            Model.ApimodelsUpdateGameSessionRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsGameSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ApimodelsGameSessionResponse<T1, T2>? ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse<T1, T2>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse<T1, T2>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}