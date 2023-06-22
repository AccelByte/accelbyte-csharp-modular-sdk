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
    /// deleteUserRankingPublicV1
    ///
    /// Delete user ranking
    /// Required permission: NAMESPACE:{namespace}:LEADERBOARD:USER:{userId} [DELETE]
    /// 
    /// Remove entry with provided userId from leaderboard.
    /// If leaderboard with given leaderboard code not found, it will return http status not found (404).
    /// If the leaderboard is found and no entry found in it, it will still return success (204)
    /// </summary>
    public class DeleteUserRankingPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserRankingPublicV1Builder Builder { get => new DeleteUserRankingPublicV1Builder(); }

        public class DeleteUserRankingPublicV1Builder
            : OperationBuilder<DeleteUserRankingPublicV1Builder>
        {





            internal DeleteUserRankingPublicV1Builder() { }

            internal DeleteUserRankingPublicV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteUserRankingPublicV1 Build(
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                DeleteUserRankingPublicV1 op = new DeleteUserRankingPublicV1(this,
                    leaderboardCode,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                DeleteUserRankingPublicV1 op = Build(
                    leaderboardCode,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private DeleteUserRankingPublicV1(DeleteUserRankingPublicV1Builder builder,
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

        public DeleteUserRankingPublicV1(
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

        public override string Path => "/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}