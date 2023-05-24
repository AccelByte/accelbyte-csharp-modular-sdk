// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Social
{
    [SdkConsoleCommand("social","updatenamespaceslotconfig")]
    public class UpdateNamespaceSlotConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "UpdateNamespaceSlotConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public SlotConfigUpdate Body { get; set; } = new SlotConfigUpdate();
                
        public UpdateNamespaceSlotConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.SlotConfig wrapper = new AccelByte.Sdk.Api.Social.Wrapper.SlotConfig(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Social.Operation.UpdateNamespaceSlotConfig.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Social.Model.SlotConfigUpdate)Body);



            UpdateNamespaceSlotConfig operation = opBuilder.Build(
                Namespace
            );

            
            AccelByte.Sdk.Api.Social.Model.NamespaceSlotConfigInfo? response = wrapper.UpdateNamespaceSlotConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}