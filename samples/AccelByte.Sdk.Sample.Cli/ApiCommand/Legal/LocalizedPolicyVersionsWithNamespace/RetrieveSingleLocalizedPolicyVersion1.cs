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
    [SdkConsoleCommand("legal", "retrievesinglelocalizedpolicyversion1")]
    public class RetrieveSingleLocalizedPolicyVersion1Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Legal"; } }

        public string OperationName { get { return "RetrieveSingleLocalizedPolicyVersion1"; } }

        [SdkCommandArgument("localizedPolicyVersionId")]
        public string LocalizedPolicyVersionId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public RetrieveSingleLocalizedPolicyVersion1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersionsWithNamespace wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersionsWithNamespace(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.RetrieveSingleLocalizedPolicyVersion1.Builder;





            RetrieveSingleLocalizedPolicyVersion1 operation = opBuilder.Build(
                LocalizedPolicyVersionId,
                Namespace
            );


            AccelByte.Sdk.Api.Legal.Model.RetrieveLocalizedPolicyVersionResponse? response = wrapper.RetrieveSingleLocalizedPolicyVersion1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}