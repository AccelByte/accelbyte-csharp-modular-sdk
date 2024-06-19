// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Match2.Wrapper;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Match2
{
    [SdkConsoleCommand("match2", "adminpatchupdatelogconfig")]
    public class AdminPatchUpdateLogConfigCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Match2"; } }

        public string OperationName { get { return "AdminPatchUpdateLogConfig"; } }

        [SdkCommandData("body")]
        public LogconfigConfiguration Body { get; set; } = new LogconfigConfiguration();

        public AdminPatchUpdateLogConfigCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Match2.Wrapper.Config wrapper = new AccelByte.Sdk.Api.Match2.Wrapper.Config(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Match2.Operation.AdminPatchUpdateLogConfig.Builder;





            AdminPatchUpdateLogConfig operation = opBuilder.Build(
                Body
            );


            AccelByte.Sdk.Api.Match2.Model.LogconfigConfiguration? response = wrapper.AdminPatchUpdateLogConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}