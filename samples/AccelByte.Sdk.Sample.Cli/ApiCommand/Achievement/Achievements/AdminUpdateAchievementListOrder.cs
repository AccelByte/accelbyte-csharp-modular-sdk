// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("achievement","adminupdateachievementlistorder")]
    public class AdminUpdateAchievementListOrderCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Achievement"; } }

        public string OperationName{ get { return "AdminUpdateAchievementListOrder"; } }

        [SdkCommandArgument("achievementCode")]
        public string AchievementCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsAchievementOrderUpdateRequest Body { get; set; } = new ModelsAchievementOrderUpdateRequest();

        public AdminUpdateAchievementListOrderCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Achievement.Wrapper.Achievements wrapper = new AccelByte.Sdk.Api.Achievement.Wrapper.Achievements(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Achievement.Operation.AdminUpdateAchievementListOrder.Builder;





            AdminUpdateAchievementListOrder operation = opBuilder.Build(
                Body,
                AchievementCode,
                Namespace
            );


            var response = wrapper.AdminUpdateAchievementListOrder(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}