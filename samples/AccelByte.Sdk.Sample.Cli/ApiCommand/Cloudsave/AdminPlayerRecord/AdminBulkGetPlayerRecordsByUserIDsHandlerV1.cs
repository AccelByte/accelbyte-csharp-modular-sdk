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
    [SdkConsoleCommand("cloudsave", "adminbulkgetplayerrecordsbyuseridshandlerv1")]
    public class AdminBulkGetPlayerRecordsByUserIDsHandlerV1Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Cloudsave"; } }

        public string OperationName { get { return "AdminBulkGetPlayerRecordsByUserIDsHandlerV1"; } }

        [SdkCommandArgument("key")]
        public string Key { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsBulkUserIDsRequest Body { get; set; } = new ModelsBulkUserIDsRequest();

        public AdminBulkGetPlayerRecordsByUserIDsHandlerV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminPlayerRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminPlayerRecord(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Cloudsave.Operation.AdminBulkGetPlayerRecordsByUserIDsHandlerV1.Builder;





            AdminBulkGetPlayerRecordsByUserIDsHandlerV1 operation = opBuilder.Build(
                Body,
                Key,
                Namespace
            );


            AccelByte.Sdk.Api.Cloudsave.Model.ModelsBulkGetPlayerRecordResponse? response = wrapper.AdminBulkGetPlayerRecordsByUserIDsHandlerV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}