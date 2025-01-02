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
    [SdkConsoleCommand("legal", "initiateexportagreementstocsv")]
    public class InitiateExportAgreementsToCSVCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Legal"; } }

        public string OperationName { get { return "InitiateExportAgreementsToCSV"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("end")]
        public string? End { get; set; }

        [SdkCommandArgument("policyVersionId")]
        public string PolicyVersionId { get; set; } = String.Empty;

        [SdkCommandArgument("start")]
        public string Start { get; set; } = String.Empty;

        public InitiateExportAgreementsToCSVCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.AgreementWithNamespace wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.AgreementWithNamespace(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.InitiateExportAgreementsToCSV.Builder;

            if (End != null)
                opBuilder.SetEnd((string)End);




            InitiateExportAgreementsToCSV operation = opBuilder.Build(
                Namespace,
                PolicyVersionId,
                Start
            );


            var response = wrapper.InitiateExportAgreementsToCSV(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-", "response data is null.");
            }
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}