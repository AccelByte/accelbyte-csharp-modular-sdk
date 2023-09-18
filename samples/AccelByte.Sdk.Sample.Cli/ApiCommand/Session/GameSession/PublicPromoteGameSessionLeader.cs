// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Session
{
    [SdkConsoleCommand("session","publicpromotegamesessionleader")]
    public class PublicPromoteGameSessionLeaderCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Session"; } }

        public string OperationName{ get { return "PublicPromoteGameSessionLeader"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("sessionId")]
        public string SessionId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApimodelsPromoteLeaderRequest Body { get; set; } = new ApimodelsPromoteLeaderRequest();

        public PublicPromoteGameSessionLeaderCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.GameSession wrapper = new AccelByte.Sdk.Api.Session.Wrapper.GameSession(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Session.Operation.PublicPromoteGameSessionLeader.Builder;





            PublicPromoteGameSessionLeader operation = opBuilder.Build(
                Body,
                Namespace,
                SessionId
            );


            AccelByte.Sdk.Api.Session.Model.ApimodelsGameSessionResponse? response = wrapper.PublicPromoteGameSessionLeader(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}