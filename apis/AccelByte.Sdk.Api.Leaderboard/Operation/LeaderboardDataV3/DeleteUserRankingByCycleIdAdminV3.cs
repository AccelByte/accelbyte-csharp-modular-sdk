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
    /// deleteUserRankingByCycleIdAdminV3
    ///
    /// Delete user ranking by cycle id
    /// 
    /// Remove entry with provided cycleId and userId from leaderboard.
    /// If leaderboard with given leaderboard code not found, it will return http status not found (404).
    /// If the leaderboard is found and no entry found in it, it will still return success (204)
    /// </summary>
    public class DeleteUserRankingByCycleIdAdminV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserRankingByCycleIdAdminV3Builder Builder { get => new DeleteUserRankingByCycleIdAdminV3Builder(); }

        public class DeleteUserRankingByCycleIdAdminV3Builder
            : OperationBuilder<DeleteUserRankingByCycleIdAdminV3Builder>
        {





            internal DeleteUserRankingByCycleIdAdminV3Builder() { }

            internal DeleteUserRankingByCycleIdAdminV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteUserRankingByCycleIdAdminV3 Build(
                string cycleId,
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                DeleteUserRankingByCycleIdAdminV3 op = new DeleteUserRankingByCycleIdAdminV3(this,
                    cycleId,
                    leaderboardCode,
                    namespace_,
                    userId
                );

                op.SetBaseFields<DeleteUserRankingByCycleIdAdminV3Builder>(this);
                return op;
            }

            public void Execute(
                string cycleId,
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                DeleteUserRankingByCycleIdAdminV3 op = Build(
                    cycleId,
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
            public async Task ExecuteAsync(
                string cycleId,
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                DeleteUserRankingByCycleIdAdminV3 op = Build(
                    cycleId,
                    leaderboardCode,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private DeleteUserRankingByCycleIdAdminV3(DeleteUserRankingByCycleIdAdminV3Builder builder,
            string cycleId,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteUserRankingByCycleIdAdminV3(
            string cycleId,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v3/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/cycles/{cycleId}/users/{userId}";

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