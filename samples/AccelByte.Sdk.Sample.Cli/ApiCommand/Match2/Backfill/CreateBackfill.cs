// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Match2.Wrapper;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Match2
{
    [SdkConsoleCommand("match2", "createbackfill")]
    public class CreateBackfillCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Match2"; } }

        public string OperationName { get { return "CreateBackfill"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApiBackFillCreateRequest Body { get; set; } = new ApiBackFillCreateRequest();

        public CreateBackfillCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Match2.Wrapper.Backfill wrapper = new AccelByte.Sdk.Api.Match2.Wrapper.Backfill(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Match2.Operation.CreateBackfill.Builder;





            CreateBackfill operation = opBuilder.Build(
                Body,
                Namespace
            );


            AccelByte.Sdk.Api.Match2.Model.ApiBackfillCreateResponse? response = wrapper.CreateBackfill(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}