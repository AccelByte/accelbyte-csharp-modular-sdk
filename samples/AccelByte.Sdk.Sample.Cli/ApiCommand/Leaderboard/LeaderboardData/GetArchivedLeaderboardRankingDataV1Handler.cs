// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Leaderboard.Wrapper;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Leaderboard
{
    [SdkConsoleCommand("leaderboard","getarchivedleaderboardrankingdatav1handler")]
    public class GetArchivedLeaderboardRankingDataV1HandlerCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Leaderboard"; } }

        public string OperationName{ get { return "GetArchivedLeaderboardRankingDataV1Handler"; } }

        [SdkCommandArgument("leaderboardCode")]
        public string LeaderboardCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("slug")]
        public string? Slug { get; set; }

        [SdkCommandArgument("leaderboardCodes")]
        public string LeaderboardCodes { get; set; } = String.Empty;

        public GetArchivedLeaderboardRankingDataV1HandlerCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardData wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardData(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Leaderboard.Operation.GetArchivedLeaderboardRankingDataV1Handler.Builder;

            if (Slug != null)
                opBuilder.SetSlug((string)Slug);




            GetArchivedLeaderboardRankingDataV1Handler operation = opBuilder.Build(
                LeaderboardCode,
                Namespace,
                LeaderboardCodes
            );


            List<AccelByte.Sdk.Api.Leaderboard.Model.ModelsArchiveLeaderboardSignedURLResponse>? response = wrapper.GetArchivedLeaderboardRankingDataV1Handler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}