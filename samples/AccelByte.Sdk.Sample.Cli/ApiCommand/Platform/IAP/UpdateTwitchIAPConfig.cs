// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform", "updatetwitchiapconfig")]
    public class UpdateTwitchIAPConfigCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "UpdateTwitchIAPConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public TwitchIAPConfigRequest Body { get; set; } = new TwitchIAPConfigRequest();

        public UpdateTwitchIAPConfigCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.IAP wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.IAP(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.UpdateTwitchIAPConfig.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Platform.Model.TwitchIAPConfigRequest)Body);



            UpdateTwitchIAPConfig operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Platform.Model.TwitchIAPConfigInfo? response = wrapper.UpdateTwitchIAPConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}