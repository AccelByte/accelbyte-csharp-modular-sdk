// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Achievement.Wrapper;
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Achievement.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Achievement
{
    [SdkConsoleCommand("achievement", "adminlistglobalachievements")]
    public class AdminListGlobalAchievementsCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Achievement"; } }

        public string OperationName { get { return "AdminListGlobalAchievements"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("achievementCodes")]
        public string? AchievementCodes { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        [SdkCommandArgument("tags")]
        public List<string>? Tags { get; set; }

        public AdminListGlobalAchievementsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Achievement.Wrapper.GlobalAchievements wrapper = new AccelByte.Sdk.Api.Achievement.Wrapper.GlobalAchievements(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Achievement.Operation.AdminListGlobalAchievements.Builder;

            if (AchievementCodes != null)
                opBuilder.SetAchievementCodes((string)AchievementCodes);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (SortBy != null)
                opBuilder.SetSortBy(AdminListGlobalAchievementsSortBy.NewValue(SortBy));
            if (Status != null)
                opBuilder.SetStatus((string)Status);
            if (Tags != null)
                opBuilder.SetTags((List<string>)Tags);




            AdminListGlobalAchievements operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.AdminListGlobalAchievements(operation);
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