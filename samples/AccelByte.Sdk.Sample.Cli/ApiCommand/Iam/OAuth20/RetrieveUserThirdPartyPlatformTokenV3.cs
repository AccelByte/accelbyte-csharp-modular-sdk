// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam", "retrieveuserthirdpartyplatformtokenv3")]
    public class RetrieveUserThirdPartyPlatformTokenV3Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "RetrieveUserThirdPartyPlatformTokenV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public RetrieveUserThirdPartyPlatformTokenV3Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.RetrieveUserThirdPartyPlatformTokenV3.Builder;





            RetrieveUserThirdPartyPlatformTokenV3 operation = opBuilder.Build(
                Namespace,
                PlatformId,
                UserId
            );


            AccelByte.Sdk.Api.Iam.Model.OauthmodelTokenThirdPartyResponse? response = wrapper.RetrieveUserThirdPartyPlatformTokenV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}