// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("sessionhistory", "adminquerygamesessiondetail")]
    public class AdminQueryGameSessionDetailCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Sessionhistory"; } }

        public string OperationName { get { return "AdminQueryGameSessionDetail"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("completedOnly")]
        public string? CompletedOnly { get; set; }

        [SdkCommandArgument("configurationName")]
        public string? ConfigurationName { get; set; }

        [SdkCommandArgument("dsPodName")]
        public string? DsPodName { get; set; }

        [SdkCommandArgument("endDate")]
        public string? EndDate { get; set; }

        [SdkCommandArgument("gameSessionID")]
        public string? GameSessionID { get; set; }

        [SdkCommandArgument("isPersistent")]
        public string? IsPersistent { get; set; }

        [SdkCommandArgument("joinability")]
        public string? Joinability { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("matchPool")]
        public string? MatchPool { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("order")]
        public string? Order { get; set; }

        [SdkCommandArgument("orderBy")]
        public string? OrderBy { get; set; }

        [SdkCommandArgument("startDate")]
        public string? StartDate { get; set; }

        [SdkCommandArgument("statusV2")]
        public string? StatusV2 { get; set; }

        [SdkCommandArgument("userID")]
        public string? UserID { get; set; }

        public AdminQueryGameSessionDetailCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Sessionhistory.Wrapper.GameSessionDetail wrapper = new AccelByte.Sdk.Api.Sessionhistory.Wrapper.GameSessionDetail(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Sessionhistory.Operation.AdminQueryGameSessionDetail.Builder;

            if (CompletedOnly != null)
                opBuilder.SetCompletedOnly((string)CompletedOnly);
            if (ConfigurationName != null)
                opBuilder.SetConfigurationName((string)ConfigurationName);
            if (DsPodName != null)
                opBuilder.SetDsPodName((string)DsPodName);
            if (EndDate != null)
                opBuilder.SetEndDate((string)EndDate);
            if (GameSessionID != null)
                opBuilder.SetGameSessionID((string)GameSessionID);
            if (IsPersistent != null)
                opBuilder.SetIsPersistent((string)IsPersistent);
            if (Joinability != null)
                opBuilder.SetJoinability((string)Joinability);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (MatchPool != null)
                opBuilder.SetMatchPool((string)MatchPool);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (Order != null)
                opBuilder.SetOrder((string)Order);
            if (OrderBy != null)
                opBuilder.SetOrderBy((string)OrderBy);
            if (StartDate != null)
                opBuilder.SetStartDate((string)StartDate);
            if (StatusV2 != null)
                opBuilder.SetStatusV2((string)StatusV2);
            if (UserID != null)
                opBuilder.SetUserID((string)UserID);




            AdminQueryGameSessionDetail operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.AdminQueryGameSessionDetail(operation);
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