// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Legal
{
    [SdkConsoleCommand("legal","retrievesinglepolicyversion1")]
    public class RetrieveSinglePolicyVersion1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "RetrieveSinglePolicyVersion1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("policyId")]
        public string PolicyId { get; set; } = String.Empty;

        [SdkCommandArgument("versionId")]
        public string? VersionId { get; set; }

        public RetrieveSinglePolicyVersion1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.PolicyVersionsWithNamespace wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.PolicyVersionsWithNamespace(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.RetrieveSinglePolicyVersion1.Builder;

            if (VersionId != null)
                opBuilder.SetVersionId((string)VersionId);




            RetrieveSinglePolicyVersion1 operation = opBuilder.Build(
                Namespace,
                PolicyId
            );

            
            List<AccelByte.Sdk.Api.Legal.Model.RetrievePolicyVersionResponse>? response = wrapper.RetrieveSinglePolicyVersion1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}