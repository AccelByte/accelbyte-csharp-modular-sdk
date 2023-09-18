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
    [SdkConsoleCommand("cloudsave", "bulkgetmybinaryrecordv1")]
    public class BulkGetMyBinaryRecordV1Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Cloudsave"; } }

        public string OperationName { get { return "BulkGetMyBinaryRecordV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsBulkGetPlayerRecordsRequest Body { get; set; } = new ModelsBulkGetPlayerRecordsRequest();

        public BulkGetMyBinaryRecordV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.PublicPlayerBinaryRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.PublicPlayerBinaryRecord(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Cloudsave.Operation.BulkGetMyBinaryRecordV1.Builder;





            BulkGetMyBinaryRecordV1 operation = opBuilder.Build(
                Body,
                Namespace
            );


            AccelByte.Sdk.Api.Cloudsave.Model.ModelsBulkGetPlayerBinaryRecordResponse? response = wrapper.BulkGetMyBinaryRecordV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}