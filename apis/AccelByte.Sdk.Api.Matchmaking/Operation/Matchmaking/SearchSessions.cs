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

using AccelByte.Sdk.Api.Matchmaking.Model;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// SearchSessions
    ///
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    /// 
    /// 
    ///   * Substitute endpoint: /sessionbrowser/admin/namespaces/{namespace}/sessions/history/search [GET]
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [Read]
    /// 
    /// Required Scope: social
    /// 
    /// Search sessions.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class SearchSessions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SearchSessionsBuilder Builder { get => new SearchSessionsBuilder(); }

        public class SearchSessionsBuilder
            : OperationBuilder<SearchSessionsBuilder>
        {

            public string? Channel { get; set; }

            public bool? Deleted { get; set; }

            public string? MatchID { get; set; }

            public string? PartyID { get; set; }

            public string? UserID { get; set; }





            internal SearchSessionsBuilder() { }

            internal SearchSessionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public SearchSessionsBuilder SetChannel(string _channel)
            {
                Channel = _channel;
                return this;
            }

            public SearchSessionsBuilder SetDeleted(bool _deleted)
            {
                Deleted = _deleted;
                return this;
            }

            public SearchSessionsBuilder SetMatchID(string _matchID)
            {
                MatchID = _matchID;
                return this;
            }

            public SearchSessionsBuilder SetPartyID(string _partyID)
            {
                PartyID = _partyID;
                return this;
            }

            public SearchSessionsBuilder SetUserID(string _userID)
            {
                UserID = _userID;
                return this;
            }





            public SearchSessions Build(
                string namespace_,
                long limit,
                long offset
            )
            {
                SearchSessions op = new SearchSessions(this,
                    namespace_,
                    limit,
                    offset
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ServiceGetSessionHistorySearchResponse? Execute(
                string namespace_,
                long limit,
                long offset
            )
            {
                SearchSessions op = Build(
                    namespace_,
                    limit,
                    offset
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

        private SearchSessions(SearchSessionsBuilder builder,
            string namespace_,
            long limit,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Channel is not null) QueryParams["channel"] = builder.Channel;
            if (builder.Deleted != null) QueryParams["deleted"] = Convert.ToString(builder.Deleted)!;
            if (builder.MatchID is not null) QueryParams["matchID"] = builder.MatchID;
            if (builder.PartyID is not null) QueryParams["partyID"] = builder.PartyID;
            if (builder.UserID is not null) QueryParams["userID"] = builder.UserID;
            QueryParams["limit"] = Convert.ToString(limit)!;
            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SearchSessions(
            string namespace_,
            string? channel,
            bool? deleted,
            string? matchID,
            string? partyID,
            string? userID,
            long limit,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (channel is not null) QueryParams["channel"] = channel;
            if (deleted != null) QueryParams["deleted"] = Convert.ToString(deleted)!;
            if (matchID is not null) QueryParams["matchID"] = matchID;
            if (partyID is not null) QueryParams["partyID"] = partyID;
            if (userID is not null) QueryParams["userID"] = userID;
            QueryParams["limit"] = Convert.ToString(limit)!;
            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/sessions/history/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ServiceGetSessionHistorySearchResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ServiceGetSessionHistorySearchResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ServiceGetSessionHistorySearchResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}