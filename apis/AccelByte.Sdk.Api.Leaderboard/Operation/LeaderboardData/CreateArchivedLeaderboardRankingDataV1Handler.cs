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
    /// CreateArchivedLeaderboardRankingDataV1Handler
    ///
    /// 
    /// 
    /// Archive leaderboard ranking data for specified leaderboard codes. NOTE: This will remove all data of the leaderboard on every slug,
    /// remove the leaderboard code on stat mapping, and remove the leaderboard on the queue reset. This will be a bulk endpoint
    /// </summary>
    public class CreateArchivedLeaderboardRankingDataV1Handler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateArchivedLeaderboardRankingDataV1HandlerBuilder Builder { get => new CreateArchivedLeaderboardRankingDataV1HandlerBuilder(); }

        public class CreateArchivedLeaderboardRankingDataV1HandlerBuilder
            : OperationBuilder<CreateArchivedLeaderboardRankingDataV1HandlerBuilder>
        {





            internal CreateArchivedLeaderboardRankingDataV1HandlerBuilder() { }

            internal CreateArchivedLeaderboardRankingDataV1HandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateArchivedLeaderboardRankingDataV1Handler Build(
                ModelsArchiveLeaderboardReq body,
                string namespace_
            )
            {
                CreateArchivedLeaderboardRankingDataV1Handler op = new CreateArchivedLeaderboardRankingDataV1Handler(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<CreateArchivedLeaderboardRankingDataV1HandlerBuilder>(this);
                return op;
            }

            public void Execute(
                ModelsArchiveLeaderboardReq body,
                string namespace_
            )
            {
                CreateArchivedLeaderboardRankingDataV1Handler op = Build(
                    body,
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
        }

        private CreateArchivedLeaderboardRankingDataV1Handler(CreateArchivedLeaderboardRankingDataV1HandlerBuilder builder,
            ModelsArchiveLeaderboardReq body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateArchivedLeaderboardRankingDataV1Handler(
            string namespace_,
            Model.ModelsArchiveLeaderboardReq body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/archived";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}