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
    [SdkConsoleCommand("legal","changepreferenceconsent")]
    public class ChangePreferenceConsentCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "ChangePreferenceConsent"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public List<AcceptAgreementRequest> Body { get; set; } = new List<AcceptAgreementRequest>();

        public ChangePreferenceConsentCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.Agreement wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.Agreement(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.ChangePreferenceConsent.Builder;


            if (Body != null)
                opBuilder.SetBody((List<AccelByte.Sdk.Api.Legal.Model.AcceptAgreementRequest>)Body);



            ChangePreferenceConsent operation = opBuilder.Build(
                Namespace,
                UserId
            );


            var response = wrapper.ChangePreferenceConsent(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (response.Error != null)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}