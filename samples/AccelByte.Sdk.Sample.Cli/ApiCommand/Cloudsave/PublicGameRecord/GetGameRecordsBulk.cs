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
    [SdkConsoleCommand("cloudsave", "getgamerecordsbulk")]
    public class GetGameRecordsBulkCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Cloudsave"; } }

        public string OperationName { get { return "GetGameRecordsBulk"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsBulkGetGameRecordRequest Body { get; set; } = new ModelsBulkGetGameRecordRequest();

        public GetGameRecordsBulkCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.PublicGameRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.PublicGameRecord(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Cloudsave.Operation.GetGameRecordsBulk.Builder;





            GetGameRecordsBulk operation = opBuilder.Build(
                Body,
                Namespace
            );


            AccelByte.Sdk.Api.Cloudsave.Model.ModelsBulkGetGameRecordResponse? response = wrapper.GetGameRecordsBulk(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}