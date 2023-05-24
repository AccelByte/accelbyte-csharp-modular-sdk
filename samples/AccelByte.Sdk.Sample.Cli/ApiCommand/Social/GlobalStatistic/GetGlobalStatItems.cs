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
    [SdkConsoleCommand("social","getglobalstatitems")]
    public class GetGlobalStatItemsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "GetGlobalStatItems"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("statCodes")]
        public string? StatCodes { get; set; }

        public GetGlobalStatItemsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.GlobalStatistic wrapper = new AccelByte.Sdk.Api.Social.Wrapper.GlobalStatistic(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Social.Operation.GetGlobalStatItems.Builder;

            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (StatCodes != null)
                opBuilder.SetStatCodes((string)StatCodes);




            GetGlobalStatItems operation = opBuilder.Build(
                Namespace
            );

            
            AccelByte.Sdk.Api.Social.Model.GlobalStatItemPagingSlicedResult? response = wrapper.GetGlobalStatItems(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}