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

using AccelByte.Sdk.Api.Sessionbrowser.Model;

namespace AccelByte.Sdk.Api.Sessionbrowser.Operation
{
    /// <summary>
    /// JoinSession
    ///
    /// Join the specified session by session ID. Possible the game required a password to join
    /// </summary>
    public class JoinSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static JoinSessionBuilder Builder { get => new JoinSessionBuilder(); }

        public class JoinSessionBuilder
            : OperationBuilder<JoinSessionBuilder>
        {





            internal JoinSessionBuilder() { }

            internal JoinSessionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public JoinSession Build(
                ModelsJoinGameSessionRequest body,
                string namespace_,
                string sessionID
            )
            {
                JoinSession op = new JoinSession(this,
                    body,
                    namespace_,
                    sessionID
                );

                op.SetBaseFields<JoinSessionBuilder>(this);
                return op;
            }

            public Model.ModelsSessionResponse? Execute(
                ModelsJoinGameSessionRequest body,
                string namespace_,
                string sessionID
            )
            {
                JoinSession op = Build(
                    body,
                    namespace_,
                    sessionID
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private JoinSession(JoinSessionBuilder builder,
            ModelsJoinGameSessionRequest body,
            string namespace_,
            string sessionID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public JoinSession(
            string namespace_,
            string sessionID,
            Model.ModelsJoinGameSessionRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/join";

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