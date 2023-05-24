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
    /// SearchSessionsV2
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
    /// Search sessions. Optimize the query by differentiating query with filter namespace only and filter with namespace & other filter (partyID, userID, matchID).
    /// Query with filter namespace only will not group whole session data while query with filter namespace & other filter will include session data.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class SearchSessionsV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SearchSessionsV2Builder Builder { get => new SearchSessionsV2Builder(); }

        public class SearchSessionsV2Builder
            : OperationBuilder<SearchSessionsV2Builder>
        {

            public string? Channel { get; set; }

            public bool? Deleted { get; set; }

            public string? MatchID { get; set; }

            public string? PartyID { get; set; }

            public string? UserID { get; set; }





            internal SearchSessionsV2Builder() { }

            internal SearchSessionsV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public SearchSessionsV2Builder SetChannel(string _channel)
            {
                Channel = _channel;
                return this;
            }

            public SearchSessionsV2Builder SetDeleted(bool _deleted)
            {
                Deleted = _deleted;
                return this;
            }

            public SearchSessionsV2Builder SetMatchID(string _matchID)
            {
                MatchID = _matchID;
                return this;
            }

            public SearchSessionsV2Builder SetPartyID(string _partyID)
            {
                PartyID = _partyID;
                return this;
            }

            public SearchSessionsV2Builder SetUserID(string _userID)
            {
                UserID = _userID;
                return this;
            }





            public SearchSessionsV2 Build(
                string namespace_,
                long limit,
                long offset
            )
            {
                SearchSessionsV2 op = new SearchSessionsV2(this,
                    namespace_,
                    limit,
                    offset
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ServiceGetSessionHistorySearchResponseV2? Execute(
                string namespace_,
                long limit,
                long offset
            )
            {
                SearchSessionsV2 op = Build(
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

        private SearchSessionsV2(SearchSessionsV2Builder builder,
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

        public SearchSessionsV2(
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

        public override string Path => "/matchmaking/v2/admin/namespaces/{namespace}/sessions/history/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ServiceGetSessionHistorySearchResponseV2? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ServiceGetSessionHistorySearchResponseV2>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ServiceGetSessionHistorySearchResponseV2>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}