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
    /// getGameSession
    ///
    /// Get game session detail.
    /// Session will only be accessible from active players in the session, and client with the permission, except the joinability is set to OPEN.
    /// Session service has several DSInformation status to track DS request to DSMC:
    /// - NEED_TO_REQUEST: number of active players hasn't reached session's minPlayers therefore DS has not yet requested.
    /// - REQUESTED: DS is being requested to DSMC.
    /// - AVAILABLE: DS is ready to use. The DSMC status for this DS is either READY/BUSY.
    /// - FAILED_TO_REQUEST: DSMC fails to create the DS.
    /// </summary>
    public class GetGameSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGameSessionBuilder Builder { get => new GetGameSessionBuilder(); }

        public class GetGameSessionBuilder
            : OperationBuilder<GetGameSessionBuilder>
        {





            internal GetGameSessionBuilder() { }

            internal GetGameSessionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetGameSession Build(
                string namespace_,
                string sessionId
            )
            {
                GetGameSession op = new GetGameSession(this,
                    namespace_,                    
                    sessionId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ApimodelsGameSessionResponse? Execute(
                string namespace_,
                string sessionId
            )
            {
                GetGameSession op = Build(
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
                string namespace_,
                string sessionId
            )
            {
                GetGameSession op = Build(
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

        private GetGameSession(GetGameSessionBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetGameSession(
            string namespace_,            
            string sessionId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}";

        public override HttpMethod Method => HttpMethod.Get;

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