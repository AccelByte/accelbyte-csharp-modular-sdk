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
    [SdkConsoleCommand("platform", "querycodes")]
    public class QueryCodesCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "QueryCodes"; } }

        [SdkCommandArgument("campaignId")]
        public string CampaignId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("activeOnly")]
        public bool? ActiveOnly { get; set; }

        [SdkCommandArgument("batchName")]
        public string? BatchName { get; set; }

        [SdkCommandArgument("batchNo")]
        public List<int>? BatchNo { get; set; }

        [SdkCommandArgument("code")]
        public string? Code { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("withBatchName")]
        public bool? WithBatchName { get; set; }

        public QueryCodesCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Campaign wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Campaign(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.QueryCodes.Builder;

            if (ActiveOnly != null)
                opBuilder.SetActiveOnly((bool)ActiveOnly);
            if (BatchName != null)
                opBuilder.SetBatchName((string)BatchName);
            if (BatchNo != null)
                opBuilder.SetBatchNo((List<int>)BatchNo);
            if (Code != null)
                opBuilder.SetCode((string)Code);
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (WithBatchName != null)
                opBuilder.SetWithBatchName((bool)WithBatchName);




            QueryCodes operation = opBuilder.Build(
                CampaignId,
                Namespace
            );


            AccelByte.Sdk.Api.Platform.Model.CodeInfoPagingSlicedResult? response = wrapper.QueryCodes(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}