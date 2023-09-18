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
    [SdkConsoleCommand("session","publicpromotepartyleader")]
    public class PublicPromotePartyLeaderCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Session"; } }

        public string OperationName{ get { return "PublicPromotePartyLeader"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("partyId")]
        public string PartyId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApimodelsPromoteLeaderRequest Body { get; set; } = new ApimodelsPromoteLeaderRequest();

        public PublicPromotePartyLeaderCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.Party wrapper = new AccelByte.Sdk.Api.Session.Wrapper.Party(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Session.Operation.PublicPromotePartyLeader.Builder;





            PublicPromotePartyLeader operation = opBuilder.Build(
                Body,
                Namespace,
                PartyId
            );


            AccelByte.Sdk.Api.Session.Model.ApimodelsPartySessionResponse? response = wrapper.PublicPromotePartyLeader(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}