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
    [SdkConsoleCommand("leaderboard", "getleaderboardconfigurationspublicv1")]
    public class GetLeaderboardConfigurationsPublicV1Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Leaderboard"; } }

        public string OperationName { get { return "GetLeaderboardConfigurationsPublicV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("isArchived")]
        public bool? IsArchived { get; set; }

        [SdkCommandArgument("isDeleted")]
        public bool? IsDeleted { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        public GetLeaderboardConfigurationsPublicV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardConfiguration wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardConfiguration(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Leaderboard.Operation.GetLeaderboardConfigurationsPublicV1.Builder;

            if (IsArchived != null)
                opBuilder.SetIsArchived((bool)IsArchived);
            if (IsDeleted != null)
                opBuilder.SetIsDeleted((bool)IsDeleted);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);




            GetLeaderboardConfigurationsPublicV1 operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Leaderboard.Model.ModelsGetAllLeaderboardConfigsPublicResp? response = wrapper.GetLeaderboardConfigurationsPublicV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}