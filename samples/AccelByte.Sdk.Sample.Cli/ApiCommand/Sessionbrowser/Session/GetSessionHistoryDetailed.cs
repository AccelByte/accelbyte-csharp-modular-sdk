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

using AccelByte.Sdk.Api.Sessionbrowser.Wrapper;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Api.Sessionbrowser.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Sessionbrowser
{
    [SdkConsoleCommand("sessionbrowser","getsessionhistorydetailed")]
    public class GetSessionHistoryDetailedCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Sessionbrowser"; } }

        public string OperationName{ get { return "GetSessionHistoryDetailed"; } }

        [SdkCommandArgument("matchID")]
        public string MatchID { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetSessionHistoryDetailedCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session wrapper = new AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Sessionbrowser.Operation.GetSessionHistoryDetailed.Builder;





            GetSessionHistoryDetailed operation = opBuilder.Build(
                MatchID,
                Namespace
            );

            
            List<AccelByte.Sdk.Api.Sessionbrowser.Model.ModelsGetSessionHistoryDetailedResponseItem>? response = wrapper.GetSessionHistoryDetailed(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}