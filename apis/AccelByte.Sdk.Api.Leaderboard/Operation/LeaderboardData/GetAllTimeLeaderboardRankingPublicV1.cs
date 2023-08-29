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
    /// GetAllTimeLeaderboardRankingPublicV1
    ///
    /// 
    /// 
    /// Get rankings in an all time leaderboard.
    /// </summary>
    public class GetAllTimeLeaderboardRankingPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAllTimeLeaderboardRankingPublicV1Builder Builder { get => new GetAllTimeLeaderboardRankingPublicV1Builder(); }

        public class GetAllTimeLeaderboardRankingPublicV1Builder
            : OperationBuilder<GetAllTimeLeaderboardRankingPublicV1Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetAllTimeLeaderboardRankingPublicV1Builder() { }

            internal GetAllTimeLeaderboardRankingPublicV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetAllTimeLeaderboardRankingPublicV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetAllTimeLeaderboardRankingPublicV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetAllTimeLeaderboardRankingPublicV1 Build(
                string leaderboardCode,
                string namespace_
            )
            {
                GetAllTimeLeaderboardRankingPublicV1 op = new GetAllTimeLeaderboardRankingPublicV1(this,
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
                GetAllTimeLeaderboardRankingPublicV1 op = Build(
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

        private GetAllTimeLeaderboardRankingPublicV1(GetAllTimeLeaderboardRankingPublicV1Builder builder,
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

        public GetAllTimeLeaderboardRankingPublicV1(
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

        public override string Path => "/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/alltime";

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