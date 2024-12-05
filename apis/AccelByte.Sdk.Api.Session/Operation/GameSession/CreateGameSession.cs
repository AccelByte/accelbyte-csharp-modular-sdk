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
    /// createGameSession
    ///
    /// Create a game session.
    /// Session configuration "name" is mandatory, this API will refer following values from the session template if they're not provided in the request:
    /// - type
    /// - joinability
    /// - autoJoin. If enabled (set to true), players provided in the request will automatically joined the initial game session creation. Game session will not send any invite and players dont need to act upon it.
    /// - minPlayers
    /// - maxPlayers
    /// - inviteTimeout
    /// - inactiveTimeout
    /// - attributes
    /// - dsSource
    /// - tieTeamsSessionLifetime
    /// - matchPool
    /// - clientVersion
    /// - deployment
    /// - serverName
    /// - textChat
    /// - autoJoin
    /// - requestedRegions
    /// - dsSource
    /// - preferredClaimKeys
    /// - fallbackClaimKeys
    /// - customURLGRPC
    /// 
    /// When the tieTeamsSessionLifetime is true, the lifetime of any partyId inside teams attribute will be tied to the game session.
    /// Only applies when the teams partyId is a game session.
    /// 
    /// Session has 2 fields for user status: "status" and "statusV2". The "status" is there for backward-compatibility, therefore we encourage to just rely on "statusV2" for the more updated statuses.
    /// User statuses:
    /// 1. INVITED: by default, to join a session (except session with OPEN joinability or if session configuration has "autoJoin" sets to True) a user will receive an invite. The invitee will have the chance to respond within "inviteTimeout" which you can configure through session configuration.
    /// 2. TIMEOUT: when a user is invited to a session, they will receive an invite. Unless "disableResendInvite" sets to True in the session configuration, the user will also receive invite reminder every 30s until they respond to the invite.
    /// 3. REJECTED: when a user rejects an invite. To rejoin an INVITE_ONLY session, they will need to be re-invited and accept the invite.
    /// 4. JOINED: there are few ways of a user to join a session, by invite, direct join (depends on session joinability) or join by code. upon invite, once a user accepts an invite, their status will be changed to JOINED.
    /// 5. LEFT: user can leave a session. in case of party, a user can only be in 1 party at a time. therefore when they decide to create or join another party, they will be automatically removed from their initial party and their status will be changed to LEFT.
    /// 6. KICKED: only party leader can kick a member.
    /// 7. DISCONNECTED: if user still have reserved seat in the session and they disconnect lobby websocket, their status in the session will be changed to DISCONNECTED and field "members.previousStatus" of that user will contains the initial status before they disconnect lobby websocket. the user will be given chance to reconnect within "inactiveTimeout" which you can configure through session configuration.
    /// 8. CONNECTED: when a user reconnect their lobby websocket, their status will change from DISCONNECTED to CONNECTED, only if they previously JOINED session. if they were on INVITED state before the disconnect happened, the user's status will return back to INVITED after they reconnect.
    /// 9. DROPPED: when "inactiveTimeout" is due and user never re-establish their websocket connection, we will drop them from the session.
    /// 10. TERMINATED: only applies to game session. If a game session (match) is ended, DS will end/delete the session and we will mark all remaining users' status to be TERMINATED.
    /// 11. CANCELLED: when a session joinability changes to CLOSED, any remaining invites will be canceled.
    /// 
    /// User is considered as active if they're present in the session, which their status either CONNECTED or JOINED.
    /// User has a reserved seat in the session if their status either INVITED, JOINED, CONNECTED, DISCONNECTED. When user's' status change to other than these mentioned statuses, we will release the seat for other players to occupy.
    /// 
    /// Managing the relation between session and lobby websocket connection:
    /// - Session relies on lobby to consider player's connection health to our backend. therefore a disruption to lobby websocket will be reflected in the user's status in all of their session(s).
    /// - If user still have a reserved seat in the session and they disconnect lobby websocket, their status in session(s) will be changed to DISCONNECTED and field "members.previousStatus" of that user will contains the initial status before they disconnect lobby websocket. This "members.previousStatus" used to track user's previous status before they disconnect websocket, since we still reserve a seat for them, therefore this field will be empty again after they websocket.
    /// - If the disconnected user is the leader of the session they're disconnected from, we will wait until "leaderElectionGracePeriod" is due, to promote the next oldest member as the new leader of the session. You can configure "leaderElectionGracePeriod" through session configuration.
    /// - The user will be given chance to reconnect within "inactiveTimeout" which you can configure through session configuration. If until "inactiveTimeout" is due and the user doesn't reconnect their websocket, they will be removed from session and their status will change to DROPPED. If the dropped user was the leader of the session, we will promote the next oldest member as leader.
    /// - By default, we will update user's status to what it was before disconnect, when the user reconnects lobby websocket, unless "manualRejoin" sets to True in the session configuration. When "manualRejoin" is enabled, after lobby websocket reconnect, the game client will need to manually invoke join session again to rejoin the session.
    /// - If the user was on INVITED state before the disconnect happened, the user's status will return back to INVITED after they reconnect.
    /// 
    /// When the session type is a DS, a DS creation request will be sent if number of active players reaches session's minPlayers.
    /// Session service has several DSInformation status to track DS request to DS providers:
    /// - NEED_TO_REQUEST: number of active players hasn't reached session's minPlayers therefore DS has not yet requested.
    /// - REQUESTED: DS is being requested to DSMC.
    /// - PREPARING: DS needs to call manual set ready for the game session
    /// - AVAILABLE: DS is ready to use. The DSMC status for this DS is either READY/BUSY.
    /// - FAILED_TO_REQUEST: DSMC fails to spin up a DS for session.
    /// - DS_ERROR: DS provider fails to spin up the DS or the DS itself becomes unreachable
    /// - DS_CANCELLED: when DSMC is preparing the DS, DSMC will give a temporary DS. In this phase, if you delete the game session, the DS request will be canceled.
    /// - ENDED: when a game session (match) has finished and DS has done its job, it will terminate itself.
    /// - UNKNOWN: if any unknown DS status is detected.
    /// DSInformation has 2 fields for DS status: "status" and "statusV2". The "status" is there for backward-compatibility, therefore we encourage to just rely on "statusV2" for the more updated statuses.
    /// DS Source can be DSMC, AMS or custom. In DSMC, a DS request will be put in queue if they dont have available buffers, and DSMC will let the service knows when they finished spinning it up. While AMS doesn't have a concept of queue. Therefore some "DSInformation.statusV2" only applicable for DSMC.
    /// 
    /// By default, DS requests are sent to DSMC, but if dsSource is set to "AMS":
    /// - A DS will be requested from AMS instead of DSMC.
    /// - The server will be chosen based on a set of claim keys, in order of preference, to match with fleets.
    /// - The claim key list is built build from the preferredClaimKeys, fallbackClaimKeys, and clientVersion as follows:
    /// [preferredClaimKeys.., clientVersion, fallbackClaimKeys...]
    /// for session override can follow guideline in here https://docs.accelbyte.io/gaming-services/services/extend/override-ags-feature/getting-started-with-session-customization/
    /// </summary>
    public class CreateGameSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateGameSessionBuilder Builder { get => new CreateGameSessionBuilder(); }

        public class CreateGameSessionBuilder
            : OperationBuilder<CreateGameSessionBuilder>
        {





            internal CreateGameSessionBuilder() { }

            internal CreateGameSessionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateGameSession Build(
                ApimodelsCreateGameSessionRequest body,
                string namespace_
            )
            {
                CreateGameSession op = new CreateGameSession(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<CreateGameSessionBuilder>(this);
                return op;
            }

            public CreateGameSession.Response Execute(
                ApimodelsCreateGameSessionRequest body,
                string namespace_
            )
            {
                CreateGameSession op = Build(
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
            public async Task<CreateGameSession.Response> ExecuteAsync(
                ApimodelsCreateGameSessionRequest body,
                string namespace_
            )
            {
                CreateGameSession op = Build(
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

            public CreateGameSession.Response<T1, T2> Execute<T1, T2>(
                ApimodelsCreateGameSessionRequest body,
                string namespace_
            )
            {
                CreateGameSession op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<CreateGameSession.Response<T1, T2>> ExecuteAsync<T1, T2>(
                ApimodelsCreateGameSessionRequest body,
                string namespace_
            )
            {
                CreateGameSession op = Build(
                    body,
                    namespace_
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

        private CreateGameSession(CreateGameSessionBuilder builder,
            ApimodelsCreateGameSessionRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsGameSessionResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Session::GameSession::CreateGameSession";
        }

        public class Response<T1, T2> : ApiResponse<Model.ApimodelsGameSessionResponse<T1, T2>>
        {
            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Session::GameSession::CreateGameSession";
        }
        #endregion

        public CreateGameSession(
            string namespace_,
            Model.ApimodelsCreateGameSessionRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/gamesession";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public CreateGameSession.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateGameSession.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
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
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }

        public CreateGameSession.Response<T1, T2> ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateGameSession.Response<T1, T2>()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse<T1, T2>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
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
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}