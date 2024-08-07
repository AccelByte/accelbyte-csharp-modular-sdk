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
    [SdkConsoleCommand("cloudsave", "listmybinaryrecordsv1")]
    public class ListMyBinaryRecordsV1Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Cloudsave"; } }

        public string OperationName { get { return "ListMyBinaryRecordsV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("query")]
        public string? Query { get; set; }

        [SdkCommandArgument("tags")]
        public List<string>? Tags { get; set; }

        public ListMyBinaryRecordsV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.PublicPlayerBinaryRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.PublicPlayerBinaryRecord(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Cloudsave.Operation.ListMyBinaryRecordsV1.Builder;

            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (Query != null)
                opBuilder.SetQuery((string)Query);
            if (Tags != null)
                opBuilder.SetTags((List<string>)Tags);




            ListMyBinaryRecordsV1 operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Cloudsave.Model.ModelsListPlayerBinaryRecordsResponse? response = wrapper.ListMyBinaryRecordsV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}