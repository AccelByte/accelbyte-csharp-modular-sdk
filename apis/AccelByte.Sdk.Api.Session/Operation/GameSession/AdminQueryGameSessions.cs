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
    /// adminQueryGameSessions
    ///
    /// Get all game sessions. Requires ADMIN:NAMESPACE:{namespace}:SESSION:GAME [READ]
    /// </summary>
    public class AdminQueryGameSessions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminQueryGameSessionsBuilder Builder { get => new AdminQueryGameSessionsBuilder(); }

        public class AdminQueryGameSessionsBuilder
            : OperationBuilder<AdminQueryGameSessionsBuilder>
        {

            public string? ConfigurationName { get; set; }

            public string? DsPodName { get; set; }

            public string? FromTime { get; set; }

            public string? GameMode { get; set; }

            public string? IsPersistent { get; set; }

            public string? IsSoftDeleted { get; set; }

            public string? Joinability { get; set; }

            public long? Limit { get; set; }

            public string? MatchPool { get; set; }

            public string? MemberID { get; set; }

            public long? Offset { get; set; }

            public string? Order { get; set; }

            public string? OrderBy { get; set; }

            public string? SessionID { get; set; }

            public string? Status { get; set; }

            public string? StatusV2 { get; set; }

            public string? ToTime { get; set; }





            internal AdminQueryGameSessionsBuilder() { }

            internal AdminQueryGameSessionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminQueryGameSessionsBuilder SetConfigurationName(string _configurationName)
            {
                ConfigurationName = _configurationName;
                return this;
            }

            public AdminQueryGameSessionsBuilder SetDsPodName(string _dsPodName)
            {
                DsPodName = _dsPodName;
                return this;
            }

            public AdminQueryGameSessionsBuilder SetFromTime(string _fromTime)
            {
                FromTime = _fromTime;
                return this;
            }

            public AdminQueryGameSessionsBuilder SetGameMode(string _gameMode)
            {
                GameMode = _gameMode;
                return this;
            }

            public AdminQueryGameSessionsBuilder SetIsPersistent(string _isPersistent)
            {
                IsPersistent = _isPersistent;
                return this;
            }

            public AdminQueryGameSessionsBuilder SetIsSoftDeleted(string _isSoftDeleted)
            {
                IsSoftDeleted = _isSoftDeleted;
                return this;
            }

            public AdminQueryGameSessionsBuilder SetJoinability(string _joinability)
            {
                Joinability = _joinability;
                return this;
            }

            public AdminQueryGameSessionsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminQueryGameSessionsBuilder SetMatchPool(string _matchPool)
            {
                MatchPool = _matchPool;
                return this;
            }

            public AdminQueryGameSessionsBuilder SetMemberID(string _memberID)
            {
                MemberID = _memberID;
                return this;
            }

            public AdminQueryGameSessionsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminQueryGameSessionsBuilder SetOrder(string _order)
            {
                Order = _order;
                return this;
            }

            public AdminQueryGameSessionsBuilder SetOrderBy(string _orderBy)
            {
                OrderBy = _orderBy;
                return this;
            }

            public AdminQueryGameSessionsBuilder SetSessionID(string _sessionID)
            {
                SessionID = _sessionID;
                return this;
            }

            public AdminQueryGameSessionsBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }

            public AdminQueryGameSessionsBuilder SetStatusV2(string _statusV2)
            {
                StatusV2 = _statusV2;
                return this;
            }

            public AdminQueryGameSessionsBuilder SetToTime(string _toTime)
            {
                ToTime = _toTime;
                return this;
            }





            public AdminQueryGameSessions Build(
                string namespace_
            )
            {
                AdminQueryGameSessions op = new AdminQueryGameSessions(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ApimodelsGameSessionQueryResponse? Execute(
                string namespace_
            )
            {
                AdminQueryGameSessions op = Build(
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
        }

        private AdminQueryGameSessions(AdminQueryGameSessionsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ConfigurationName is not null) QueryParams["configurationName"] = builder.ConfigurationName;
            if (builder.DsPodName is not null) QueryParams["dsPodName"] = builder.DsPodName;
            if (builder.FromTime is not null) QueryParams["fromTime"] = builder.FromTime;
            if (builder.GameMode is not null) QueryParams["gameMode"] = builder.GameMode;
            if (builder.IsPersistent is not null) QueryParams["isPersistent"] = builder.IsPersistent;
            if (builder.IsSoftDeleted is not null) QueryParams["isSoftDeleted"] = builder.IsSoftDeleted;
            if (builder.Joinability is not null) QueryParams["joinability"] = builder.Joinability;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.MatchPool is not null) QueryParams["matchPool"] = builder.MatchPool;
            if (builder.MemberID is not null) QueryParams["memberID"] = builder.MemberID;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Order is not null) QueryParams["order"] = builder.Order;
            if (builder.OrderBy is not null) QueryParams["orderBy"] = builder.OrderBy;
            if (builder.SessionID is not null) QueryParams["sessionID"] = builder.SessionID;
            if (builder.Status is not null) QueryParams["status"] = builder.Status;
            if (builder.StatusV2 is not null) QueryParams["statusV2"] = builder.StatusV2;
            if (builder.ToTime is not null) QueryParams["toTime"] = builder.ToTime;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminQueryGameSessions(
            string namespace_,            
            string? configurationName,            
            string? dsPodName,            
            string? fromTime,            
            string? gameMode,            
            string? isPersistent,            
            string? isSoftDeleted,            
            string? joinability,            
            long? limit,            
            string? matchPool,            
            string? memberID,            
            long? offset,            
            string? order,            
            string? orderBy,            
            string? sessionID,            
            string? status,            
            string? statusV2,            
            string? toTime            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (configurationName is not null) QueryParams["configurationName"] = configurationName;
            if (dsPodName is not null) QueryParams["dsPodName"] = dsPodName;
            if (fromTime is not null) QueryParams["fromTime"] = fromTime;
            if (gameMode is not null) QueryParams["gameMode"] = gameMode;
            if (isPersistent is not null) QueryParams["isPersistent"] = isPersistent;
            if (isSoftDeleted is not null) QueryParams["isSoftDeleted"] = isSoftDeleted;
            if (joinability is not null) QueryParams["joinability"] = joinability;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (matchPool is not null) QueryParams["matchPool"] = matchPool;
            if (memberID is not null) QueryParams["memberID"] = memberID;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (order is not null) QueryParams["order"] = order;
            if (orderBy is not null) QueryParams["orderBy"] = orderBy;
            if (sessionID is not null) QueryParams["sessionID"] = sessionID;
            if (status is not null) QueryParams["status"] = status;
            if (statusV2 is not null) QueryParams["statusV2"] = statusV2;
            if (toTime is not null) QueryParams["toTime"] = toTime;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/gamesessions";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ApimodelsGameSessionQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionQueryResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionQueryResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}