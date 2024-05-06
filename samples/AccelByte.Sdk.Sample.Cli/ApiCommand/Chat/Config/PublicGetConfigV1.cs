// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Chat.Wrapper;
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Api.Chat.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Chat
{
    [SdkConsoleCommand("chat", "publicgetconfigv1")]
    public class PublicGetConfigV1Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Chat"; } }

        public string OperationName { get { return "PublicGetConfigV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public PublicGetConfigV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Chat.Wrapper.Config wrapper = new AccelByte.Sdk.Api.Chat.Wrapper.Config(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Chat.Operation.PublicGetConfigV1.Builder;





            PublicGetConfigV1 operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Chat.Model.ModelsPublicConfigResponse? response = wrapper.PublicGetConfigV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}