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
    [SdkConsoleCommand("legal", "publishpolicyversion1")]
    public class PublishPolicyVersion1Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Legal"; } }

        public string OperationName { get { return "PublishPolicyVersion1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("policyVersionId")]
        public string PolicyVersionId { get; set; } = String.Empty;

        [SdkCommandArgument("shouldNotify")]
        public bool? ShouldNotify { get; set; }

        public PublishPolicyVersion1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.PolicyVersionsWithNamespace wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.PolicyVersionsWithNamespace(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.PublishPolicyVersion1.Builder;

            if (ShouldNotify != null)
                opBuilder.SetShouldNotify((bool)ShouldNotify);




            PublishPolicyVersion1 operation = opBuilder.Build(
                Namespace,
                PolicyVersionId
            );


            wrapper.PublishPolicyVersion1(operation);
            return String.Empty;
        }
    }
}