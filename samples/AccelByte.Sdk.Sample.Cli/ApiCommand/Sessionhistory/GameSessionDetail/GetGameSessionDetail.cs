// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Sessionhistory.Wrapper;
using AccelByte.Sdk.Api.Sessionhistory.Model;
using AccelByte.Sdk.Api.Sessionhistory.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Sessionhistory
{
    [SdkConsoleCommand("sessionhistory", "getgamesessiondetail")]
    public class GetGameSessionDetailCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Sessionhistory"; } }

        public string OperationName { get { return "GetGameSessionDetail"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("sessionId")]
        public string SessionId { get; set; } = String.Empty;

        public GetGameSessionDetailCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Sessionhistory.Wrapper.GameSessionDetail wrapper = new AccelByte.Sdk.Api.Sessionhistory.Wrapper.GameSessionDetail(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Sessionhistory.Operation.GetGameSessionDetail.Builder;





            GetGameSessionDetail operation = opBuilder.Build(
                Namespace,
                SessionId
            );


            var response = wrapper.GetGameSessionDetail(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-", "response data is null.");
            }
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}