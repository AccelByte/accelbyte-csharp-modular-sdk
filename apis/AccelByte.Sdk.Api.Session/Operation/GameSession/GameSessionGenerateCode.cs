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
    /// gameSessionGenerateCode
    ///
    /// Generate a new code for the game session. Only leader can generate a code.
    /// </summary>
    public class GameSessionGenerateCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GameSessionGenerateCodeBuilder Builder { get => new GameSessionGenerateCodeBuilder(); }

        public class GameSessionGenerateCodeBuilder
            : OperationBuilder<GameSessionGenerateCodeBuilder>
        {





            internal GameSessionGenerateCodeBuilder() { }

            internal GameSessionGenerateCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GameSessionGenerateCode Build(
                string namespace_,
                string sessionId
            )
            {
                GameSessionGenerateCode op = new GameSessionGenerateCode(this,
                    namespace_,
                    sessionId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ApimodelsGameSessionResponse? Execute(
                string namespace_,
                string sessionId
            )
            {
                GameSessionGenerateCode op = Build(
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

            public Model.ApimodelsGameSessionResponse<T1>? Execute<T1>(
                string namespace_,
                string sessionId
            )
            {
                GameSessionGenerateCode op = Build(
                    namespace_,
                    sessionId
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

        private GameSessionGenerateCode(GameSessionGenerateCodeBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GameSessionGenerateCode(
            string namespace_,
            string sessionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/code";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsGameSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ApimodelsGameSessionResponse<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse<T1>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse<T1>>(payload);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}