// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","querycampaigns")]
    public class QueryCampaignsCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QueryCampaigns"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("name")]
        public string? Name { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("tag")]
        public string? Tag { get; set; }

        public QueryCampaignsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Campaign wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Campaign(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.QueryCampaigns.Builder;

            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Name != null)
                opBuilder.SetName((string)Name);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (Tag != null)
                opBuilder.SetTag((string)Tag);




            QueryCampaigns operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Platform.Model.CampaignPagingSlicedResult? response = wrapper.QueryCampaigns(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}