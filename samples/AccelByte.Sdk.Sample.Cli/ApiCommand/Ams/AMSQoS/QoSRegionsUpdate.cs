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
    [SdkConsoleCommand("ams", "qosregionsupdate")]
    public class QoSRegionsUpdateCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Ams"; } }

        public string OperationName { get { return "QoSRegionsUpdate"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("region")]
        public string Region { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApiUpdateServerRequest Body { get; set; } = new ApiUpdateServerRequest();

        public QoSRegionsUpdateCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Ams.Wrapper.AMSQoS wrapper = new AccelByte.Sdk.Api.Ams.Wrapper.AMSQoS(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ams.Operation.QoSRegionsUpdate.Builder;





            QoSRegionsUpdate operation = opBuilder.Build(
                Body,
                Namespace,
                Region
            );


            var response = wrapper.QoSRegionsUpdate(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}