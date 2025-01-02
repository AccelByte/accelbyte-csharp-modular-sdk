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
    [SdkConsoleCommand("legal", "updatepolicy1")]
    public class UpdatePolicy1Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Legal"; } }

        public string OperationName { get { return "UpdatePolicy1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("policyId")]
        public string PolicyId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public UpdatePolicyRequest Body { get; set; } = new UpdatePolicyRequest();

        public UpdatePolicy1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.PoliciesWithNamespace wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.PoliciesWithNamespace(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.UpdatePolicy1.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Legal.Model.UpdatePolicyRequest)Body);



            UpdatePolicy1 operation = opBuilder.Build(
                Namespace,
                PolicyId
            );


            var response = wrapper.UpdatePolicy1(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}