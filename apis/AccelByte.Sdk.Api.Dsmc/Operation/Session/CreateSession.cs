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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// CreateSession
    ///
    /// Required permission: NAMESPACE:{namespace}:DSM:SESSION [CREATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint is intended to be called by game session manager (matchmaker, lobby, etc.) to get a dedicated server for a game session.
    /// 
    /// If a dedicated server is available, it will respond with a dedicated server details ready to be used.
    /// 
    /// Otherwise it will trigger new dedicated server creation and respond with a server status CREATING. The game session manager then expected to wait and query the server readiness with GET /namespaces/{namespace}/sessions/{sessionID} endpoint until the serverstatus is READY
    /// 
    /// Specify pod_name with name of local DS in the request to create a session using the registered local DS
    /// </summary>
    public class CreateSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateSessionBuilder Builder { get => new CreateSessionBuilder(); }

        public class CreateSessionBuilder
            : OperationBuilder<CreateSessionBuilder>
        {





            internal CreateSessionBuilder() { }

            internal CreateSessionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateSession Build(
                ModelsCreateSessionRequest body,
                string namespace_
            )
            {
                CreateSession op = new CreateSession(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<CreateSessionBuilder>(this);
                return op;
            }

            public Model.ModelsSessionResponse? Execute(
                ModelsCreateSessionRequest body,
                string namespace_
            )
            {
                CreateSession op = Build(
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
            public async Task<Model.ModelsSessionResponse?> ExecuteAsync(
                ModelsCreateSessionRequest body,
                string namespace_
            )
            {
                CreateSession op = Build(
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

        private CreateSession(CreateSessionBuilder builder,
            ModelsCreateSessionRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateSession(
            string namespace_,
            Model.ModelsCreateSessionRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/sessions";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}