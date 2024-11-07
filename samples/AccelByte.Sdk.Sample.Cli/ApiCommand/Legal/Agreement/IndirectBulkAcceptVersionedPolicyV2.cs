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
    [SdkConsoleCommand("legal","indirectbulkacceptversionedpolicyv2")]
    public class IndirectBulkAcceptVersionedPolicyV2Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "IndirectBulkAcceptVersionedPolicyV2"; } }

        [SdkCommandArgument("clientId")]
        public string ClientId { get; set; } = String.Empty;

        [SdkCommandArgument("countryCode")]
        public string CountryCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public List<AcceptAgreementRequest> Body { get; set; } = new List<AcceptAgreementRequest>();

        public IndirectBulkAcceptVersionedPolicyV2Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.Agreement wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.Agreement(_SDK);

            #pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.IndirectBulkAcceptVersionedPolicyV2.Builder;


            if (Body != null)
                opBuilder.SetBody((List<AccelByte.Sdk.Api.Legal.Model.AcceptAgreementRequest>)Body);



            IndirectBulkAcceptVersionedPolicyV2 operation = opBuilder.Build(
                ClientId,
                CountryCode,
                Namespace,
                UserId
            );

            #pragma warning restore ab_deprecated_operation

            #pragma warning disable ab_deprecated_operation_wrapper
            var response = wrapper.IndirectBulkAcceptVersionedPolicyV2(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
            #pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}