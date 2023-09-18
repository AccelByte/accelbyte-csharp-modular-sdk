// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Seasonpass.Wrapper;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Seasonpass
{
    [SdkConsoleCommand("seasonpass","grantuserpass")]
    public class GrantUserPassCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Seasonpass"; } }

        public string OperationName{ get { return "GrantUserPass"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public UserPassGrant Body { get; set; } = new UserPassGrant();

        public GrantUserPassCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Seasonpass.Wrapper.Pass wrapper = new AccelByte.Sdk.Api.Seasonpass.Wrapper.Pass(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Seasonpass.Operation.GrantUserPass.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Seasonpass.Model.UserPassGrant)Body);



            GrantUserPass operation = opBuilder.Build(
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Seasonpass.Model.UserSeasonSummary? response = wrapper.GrantUserPass(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}