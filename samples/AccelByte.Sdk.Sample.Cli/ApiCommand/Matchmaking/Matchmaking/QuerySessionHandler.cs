// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Matchmaking.Wrapper;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Matchmaking
{
    [SdkConsoleCommand("matchmaking", "querysessionhandler")]
    public class QuerySessionHandlerCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Matchmaking"; } }

        public string OperationName { get { return "QuerySessionHandler"; } }

        [SdkCommandArgument("matchID")]
        public string MatchID { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public QuerySessionHandlerCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking wrapper = new AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Matchmaking.Operation.QuerySessionHandler.Builder;





            QuerySessionHandler operation = opBuilder.Build(
                MatchID,
                Namespace
            );


            AccelByte.Sdk.Api.Matchmaking.Model.ModelsMatchmakingResult? response = wrapper.QuerySessionHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}