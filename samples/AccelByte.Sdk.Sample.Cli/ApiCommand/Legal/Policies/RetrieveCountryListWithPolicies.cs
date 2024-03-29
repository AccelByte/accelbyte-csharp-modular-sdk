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
    [SdkConsoleCommand("legal", "retrievecountrylistwithpolicies")]
    public class RetrieveCountryListWithPoliciesCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Legal"; } }

        public string OperationName { get { return "RetrieveCountryListWithPolicies"; } }

        public RetrieveCountryListWithPoliciesCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.Policies wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.Policies(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.RetrieveCountryListWithPolicies.Builder;





            RetrieveCountryListWithPolicies operation = opBuilder.Build(
            );


            List<string>? response = wrapper.RetrieveCountryListWithPolicies(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}