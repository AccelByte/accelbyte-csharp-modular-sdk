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

                op.SetBaseFields<SearchSessionsBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public SearchSessions.Response Execute(
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
            public async Task<SearchSessions.Response> ExecuteAsync(
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

                var response = await _Sdk.RunRequestAsync(op);
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

        #region Response Part        
        public class Response : ApiResponse<Model.ServiceGetSessionHistorySearchResponse>
        {

            public ResponseErrorV1? Error400 { get; set; } = null;

            public ResponseErrorV1? Error401 { get; set; } = null;

            public ResponseErrorV1? Error403 { get; set; } = null;

            public ResponseErrorV1? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Matchmaking::Matchmaking::SearchSessions";
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

        public SearchSessions.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new SearchSessions.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ServiceGetSessionHistorySearchResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseErrorV1>(payload, ResponseJsonOptions);
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