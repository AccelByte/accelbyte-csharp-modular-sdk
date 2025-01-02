// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ugc
{
    [SdkConsoleCommand("ugc", "admindeletetype")]
    public class AdminDeleteTypeCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Ugc"; } }

        public string OperationName { get { return "AdminDeleteType"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("typeId")]
        public string TypeId { get; set; } = String.Empty;

        public AdminDeleteTypeCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminType wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminType(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ugc.Operation.AdminDeleteType.Builder;





            AdminDeleteType operation = opBuilder.Build(
                Namespace,
                TypeId
            );


            var response = wrapper.AdminDeleteType(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}