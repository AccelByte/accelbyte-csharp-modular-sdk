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
    [SdkConsoleCommand("iam", "requesttargettokenresponsev4")]
    public class RequestTargetTokenResponseV4Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "RequestTargetTokenResponseV4"; } }

        [SdkCommandArgument("additionalData")]
        public string AdditionalData { get; set; } = String.Empty;

        [SdkCommandArgument("code")]
        public string Code { get; set; } = String.Empty;

        public RequestTargetTokenResponseV4Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20V4 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20V4(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.RequestTargetTokenResponseV4.Builder;



            if (AdditionalData != null)
                opBuilder.SetAdditionalData((string)AdditionalData);


            RequestTargetTokenResponseV4 operation = opBuilder.Build(
                Code
            );


            AccelByte.Sdk.Api.Iam.Model.OauthmodelTokenResponseV3? response = wrapper.RequestTargetTokenResponseV4(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}