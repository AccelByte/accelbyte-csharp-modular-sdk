// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Ams.Wrapper;
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Api.Ams.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ams
{
    [SdkConsoleCommand("ams", "fleetserverinfo")]
    public class FleetServerInfoCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Ams"; } }

        public string OperationName { get { return "FleetServerInfo"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("serverID")]
        public string ServerID { get; set; } = String.Empty;

        public FleetServerInfoCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ams.Wrapper.Servers wrapper = new AccelByte.Sdk.Api.Ams.Wrapper.Servers(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ams.Operation.FleetServerInfo.Builder;





            FleetServerInfo operation = opBuilder.Build(
                Namespace,
                ServerID
            );


            AccelByte.Sdk.Api.Ams.Model.ApiFleetServerInfoResponse? response = wrapper.FleetServerInfo(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}