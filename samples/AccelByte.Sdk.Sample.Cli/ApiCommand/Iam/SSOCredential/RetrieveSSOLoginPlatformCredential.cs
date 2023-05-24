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

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam","retrievessologinplatformcredential")]
    public class RetrieveSSOLoginPlatformCredentialCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "RetrieveSSOLoginPlatformCredential"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        public RetrieveSSOLoginPlatformCredentialCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.SSOCredential wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.SSOCredential(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.RetrieveSSOLoginPlatformCredential.Builder;





            RetrieveSSOLoginPlatformCredential operation = opBuilder.Build(
                Namespace,
                PlatformId
            );

            
            AccelByte.Sdk.Api.Iam.Model.ModelSSOPlatformCredentialResponse? response = wrapper.RetrieveSSOLoginPlatformCredential(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}