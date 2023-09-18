// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("legal", "updatepolicyversion1")]
    public class UpdatePolicyVersion1Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Legal"; } }

        public string OperationName { get { return "UpdatePolicyVersion1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("policyVersionId")]
        public string PolicyVersionId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public UpdatePolicyVersionRequest Body { get; set; } = new UpdatePolicyVersionRequest();

        public UpdatePolicyVersion1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.PolicyVersionsWithNamespace wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.PolicyVersionsWithNamespace(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.UpdatePolicyVersion1.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Legal.Model.UpdatePolicyVersionRequest)Body);



            UpdatePolicyVersion1 operation = opBuilder.Build(
                Namespace,
                PolicyVersionId
            );


            AccelByte.Sdk.Api.Legal.Model.UpdatePolicyVersionResponse? response = wrapper.UpdatePolicyVersion1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}