// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Chat.Wrapper;
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Api.Chat.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Chat
{
    [SdkConsoleCommand("chat","adminprofanitycreate")]
    public class AdminProfanityCreateCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Chat"; } }

        public string OperationName{ get { return "AdminProfanityCreate"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsDictionaryInsertRequest Body { get; set; } = new ModelsDictionaryInsertRequest();

        public AdminProfanityCreateCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Chat.Wrapper.Profanity wrapper = new AccelByte.Sdk.Api.Chat.Wrapper.Profanity(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Chat.Operation.AdminProfanityCreate.Builder;





            AdminProfanityCreate operation = opBuilder.Build(
                Body,
                Namespace
            );


            var response = wrapper.AdminProfanityCreate(operation);
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