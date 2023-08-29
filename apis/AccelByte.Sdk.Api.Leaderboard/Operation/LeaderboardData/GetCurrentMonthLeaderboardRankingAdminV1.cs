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
    /// GetCurrentMonthLeaderboardRankingAdminV1
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:LEADERBOARD [READ]'
    /// 
    /// 
    /// 
    /// 
    /// Get rankings in current month leaderboard.
    /// </summary>
    public class GetCurrentMonthLeaderboardRankingAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCurrentMonthLeaderboardRankingAdminV1Builder Builder { get => new GetCurrentMonthLeaderboardRankingAdminV1Builder(); }

        public class GetCurrentMonthLeaderboardRankingAdminV1Builder
            : OperationBuilder<GetCurrentMonthLeaderboardRankingAdminV1Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public long? PreviousVersion { get; set; }





            internal GetCurrentMonthLeaderboardRankingAdminV1Builder() { }

            internal GetCurrentMonthLeaderboardRankingAdminV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetCurrentMonthLeaderboardRankingAdminV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetCurrentMonthLeaderboardRankingAdminV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetCurrentMonthLeaderboardRankingAdminV1Builder SetPreviousVersion(long _previousVersion)
            {
                PreviousVersion = _previousVersion;
                return this;
            }





            public GetCurrentMonthLeaderboardRankingAdminV1 Build(
                string leaderboardCode,
                string namespace_
            )
            {
                GetCurrentMonthLeaderboardRankingAdminV1 op = new GetCurrentMonthLeaderboardRankingAdminV1(this,
                    leaderboardCode,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsGetLeaderboardRankingResp? Execute(
                string leaderboardCode,
                string namespace_
            )
            {
                GetCurrentMonthLeaderboardRankingAdminV1 op = Build(
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

        private GetCurrentMonthLeaderboardRankingAdminV1(GetCurrentMonthLeaderboardRankingAdminV1Builder builder,
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

        public GetCurrentMonthLeaderboardRankingAdminV1(
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

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/month";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

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