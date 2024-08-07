// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Cloudsave.Wrapper;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Cloudsave
{
    [SdkConsoleCommand("cloudsave", "listgamerecordshandlerv1")]
    public class ListGameRecordsHandlerV1Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Cloudsave"; } }

        public string OperationName { get { return "ListGameRecordsHandlerV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("query")]
        public string? Query { get; set; }

        [SdkCommandArgument("tags")]
        public List<string>? Tags { get; set; }

        [SdkCommandArgument("limit")]
        public long Limit { get; set; } = 0;

        [SdkCommandArgument("offset")]
        public long Offset { get; set; } = 0;

        public ListGameRecordsHandlerV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminGameRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminGameRecord(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Cloudsave.Operation.ListGameRecordsHandlerV1.Builder;

            if (Query != null)
                opBuilder.SetQuery((string)Query);
            if (Tags != null)
                opBuilder.SetTags((List<string>)Tags);




            ListGameRecordsHandlerV1 operation = opBuilder.Build(
                Namespace,
                Limit,
                Offset
            );


            AccelByte.Sdk.Api.Cloudsave.Model.ModelsListGameRecordKeysResponse? response = wrapper.ListGameRecordsHandlerV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}