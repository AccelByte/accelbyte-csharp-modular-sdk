// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Social
{
    [SdkConsoleCommand("social","bulkgetstatcycle1")]
    public class BulkGetStatCycle1Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "BulkGetStatCycle1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public BulkStatCycleRequest Body { get; set; } = new BulkStatCycleRequest();

        public BulkGetStatCycle1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.StatCycleConfiguration wrapper = new AccelByte.Sdk.Api.Social.Wrapper.StatCycleConfiguration(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Social.Operation.BulkGetStatCycle1.Builder;





            BulkGetStatCycle1 operation = opBuilder.Build(
                Body,
                Namespace
            );


            var response = wrapper.BulkGetStatCycle1(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}