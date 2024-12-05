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

using AccelByte.Sdk.Api.Leaderboard.Model;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    /// <summary>
    /// GetCurrentSeasonLeaderboardRankingPublicV1
    ///
    /// 
    /// 
    /// Get rankings in current season leaderboard.
    /// </summary>
    public class GetCurrentSeasonLeaderboardRankingPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCurrentSeasonLeaderboardRankingPublicV1Builder Builder { get => new GetCurrentSeasonLeaderboardRankingPublicV1Builder(); }

        public class GetCurrentSeasonLeaderboardRankingPublicV1Builder
            : OperationBuilder<GetCurrentSeasonLeaderboardRankingPublicV1Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public long? PreviousVersion { get; set; }





            internal GetCurrentSeasonLeaderboardRankingPublicV1Builder() { }

            internal GetCurrentSeasonLeaderboardRankingPublicV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetCurrentSeasonLeaderboardRankingPublicV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetCurrentSeasonLeaderboardRankingPublicV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetCurrentSeasonLeaderboardRankingPublicV1Builder SetPreviousVersion(long _previousVersion)
            {
                PreviousVersion = _previousVersion;
                return this;
            }





            public GetCurrentSeasonLeaderboardRankingPublicV1 Build(
                string leaderboardCode,
                string namespace_
            )
            {
                GetCurrentSeasonLeaderboardRankingPublicV1 op = new GetCurrentSeasonLeaderboardRankingPublicV1(this,
                    leaderboardCode,
                    namespace_
                );

                op.SetBaseFields<GetCurrentSeasonLeaderboardRankingPublicV1Builder>(this);
                return op;
            }

            public GetCurrentSeasonLeaderboardRankingPublicV1.Response Execute(
                string leaderboardCode,
                string namespace_
            )
            {
                GetCurrentSeasonLeaderboardRankingPublicV1 op = Build(
                    leaderboardCode,
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
            public async Task<GetCurrentSeasonLeaderboardRankingPublicV1.Response> ExecuteAsync(
                string leaderboardCode,
                string namespace_
            )
            {
                GetCurrentSeasonLeaderboardRankingPublicV1 op = Build(
                    leaderboardCode,
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
        }

        private GetCurrentSeasonLeaderboardRankingPublicV1(GetCurrentSeasonLeaderboardRankingPublicV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PreviousVersion != null) QueryParams["previousVersion"] = Convert.ToString(builder.PreviousVersion)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsGetLeaderboardRankingResp>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Leaderboard::LeaderboardData::GetCurrentSeasonLeaderboardRankingPublicV1";
        }

        #endregion

        public GetCurrentSeasonLeaderboardRankingPublicV1(
            string leaderboardCode,
            string namespace_,
            long? limit,
            long? offset,
            long? previousVersion
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (previousVersion != null) QueryParams["previousVersion"] = Convert.ToString(previousVersion)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/season";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public GetCurrentSeasonLeaderboardRankingPublicV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetCurrentSeasonLeaderboardRankingPublicV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsGetLeaderboardRankingResp>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}