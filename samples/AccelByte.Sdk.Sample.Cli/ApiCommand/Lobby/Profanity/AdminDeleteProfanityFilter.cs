// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Lobby
{
    [SdkConsoleCommand("lobby","admindeleteprofanityfilter")]
    public class AdminDeleteProfanityFilterCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "AdminDeleteProfanityFilter"; } }

        [SdkCommandArgument("list")]
        public string List { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsAdminDeleteProfanityFilterRequest Body { get; set; } = new ModelsAdminDeleteProfanityFilterRequest();

        public AdminDeleteProfanityFilterCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Profanity wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Profanity(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Lobby.Operation.AdminDeleteProfanityFilter.Builder;





            AdminDeleteProfanityFilter operation = opBuilder.Build(
                Body,
                List,
                Namespace
            );


            var response = wrapper.AdminDeleteProfanityFilter(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (response.Error != null)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}