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
    [SdkConsoleCommand("legal","retrievesinglelocalizedpolicyversion2")]
    public class RetrieveSingleLocalizedPolicyVersion2Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "RetrieveSingleLocalizedPolicyVersion2"; } }

        [SdkCommandArgument("localizedPolicyVersionId")]
        public string LocalizedPolicyVersionId { get; set; } = String.Empty;

        public RetrieveSingleLocalizedPolicyVersion2Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersions wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersions(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.RetrieveSingleLocalizedPolicyVersion2.Builder;





            RetrieveSingleLocalizedPolicyVersion2 operation = opBuilder.Build(
                LocalizedPolicyVersionId
            );

            
            AccelByte.Sdk.Api.Legal.Model.RetrieveLocalizedPolicyVersionPublicResponse? response = wrapper.RetrieveSingleLocalizedPolicyVersion2(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}