// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Legal
{
    [SdkConsoleCommand("legal", "retrievealllegalpolicies")]
    public class RetrieveAllLegalPoliciesCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Legal"; } }

        public string OperationName { get { return "RetrieveAllLegalPolicies"; } }

        [SdkCommandArgument("visibleOnly")]
        public bool? VisibleOnly { get; set; }

        public RetrieveAllLegalPoliciesCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.BaseLegalPolicies wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.BaseLegalPolicies(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.RetrieveAllLegalPolicies.Builder;

            if (VisibleOnly != null)
                opBuilder.SetVisibleOnly((bool)VisibleOnly);




            RetrieveAllLegalPolicies operation = opBuilder.Build(
            );


            var response = wrapper.RetrieveAllLegalPolicies(operation);
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