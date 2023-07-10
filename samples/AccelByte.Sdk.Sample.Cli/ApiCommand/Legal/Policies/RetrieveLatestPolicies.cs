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
    [SdkConsoleCommand("legal","retrievelatestpolicies")]
    public class RetrieveLatestPoliciesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "RetrieveLatestPolicies"; } }

        [SdkCommandArgument("countryCode")]
        public string CountryCode { get; set; } = String.Empty;

        [SdkCommandArgument("defaultOnEmpty")]
        public bool? DefaultOnEmpty { get; set; }

        [SdkCommandArgument("policyType")]
        public string? PolicyType { get; set; }

        [SdkCommandArgument("tags")]
        public string? Tags { get; set; }

        public RetrieveLatestPoliciesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.Policies wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.Policies(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.RetrieveLatestPolicies.Builder;

            if (DefaultOnEmpty != null)
                opBuilder.SetDefaultOnEmpty((bool)DefaultOnEmpty);
            if (PolicyType != null)
                opBuilder.SetPolicyType(RetrieveLatestPoliciesPolicyType.NewValue(PolicyType));
            if (Tags != null)
                opBuilder.SetTags((string)Tags);




            RetrieveLatestPolicies operation = opBuilder.Build(
                CountryCode
            );

            
            List<AccelByte.Sdk.Api.Legal.Model.RetrievePolicyPublicResponse>? response = wrapper.RetrieveLatestPolicies(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}