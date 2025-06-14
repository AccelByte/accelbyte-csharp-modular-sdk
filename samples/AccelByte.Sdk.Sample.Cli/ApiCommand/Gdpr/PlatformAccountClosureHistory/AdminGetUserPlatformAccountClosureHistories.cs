// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Gdpr.Wrapper;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Gdpr
{
    [SdkConsoleCommand("gdpr","admingetuserplatformaccountclosurehistories")]
    public class AdminGetUserPlatformAccountClosureHistoriesCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Gdpr"; } }

        public string OperationName{ get { return "AdminGetUserPlatformAccountClosureHistories"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("platform")]
        public string? Platform { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public AdminGetUserPlatformAccountClosureHistoriesCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Gdpr.Wrapper.PlatformAccountClosureHistory wrapper = new AccelByte.Sdk.Api.Gdpr.Wrapper.PlatformAccountClosureHistory(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Gdpr.Operation.AdminGetUserPlatformAccountClosureHistories.Builder;

            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (Platform != null)
                opBuilder.SetPlatform((string)Platform);
            if (UserId != null)
                opBuilder.SetUserId((string)UserId);




            AdminGetUserPlatformAccountClosureHistories operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.AdminGetUserPlatformAccountClosureHistories(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}