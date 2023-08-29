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

using AccelByte.Sdk.Api.Matchmaking.Model;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// QuerySessionHandler
    ///
    /// Required Permission: NAMESPACE:{namespace}:SESSION [READ]
    /// 
    /// Required Scope: social
    /// 
    /// Queries the specified session's status. Game servers are expected to
    /// call this periodically as long as it has a session in queue to see
    /// if there are new players being matched to the session.
    /// 
    /// Possible session statuses are "sessionInQueue", "sessionFull", and "sessionTimeout".
    /// 
    /// if party_id value empty/null, field will not show in response body.
    /// </summary>
    public class QuerySessionHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QuerySessionHandlerBuilder Builder { get => new QuerySessionHandlerBuilder(); }

        public class QuerySessionHandlerBuilder
            : OperationBuilder<QuerySessionHandlerBuilder>
        {





            internal QuerySessionHandlerBuilder() { }

            internal QuerySessionHandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public QuerySessionHandler Build(
                string matchID,
                string namespace_
            )
            {
                QuerySessionHandler op = new QuerySessionHandler(this,
                    matchID,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsMatchmakingResult? Execute(
                string matchID,
                string namespace_
            )
            {
                QuerySessionHandler op = Build(
                    matchID,
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

            public Model.ModelsMatchmakingResult<T1>? Execute<T1>(
                string matchID,
                string namespace_
            )
            {
                QuerySessionHandler op = Build(
                    matchID,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private QuerySessionHandler(QuerySessionHandlerBuilder builder,
            string matchID,
            string namespace_
        )
        {
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QuerySessionHandler(
            string matchID,
            string namespace_
        )
        {
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/namespaces/{namespace}/sessions/{matchID}/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsMatchmakingResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMatchmakingResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMatchmakingResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsMatchmakingResult<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMatchmakingResult<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMatchmakingResult<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}