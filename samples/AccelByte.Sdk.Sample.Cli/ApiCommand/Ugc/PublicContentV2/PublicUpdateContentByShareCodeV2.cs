// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ugc
{
    [SdkConsoleCommand("ugc", "publicupdatecontentbysharecodev2")]
    public class PublicUpdateContentByShareCodeV2Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Ugc"; } }

        public string OperationName { get { return "PublicUpdateContentByShareCodeV2"; } }

        [SdkCommandArgument("channelId")]
        public string ChannelId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("shareCode")]
        public string ShareCode { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUpdateContentRequestV2 Body { get; set; } = new ModelsUpdateContentRequestV2();

        public PublicUpdateContentByShareCodeV2Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.PublicContentV2 wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.PublicContentV2(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ugc.Operation.PublicUpdateContentByShareCodeV2.Builder;





            PublicUpdateContentByShareCodeV2 operation = opBuilder.Build(
                Body,
                ChannelId,
                Namespace,
                ShareCode,
                UserId
            );


            AccelByte.Sdk.Api.Ugc.Model.ModelsCreateContentResponseV2? response = wrapper.PublicUpdateContentByShareCodeV2(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}