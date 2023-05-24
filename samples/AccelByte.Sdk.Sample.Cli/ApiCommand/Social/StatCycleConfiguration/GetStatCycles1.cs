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
    [SdkConsoleCommand("social","getstatcycles1")]
    public class GetStatCycles1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "GetStatCycles1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("cycleType")]
        public string? CycleType { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("name")]
        public string? Name { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        public GetStatCycles1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.StatCycleConfiguration wrapper = new AccelByte.Sdk.Api.Social.Wrapper.StatCycleConfiguration(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Social.Operation.GetStatCycles1.Builder;

            if (CycleType != null)
                opBuilder.SetCycleType(GetStatCycles1CycleType.NewValue(CycleType));
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Name != null)
                opBuilder.SetName((string)Name);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (SortBy != null)
                opBuilder.SetSortBy((string)SortBy);
            if (Status != null)
                opBuilder.SetStatus(GetStatCycles1Status.NewValue(Status));




            GetStatCycles1 operation = opBuilder.Build(
                Namespace
            );

            
            AccelByte.Sdk.Api.Social.Model.StatCyclePagingSlicedResult? response = wrapper.GetStatCycles1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}