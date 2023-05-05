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
    /// UserQuerySession
    ///
    /// Required permission: NAMESPACE:{namespace}:SESSIONBROWSER:SESSION [READ]
    /// 
    /// Required scope: social
    /// 
    /// Query available game session
    /// </summary>
    public class UserQuerySession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UserQuerySessionBuilder Builder { get => new UserQuerySessionBuilder(); }

        public class UserQuerySessionBuilder
            : OperationBuilder<UserQuerySessionBuilder>
        {

            public string? GameMode { get; set; }

            public string? GameVersion { get; set; }

            public string? Joinable { get; set; }

            public long? Limit { get; set; }

            public string? MatchExist { get; set; }

            public string? MatchId { get; set; }

            public long? Offset { get; set; }

            public string? ServerStatus { get; set; }

            public string? UserId { get; set; }





            internal UserQuerySessionBuilder() { }

            internal UserQuerySessionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public UserQuerySessionBuilder SetGameMode(string _gameMode)
            {
                GameMode = _gameMode;
                return this;
            }

            public UserQuerySessionBuilder SetGameVersion(string _gameVersion)
            {
                GameVersion = _gameVersion;
                return this;
            }

            public UserQuerySessionBuilder SetJoinable(string _joinable)
            {
                Joinable = _joinable;
                return this;
            }

            public UserQuerySessionBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public UserQuerySessionBuilder SetMatchExist(string _matchExist)
            {
                MatchExist = _matchExist;
                return this;
            }

            public UserQuerySessionBuilder SetMatchId(string _matchId)
            {
                MatchId = _matchId;
                return this;
            }

            public UserQuerySessionBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public UserQuerySessionBuilder SetServerStatus(string _serverStatus)
            {
                ServerStatus = _serverStatus;
                return this;
            }

            public UserQuerySessionBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public UserQuerySession Build(
                string namespace_,
                string sessionType
            )
            {
                UserQuerySession op = new UserQuerySession(this,
                    namespace_,                    
                    sessionType                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsSessionQueryResponse? Execute(
                string namespace_,
                string sessionType
            )
            {
                UserQuerySession op = Build(
                    namespace_,
                    sessionType
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

        private UserQuerySession(UserQuerySessionBuilder builder,
            string namespace_,
            string sessionType
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.GameMode is not null) QueryParams["game_mode"] = builder.GameMode;
            if (builder.GameVersion is not null) QueryParams["game_version"] = builder.GameVersion;
            if (builder.Joinable is not null) QueryParams["joinable"] = builder.Joinable;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.MatchExist is not null) QueryParams["match_exist"] = builder.MatchExist;
            if (builder.MatchId is not null) QueryParams["match_id"] = builder.MatchId;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.ServerStatus is not null) QueryParams["server_status"] = builder.ServerStatus;
            if (builder.UserId is not null) QueryParams["user_id"] = builder.UserId;
            if (sessionType is not null) QueryParams["session_type"] = sessionType;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UserQuerySession(
            string namespace_,            
            string? gameMode,            
            string? gameVersion,            
            string? joinable,            
            long? limit,            
            string? matchExist,            
            string? matchId,            
            long? offset,            
            string? serverStatus,            
            string? userId,            
            string sessionType            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (gameMode is not null) QueryParams["game_mode"] = gameMode;
            if (gameVersion is not null) QueryParams["game_version"] = gameVersion;
            if (joinable is not null) QueryParams["joinable"] = joinable;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (matchExist is not null) QueryParams["match_exist"] = matchExist;
            if (matchId is not null) QueryParams["match_id"] = matchId;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (serverStatus is not null) QueryParams["server_status"] = serverStatus;
            if (userId is not null) QueryParams["user_id"] = userId;
            if (sessionType is not null) QueryParams["session_type"] = sessionType;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsSessionQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionQueryResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionQueryResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}