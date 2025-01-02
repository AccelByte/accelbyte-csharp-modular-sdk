// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Sessionbrowser.Wrapper;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Api.Sessionbrowser.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Sessionbrowser
{
    [SdkConsoleCommand("sessionbrowser", "getactivematchmakinggamesessions")]
    public class GetActiveMatchmakingGameSessionsCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Sessionbrowser"; } }

        public string OperationName { get { return "GetActiveMatchmakingGameSessions"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("matchId")]
        public string? MatchId { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("serverRegion")]
        public string? ServerRegion { get; set; }

        [SdkCommandArgument("sessionId")]
        public string? SessionId { get; set; }

        public GetActiveMatchmakingGameSessionsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session wrapper = new AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session(_SDK);

#pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Sessionbrowser.Operation.GetActiveMatchmakingGameSessions.Builder;

            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (MatchId != null)
                opBuilder.SetMatchId((string)MatchId);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (ServerRegion != null)
                opBuilder.SetServerRegion((string)ServerRegion);
            if (SessionId != null)
                opBuilder.SetSessionId((string)SessionId);




            GetActiveMatchmakingGameSessions operation = opBuilder.Build(
                Namespace
            );

#pragma warning restore ab_deprecated_operation

#pragma warning disable ab_deprecated_operation_wrapper
            var response = wrapper.GetActiveMatchmakingGameSessions(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-", "response data is null.");
            }
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
#pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}