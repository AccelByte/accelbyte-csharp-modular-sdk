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

using AccelByte.Sdk.Api.Eventlog.Wrapper;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Eventlog
{
    [SdkConsoleCommand("eventlog","queryeventstreamhandler")]
    public class QueryEventStreamHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "QueryEventStreamHandler"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("endDate")]
        public string? EndDate { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("pageSize")]
        public long? PageSize { get; set; }

        [SdkCommandArgument("startDate")]
        public string? StartDate { get; set; }

        [SdkCommandData("body")]
        public ModelsGenericQueryPayload Body { get; set; } = new ModelsGenericQueryPayload();
                
        public QueryEventStreamHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.EventV2 wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.EventV2(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Eventlog.Operation.QueryEventStreamHandler.Builder;

            if (EndDate != null)
                opBuilder.SetEndDate((string)EndDate);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (PageSize != null)
                opBuilder.SetPageSize((long)PageSize);
            if (StartDate != null)
                opBuilder.SetStartDate((string)StartDate);




            QueryEventStreamHandler operation = opBuilder.Build(
                Body,
                Namespace
            );

            
            AccelByte.Sdk.Api.Eventlog.Model.ModelsEventResponseV2? response = wrapper.QueryEventStreamHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}