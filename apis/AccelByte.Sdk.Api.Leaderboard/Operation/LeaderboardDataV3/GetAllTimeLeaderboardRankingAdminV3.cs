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

using AccelByte.Sdk.Api.Leaderboard.Model;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    /// <summary>
    /// GetAllTimeLeaderboardRankingAdminV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:LEADERBOARD [READ]'
    /// 
    /// 
    /// 
    /// 
    /// Get rankings in an all time leaderboard.
    /// </summary>
    public class GetAllTimeLeaderboardRankingAdminV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAllTimeLeaderboardRankingAdminV3Builder Builder { get => new GetAllTimeLeaderboardRankingAdminV3Builder(); }

        public class GetAllTimeLeaderboardRankingAdminV3Builder
            : OperationBuilder<GetAllTimeLeaderboardRankingAdminV3Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetAllTimeLeaderboardRankingAdminV3Builder() { }

            internal GetAllTimeLeaderboardRankingAdminV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetAllTimeLeaderboardRankingAdminV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetAllTimeLeaderboardRankingAdminV3Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetAllTimeLeaderboardRankingAdminV3 Build(
                string leaderboardCode,
                string namespace_
            )
            {
                GetAllTimeLeaderboardRankingAdminV3 op = new GetAllTimeLeaderboardRankingAdminV3(this,
                    leaderboardCode,
                    namespace_
                );

                op.SetBaseFields<GetAllTimeLeaderboardRankingAdminV3Builder>(this);
                return op;
            }

            public Model.ModelsGetLeaderboardRankingResp? Execute(
                string leaderboardCode,
                string namespace_
            )
            {
                GetAllTimeLeaderboardRankingAdminV3 op = Build(
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
        }

        private GetAllTimeLeaderboardRankingAdminV3(GetAllTimeLeaderboardRankingAdminV3Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetAllTimeLeaderboardRankingAdminV3(
            string leaderboardCode,
            string namespace_,
            long? limit,
            long? offset
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v3/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/alltime";

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