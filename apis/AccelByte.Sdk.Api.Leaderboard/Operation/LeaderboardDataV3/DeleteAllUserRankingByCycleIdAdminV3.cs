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
    /// deleteAllUserRankingByCycleIdAdminV3
    ///
    /// 
    /// 
    /// This endpoint will delete user ranking by cycleId
    /// 
    /// 
    /// 
    /// 
    /// Warning : This will permanently delete your data. Make sure to back up anything important before continuing.
    /// </summary>
    public class DeleteAllUserRankingByCycleIdAdminV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteAllUserRankingByCycleIdAdminV3Builder Builder { get => new DeleteAllUserRankingByCycleIdAdminV3Builder(); }

        public class DeleteAllUserRankingByCycleIdAdminV3Builder
            : OperationBuilder<DeleteAllUserRankingByCycleIdAdminV3Builder>
        {





            internal DeleteAllUserRankingByCycleIdAdminV3Builder() { }

            internal DeleteAllUserRankingByCycleIdAdminV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteAllUserRankingByCycleIdAdminV3 Build(
                string cycleId,
                string leaderboardCode,
                string namespace_
            )
            {
                DeleteAllUserRankingByCycleIdAdminV3 op = new DeleteAllUserRankingByCycleIdAdminV3(this,
                    cycleId,
                    leaderboardCode,
                    namespace_
                );

                op.SetBaseFields<DeleteAllUserRankingByCycleIdAdminV3Builder>(this);
                return op;
            }

            public void Execute(
                string cycleId,
                string leaderboardCode,
                string namespace_
            )
            {
                DeleteAllUserRankingByCycleIdAdminV3 op = Build(
                    cycleId,
                    leaderboardCode,
                    namespace_
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
                string namespace_
            )
            {
                DeleteAllUserRankingByCycleIdAdminV3 op = Build(
                    cycleId,
                    leaderboardCode,
                    namespace_
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

        private DeleteAllUserRankingByCycleIdAdminV3(DeleteAllUserRankingByCycleIdAdminV3Builder builder,
            string cycleId,
            string leaderboardCode,
            string namespace_
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteAllUserRankingByCycleIdAdminV3(
            string cycleId,
            string leaderboardCode,
            string namespace_
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v3/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/cycles/{cycleId}/reset";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

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