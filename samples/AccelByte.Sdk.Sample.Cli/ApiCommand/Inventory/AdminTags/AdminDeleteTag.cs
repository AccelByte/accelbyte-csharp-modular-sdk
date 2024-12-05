// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Inventory.Wrapper;
using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Api.Inventory.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Inventory
{
    [SdkConsoleCommand("inventory", "admindeletetag")]
    public class AdminDeleteTagCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Inventory"; } }

        public string OperationName { get { return "AdminDeleteTag"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("tagName")]
        public string TagName { get; set; } = String.Empty;

        public AdminDeleteTagCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Inventory.Wrapper.AdminTags wrapper = new AccelByte.Sdk.Api.Inventory.Wrapper.AdminTags(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Inventory.Operation.AdminDeleteTag.Builder;





            AdminDeleteTag operation = opBuilder.Build(
                Namespace,
                TagName
            );


            var response = wrapper.AdminDeleteTag(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}