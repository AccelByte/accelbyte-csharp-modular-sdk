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
    [SdkConsoleCommand("legal","updatelocalizedpolicyversion1")]
    public class UpdateLocalizedPolicyVersion1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "UpdateLocalizedPolicyVersion1"; } }

        [SdkCommandArgument("localizedPolicyVersionId")]
        public string LocalizedPolicyVersionId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public UpdateLocalizedPolicyVersionRequest Body { get; set; } = new UpdateLocalizedPolicyVersionRequest();
                
        public UpdateLocalizedPolicyVersion1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersionsWithNamespace wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersionsWithNamespace(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.UpdateLocalizedPolicyVersion1.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Legal.Model.UpdateLocalizedPolicyVersionRequest)Body);



            UpdateLocalizedPolicyVersion1 operation = opBuilder.Build(
                LocalizedPolicyVersionId,
                Namespace
            );

            
            AccelByte.Sdk.Api.Legal.Model.UpdateLocalizedPolicyVersionResponse? response = wrapper.UpdateLocalizedPolicyVersion1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}