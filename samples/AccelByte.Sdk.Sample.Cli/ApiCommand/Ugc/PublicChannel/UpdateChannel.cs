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

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ugc
{
    [SdkConsoleCommand("ugc","updatechannel")]
    public class UpdateChannelCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "UpdateChannel"; } }

        [SdkCommandArgument("channelId")]
        public string ChannelId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUpdateChannelRequest Body { get; set; } = new ModelsUpdateChannelRequest();
                
        public UpdateChannelCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.PublicChannel wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.PublicChannel(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ugc.Operation.UpdateChannel.Builder;





            UpdateChannel operation = opBuilder.Build(
                Body,
                ChannelId,
                Namespace,
                UserId
            );

            
            AccelByte.Sdk.Api.Ugc.Model.ModelsChannelResponse? response = wrapper.UpdateChannel(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}