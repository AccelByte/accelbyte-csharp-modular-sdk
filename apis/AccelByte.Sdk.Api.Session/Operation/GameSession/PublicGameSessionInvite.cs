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
    /// publicGameSessionInvite
    ///
    /// Invite a user to a game session.
    /// platformID represents the native platform of the invitee. API will return the corresponding native platform's userID.
    /// supported platforms:
    /// - STEAM
    /// - XBOX
    /// - PSN
    /// </summary>
    public class PublicGameSessionInvite : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGameSessionInviteBuilder Builder { get => new PublicGameSessionInviteBuilder(); }

        public class PublicGameSessionInviteBuilder
            : OperationBuilder<PublicGameSessionInviteBuilder>
        {





            internal PublicGameSessionInviteBuilder() { }

            internal PublicGameSessionInviteBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGameSessionInvite Build(
                ApimodelsSessionInviteRequest body,
                string namespace_,
                string sessionId
            )
            {
                PublicGameSessionInvite op = new PublicGameSessionInvite(this,
                    body,                    
                    namespace_,                    
                    sessionId                    
                );

                op.SetBaseFields<PublicGameSessionInviteBuilder>(this);
                return op;
            }

            public PublicGameSessionInvite.Response Execute(
                ApimodelsSessionInviteRequest body,
                string namespace_,
                string sessionId
            )
            {
                PublicGameSessionInvite op = Build(
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
            public async Task<PublicGameSessionInvite.Response> ExecuteAsync(
                ApimodelsSessionInviteRequest body,
                string namespace_,
                string sessionId
            )
            {
                PublicGameSessionInvite op = Build(
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
        }

        private PublicGameSessionInvite(PublicGameSessionInviteBuilder builder,
            ApimodelsSessionInviteRequest body,
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

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Session::GameSession::PublicGameSessionInvite";
        }

        #endregion

        public PublicGameSessionInvite(
            string namespace_,            
            string sessionId,            
            Model.ApimodelsSessionInviteRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/invite";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicGameSessionInvite.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGameSessionInvite.Response()
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