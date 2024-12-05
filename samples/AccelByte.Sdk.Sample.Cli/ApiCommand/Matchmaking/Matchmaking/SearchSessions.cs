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
    [SdkConsoleCommand("matchmaking", "searchsessions")]
    public class SearchSessionsCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Matchmaking"; } }

        public string OperationName { get { return "SearchSessions"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("channel")]
        public string? Channel { get; set; }

        [SdkCommandArgument("deleted")]
        public bool? Deleted { get; set; }

        [SdkCommandArgument("matchID")]
        public string? MatchID { get; set; }

        [SdkCommandArgument("partyID")]
        public string? PartyID { get; set; }

        [SdkCommandArgument("userID")]
        public string? UserID { get; set; }

        [SdkCommandArgument("limit")]
        public long Limit { get; set; } = 0;

        [SdkCommandArgument("offset")]
        public long Offset { get; set; } = 0;

        public SearchSessionsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking wrapper = new AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking(_SDK);

#pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Matchmaking.Operation.SearchSessions.Builder;

            if (Channel != null)
                opBuilder.SetChannel((string)Channel);
            if (Deleted != null)
                opBuilder.SetDeleted((bool)Deleted);
            if (MatchID != null)
                opBuilder.SetMatchID((string)MatchID);
            if (PartyID != null)
                opBuilder.SetPartyID((string)PartyID);
            if (UserID != null)
                opBuilder.SetUserID((string)UserID);




            SearchSessions operation = opBuilder.Build(
                Namespace,
                Limit,
                Offset
            );

#pragma warning restore ab_deprecated_operation

#pragma warning disable ab_deprecated_operation_wrapper
            var response = wrapper.SearchSessions(operation);
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