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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// publicPromoteGameSessionLeader
    ///
    /// Promote game session member to become the new game session leader.
    /// 
    /// This API requires the NAMESPACE:{namespace}:SESSION:GAME [UPDATE] permission.
    /// 
    /// This API can be operated by:
    /// - User (game session member) who is the current leader of the game session
    /// - Game Client
    /// - Dedicated Server (DS)
    /// 
    /// This API will promote game session leader candidate with the following criteria:
    /// - Leader candidate is a member of the game session
    /// - Leader candidate has a "CONNECTED" or "JOINED" status
    /// - If the leader candidate is the current leader, then no promotion process is carried out
    /// </summary>
    public class PublicPromoteGameSessionLeader : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicPromoteGameSessionLeaderBuilder Builder { get => new PublicPromoteGameSessionLeaderBuilder(); }

        public class PublicPromoteGameSessionLeaderBuilder
            : OperationBuilder<PublicPromoteGameSessionLeaderBuilder>
        {





            internal PublicPromoteGameSessionLeaderBuilder() { }

            internal PublicPromoteGameSessionLeaderBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicPromoteGameSessionLeader Build(
                ApimodelsPromoteLeaderRequest body,
                string namespace_,
                string sessionId
            )
            {
                PublicPromoteGameSessionLeader op = new PublicPromoteGameSessionLeader(this,
                    body,
                    namespace_,
                    sessionId
                );

                op.SetBaseFields<PublicPromoteGameSessionLeaderBuilder>(this);
                return op;
            }

            public Model.ApimodelsGameSessionResponse? Execute(
                ApimodelsPromoteLeaderRequest body,
                string namespace_,
                string sessionId
            )
            {
                PublicPromoteGameSessionLeader op = Build(
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
            public async Task<Model.ApimodelsGameSessionResponse?> ExecuteAsync(
                ApimodelsPromoteLeaderRequest body,
                string namespace_,
                string sessionId
            )
            {
                PublicPromoteGameSessionLeader op = Build(
                    body,
                    namespace_,
                    sessionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public Model.ApimodelsGameSessionResponse<T1, T2>? Execute<T1, T2>(
                ApimodelsPromoteLeaderRequest body,
                string namespace_,
                string sessionId
            )
            {
                PublicPromoteGameSessionLeader op = Build(
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
            public async Task<Model.ApimodelsGameSessionResponse<T1, T2>?> ExecuteAsync<T1, T2>(
                ApimodelsPromoteLeaderRequest body,
                string namespace_,
                string sessionId
            )
            {
                PublicPromoteGameSessionLeader op = Build(
                    body,
                    namespace_,
                    sessionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicPromoteGameSessionLeader(PublicPromoteGameSessionLeaderBuilder builder,
            ApimodelsPromoteLeaderRequest body,
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

        public PublicPromoteGameSessionLeader(
            string namespace_,
            string sessionId,
            Model.ApimodelsPromoteLeaderRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/leader";

        public override HttpMethod Method => HttpMethod.Post;

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