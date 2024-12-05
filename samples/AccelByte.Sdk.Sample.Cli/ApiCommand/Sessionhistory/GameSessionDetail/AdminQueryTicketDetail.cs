// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Sessionhistory.Wrapper;
using AccelByte.Sdk.Api.Sessionhistory.Model;
using AccelByte.Sdk.Api.Sessionhistory.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Sessionhistory
{
    [SdkConsoleCommand("sessionhistory", "adminqueryticketdetail")]
    public class AdminQueryTicketDetailCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Sessionhistory"; } }

        public string OperationName { get { return "AdminQueryTicketDetail"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("endDate")]
        public string? EndDate { get; set; }

        [SdkCommandArgument("gameMode")]
        public string? GameMode { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("order")]
        public string? Order { get; set; }

        [SdkCommandArgument("partyID")]
        public string? PartyID { get; set; }

        [SdkCommandArgument("region")]
        public string? Region { get; set; }

        [SdkCommandArgument("startDate")]
        public string? StartDate { get; set; }

        [SdkCommandArgument("userIDs")]
        public string? UserIDs { get; set; }

        public AdminQueryTicketDetailCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Sessionhistory.Wrapper.GameSessionDetail wrapper = new AccelByte.Sdk.Api.Sessionhistory.Wrapper.GameSessionDetail(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Sessionhistory.Operation.AdminQueryTicketDetail.Builder;

            if (EndDate != null)
                opBuilder.SetEndDate((string)EndDate);
            if (GameMode != null)
                opBuilder.SetGameMode((string)GameMode);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (Order != null)
                opBuilder.SetOrder((string)Order);
            if (PartyID != null)
                opBuilder.SetPartyID((string)PartyID);
            if (Region != null)
                opBuilder.SetRegion((string)Region);
            if (StartDate != null)
                opBuilder.SetStartDate((string)StartDate);
            if (UserIDs != null)
                opBuilder.SetUserIDs((string)UserIDs);




            AdminQueryTicketDetail operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.AdminQueryTicketDetail(operation);
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
        }
    }
}