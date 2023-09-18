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
    [SdkConsoleCommand("seasonpass", "bulkgetuserseasonprogression")]
    public class BulkGetUserSeasonProgressionCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Seasonpass"; } }

        public string OperationName { get { return "BulkGetUserSeasonProgression"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public BulkUserProgressionRequest Body { get; set; } = new BulkUserProgressionRequest();

        public BulkGetUserSeasonProgressionCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Seasonpass.Wrapper.Season wrapper = new AccelByte.Sdk.Api.Seasonpass.Wrapper.Season(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Seasonpass.Operation.BulkGetUserSeasonProgression.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Seasonpass.Model.BulkUserProgressionRequest)Body);



            BulkGetUserSeasonProgression operation = opBuilder.Build(
                Namespace
            );


            List<AccelByte.Sdk.Api.Seasonpass.Model.UserSeasonSummary>? response = wrapper.BulkGetUserSeasonProgression(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}