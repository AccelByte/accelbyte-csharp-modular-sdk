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
    /// patchUpdateGameSession
    ///
    /// Update specified fields from game session data.
    /// </summary>
    public class PatchUpdateGameSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PatchUpdateGameSessionBuilder Builder { get => new PatchUpdateGameSessionBuilder(); }

        public class PatchUpdateGameSessionBuilder
            : OperationBuilder<PatchUpdateGameSessionBuilder>
        {





            internal PatchUpdateGameSessionBuilder() { }

            internal PatchUpdateGameSessionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PatchUpdateGameSession Build(
                ApimodelsUpdateGameSessionRequest body,
                string namespace_,
                string sessionId
            )
            {
                PatchUpdateGameSession op = new PatchUpdateGameSession(this,
                    body,
                    namespace_,
                    sessionId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ApimodelsGameSessionResponse? Execute(
                ApimodelsUpdateGameSessionRequest body,
                string namespace_,
                string sessionId
            )
            {
                PatchUpdateGameSession op = Build(
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

            public Model.ApimodelsGameSessionResponse<T1>? Execute<T1>(
                ApimodelsUpdateGameSessionRequest body,
                string namespace_,
                string sessionId
            )
            {
                PatchUpdateGameSession op = Build(
                    body,
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

        private PatchUpdateGameSession(PatchUpdateGameSessionBuilder builder,
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

        public PatchUpdateGameSession(
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

        public override HttpMethod Method => HttpMethod.Patch;

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

        public Model.ApimodelsGameSessionResponse<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}