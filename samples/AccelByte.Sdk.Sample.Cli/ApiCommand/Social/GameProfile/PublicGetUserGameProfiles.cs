// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Social
{
    [SdkConsoleCommand("social", "publicgetusergameprofiles")]
    public class PublicGetUserGameProfilesCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Social"; } }

        public string OperationName { get { return "PublicGetUserGameProfiles"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userIds")]
        public List<string> UserIds { get; set; } = new List<string>();

        public PublicGetUserGameProfilesCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.GameProfile wrapper = new AccelByte.Sdk.Api.Social.Wrapper.GameProfile(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Social.Operation.PublicGetUserGameProfiles.Builder;





            PublicGetUserGameProfiles operation = opBuilder.Build(
                Namespace,
                UserIds
            );


            var response = wrapper.PublicGetUserGameProfiles(operation);
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