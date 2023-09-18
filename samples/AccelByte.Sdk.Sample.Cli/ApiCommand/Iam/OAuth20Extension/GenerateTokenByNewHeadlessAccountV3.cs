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
    [SdkConsoleCommand("iam", "generatetokenbynewheadlessaccountv3")]
    public class GenerateTokenByNewHeadlessAccountV3Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "GenerateTokenByNewHeadlessAccountV3"; } }

        [SdkCommandArgument("additionalData")]
        public string AdditionalData { get; set; } = String.Empty;

        [SdkCommandArgument("extend_exp")]
        public bool ExtendExp { get; set; } = false;

        [SdkCommandArgument("linkingToken")]
        public string LinkingToken { get; set; } = String.Empty;

        public GenerateTokenByNewHeadlessAccountV3Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20Extension wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20Extension(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.GenerateTokenByNewHeadlessAccountV3.Builder;



            if (AdditionalData != null)
                opBuilder.SetAdditionalData((string)AdditionalData);
            if (ExtendExp != null)
                opBuilder.SetExtendExp((bool)ExtendExp);


            GenerateTokenByNewHeadlessAccountV3 operation = opBuilder.Build(
                LinkingToken
            );


            AccelByte.Sdk.Api.Iam.Model.OauthmodelTokenResponseV3? response = wrapper.GenerateTokenByNewHeadlessAccountV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}