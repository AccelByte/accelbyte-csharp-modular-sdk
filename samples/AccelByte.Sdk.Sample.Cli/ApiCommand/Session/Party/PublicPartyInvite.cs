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

using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Session
{
    [SdkConsoleCommand("session","publicpartyinvite")]
    public class PublicPartyInviteCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Session"; } }

        public string OperationName{ get { return "PublicPartyInvite"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("partyId")]
        public string PartyId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApimodelsSessionInviteRequest Body { get; set; } = new ApimodelsSessionInviteRequest();
                
        public PublicPartyInviteCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.Party wrapper = new AccelByte.Sdk.Api.Session.Wrapper.Party(_SDK);

            PublicPartyInvite operation = new PublicPartyInvite(
                Namespace,                
                PartyId,                
                Body                
            );            
            
            wrapper.PublicPartyInvite(operation);
            return String.Empty;
        }
    }
}