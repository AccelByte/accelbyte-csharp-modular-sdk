// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("legal", "anonymizeuseragreement")]
    public class AnonymizeUserAgreementCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Legal"; } }

        public string OperationName { get { return "AnonymizeUserAgreement"; } }

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public AnonymizeUserAgreementCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.Anonymization wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.Anonymization(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.AnonymizeUserAgreement.Builder;





            AnonymizeUserAgreement operation = opBuilder.Build(
                UserId
            );


            var response = wrapper.AnonymizeUserAgreement(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}