// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam","admingetdevicesbyuserv4")]
    public class AdminGetDevicesByUserV4Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminGetDevicesByUserV4"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public AdminGetDevicesByUserV4Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.DevicesV4 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.DevicesV4(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AdminGetDevicesByUserV4.Builder;

            if (UserId != null)
                opBuilder.SetUserId((string)UserId);




            AdminGetDevicesByUserV4 operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.AdminGetDevicesByUserV4(operation);
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