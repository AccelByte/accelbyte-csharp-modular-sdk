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
    [SdkConsoleCommand("platform","updatesectionpluginconfig")]
    public class UpdateSectionPluginConfigCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "UpdateSectionPluginConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public SectionPluginConfigUpdate Body { get; set; } = new SectionPluginConfigUpdate();

        public UpdateSectionPluginConfigCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.ServicePluginConfig wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.ServicePluginConfig(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.UpdateSectionPluginConfig.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Platform.Model.SectionPluginConfigUpdate)Body);



            UpdateSectionPluginConfig operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Platform.Model.SectionPluginConfigInfo? response = wrapper.UpdateSectionPluginConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}