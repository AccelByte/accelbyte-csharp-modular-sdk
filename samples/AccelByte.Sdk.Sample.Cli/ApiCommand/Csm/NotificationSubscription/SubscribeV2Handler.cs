// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Csm.Wrapper;
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Api.Csm.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Csm
{
    [SdkConsoleCommand("csm", "subscribev2handler")]
    public class SubscribeV2HandlerCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Csm"; } }

        public string OperationName { get { return "SubscribeV2Handler"; } }

        [SdkCommandArgument("app")]
        public string App { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApimodelSelfSubscribeNotificationRequest Body { get; set; } = new ApimodelSelfSubscribeNotificationRequest();

        public SubscribeV2HandlerCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Csm.Wrapper.NotificationSubscription wrapper = new AccelByte.Sdk.Api.Csm.Wrapper.NotificationSubscription(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Csm.Operation.SubscribeV2Handler.Builder;





            SubscribeV2Handler operation = opBuilder.Build(
                Body,
                App,
                Namespace
            );


            var response = wrapper.SubscribeV2Handler(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}