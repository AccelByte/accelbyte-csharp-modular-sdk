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
    /// GetCurrentMonthLeaderboardRankingPublicV1
    ///
    /// 
    /// 
    /// Get rankings in current month leaderboard.
    /// </summary>
    public class GetCurrentMonthLeaderboardRankingPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCurrentMonthLeaderboardRankingPublicV1Builder Builder { get => new GetCurrentMonthLeaderboardRankingPublicV1Builder(); }

        public class GetCurrentMonthLeaderboardRankingPublicV1Builder
            : OperationBuilder<GetCurrentMonthLeaderboardRankingPublicV1Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public long? PreviousVersion { get; set; }





            internal GetCurrentMonthLeaderboardRankingPublicV1Builder() { }

            internal GetCurrentMonthLeaderboardRankingPublicV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetCurrentMonthLeaderboardRankingPublicV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetCurrentMonthLeaderboardRankingPublicV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetCurrentMonthLeaderboardRankingPublicV1Builder SetPreviousVersion(long _previousVersion)
            {
                PreviousVersion = _previousVersion;
                return this;
            }





            public GetCurrentMonthLeaderboardRankingPublicV1 Build(
                string leaderboardCode,
                string namespace_
            )
            {
                GetCurrentMonthLeaderboardRankingPublicV1 op = new GetCurrentMonthLeaderboardRankingPublicV1(this,
                    leaderboardCode,
                    namespace_
                );

                op.SetBaseFields<GetCurrentMonthLeaderboardRankingPublicV1Builder>(this);
                return op;
            }

            public Model.ModelsGetLeaderboardRankingResp? Execute(
                string leaderboardCode,
                string namespace_
            )
            {
                GetCurrentMonthLeaderboardRankingPublicV1 op = Build(
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
            public async Task<Model.ModelsGetLeaderboardRankingResp?> ExecuteAsync(
                string leaderboardCode,
                string namespace_
            )
            {
                GetCurrentMonthLeaderboardRankingPublicV1 op = Build(
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

        private GetCurrentMonthLeaderboardRankingPublicV1(GetCurrentMonthLeaderboardRankingPublicV1Builder builder,
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

        public GetCurrentMonthLeaderboardRankingPublicV1(
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

        public override string Path => "/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/month";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsGetLeaderboardRankingResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetLeaderboardRankingResp>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetLeaderboardRankingResp>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}