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
    /// getUserLeaderboardRankingsAdminV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:LEADERBOARD [READ]'
    /// 
    /// 
    /// 
    /// 
    /// Get user leaderboard rankings
    /// </summary>
    public class GetUserLeaderboardRankingsAdminV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserLeaderboardRankingsAdminV3Builder Builder { get => new GetUserLeaderboardRankingsAdminV3Builder(); }

        public class GetUserLeaderboardRankingsAdminV3Builder
            : OperationBuilder<GetUserLeaderboardRankingsAdminV3Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetUserLeaderboardRankingsAdminV3Builder() { }

            internal GetUserLeaderboardRankingsAdminV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserLeaderboardRankingsAdminV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetUserLeaderboardRankingsAdminV3Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetUserLeaderboardRankingsAdminV3 Build(
                string namespace_,
                string userId
            )
            {
                GetUserLeaderboardRankingsAdminV3 op = new GetUserLeaderboardRankingsAdminV3(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsGetAllUserLeaderboardsRespV3? Execute(
                string namespace_,
                string userId
            )
            {
                GetUserLeaderboardRankingsAdminV3 op = Build(
                    namespace_,
                    userId
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

        private GetUserLeaderboardRankingsAdminV3(GetUserLeaderboardRankingsAdminV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserLeaderboardRankingsAdminV3(
            string namespace_,            
            string userId,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v3/admin/namespaces/{namespace}/users/{userId}/leaderboards";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsGetAllUserLeaderboardsRespV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllUserLeaderboardsRespV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllUserLeaderboardsRespV3>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}