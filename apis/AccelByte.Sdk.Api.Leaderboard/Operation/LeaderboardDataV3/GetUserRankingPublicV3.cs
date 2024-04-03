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
    /// getUserRankingPublicV3
    ///
    /// 
    /// 
    /// Get user ranking in leaderboard
    /// </summary>
    public class GetUserRankingPublicV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserRankingPublicV3Builder Builder { get => new GetUserRankingPublicV3Builder(); }

        public class GetUserRankingPublicV3Builder
            : OperationBuilder<GetUserRankingPublicV3Builder>
        {





            internal GetUserRankingPublicV3Builder() { }

            internal GetUserRankingPublicV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetUserRankingPublicV3 Build(
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                GetUserRankingPublicV3 op = new GetUserRankingPublicV3(this,
                    leaderboardCode,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GetUserRankingPublicV3Builder>(this);
                return op;
            }

            public Model.ModelsUserRankingResponseV3? Execute(
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                GetUserRankingPublicV3 op = Build(
                    leaderboardCode,
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
            public async Task<Model.ModelsUserRankingResponseV3?> ExecuteAsync(
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                GetUserRankingPublicV3 op = Build(
                    leaderboardCode,
                    namespace_,
                    userId
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

        private GetUserRankingPublicV3(GetUserRankingPublicV3Builder builder,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserRankingPublicV3(
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v3/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsUserRankingResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUserRankingResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUserRankingResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}