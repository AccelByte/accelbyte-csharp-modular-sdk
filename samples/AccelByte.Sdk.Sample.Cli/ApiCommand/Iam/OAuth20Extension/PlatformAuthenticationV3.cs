// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("iam", "platformauthenticationv3")]
    public class PlatformAuthenticationV3Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "PlatformAuthenticationV3"; } }

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("code")]
        public string? Code { get; set; }

        [SdkCommandArgument("error")]
        public string? Error { get; set; }

        [SdkCommandArgument("openidAssocHandle")]
        public string? OpenidAssocHandle { get; set; }

        [SdkCommandArgument("openidClaimedId")]
        public string? OpenidClaimedId { get; set; }

        [SdkCommandArgument("openidIdentity")]
        public string? OpenidIdentity { get; set; }

        [SdkCommandArgument("openidMode")]
        public string? OpenidMode { get; set; }

        [SdkCommandArgument("openidNs")]
        public string? OpenidNs { get; set; }

        [SdkCommandArgument("openidOpEndpoint")]
        public string? OpenidOpEndpoint { get; set; }

        [SdkCommandArgument("openidResponseNonce")]
        public string? OpenidResponseNonce { get; set; }

        [SdkCommandArgument("openidReturnTo")]
        public string? OpenidReturnTo { get; set; }

        [SdkCommandArgument("openidSig")]
        public string? OpenidSig { get; set; }

        [SdkCommandArgument("openidSigned")]
        public string? OpenidSigned { get; set; }

        [SdkCommandArgument("state")]
        public string State { get; set; } = String.Empty;

        public PlatformAuthenticationV3Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20Extension wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20Extension(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.PlatformAuthenticationV3.Builder;

            if (Code != null)
                opBuilder.SetCode((string)Code);
            if (Error != null)
                opBuilder.SetError((string)Error);
            if (OpenidAssocHandle != null)
                opBuilder.SetOpenidAssocHandle((string)OpenidAssocHandle);
            if (OpenidClaimedId != null)
                opBuilder.SetOpenidClaimedId((string)OpenidClaimedId);
            if (OpenidIdentity != null)
                opBuilder.SetOpenidIdentity((string)OpenidIdentity);
            if (OpenidMode != null)
                opBuilder.SetOpenidMode((string)OpenidMode);
            if (OpenidNs != null)
                opBuilder.SetOpenidNs((string)OpenidNs);
            if (OpenidOpEndpoint != null)
                opBuilder.SetOpenidOpEndpoint((string)OpenidOpEndpoint);
            if (OpenidResponseNonce != null)
                opBuilder.SetOpenidResponseNonce((string)OpenidResponseNonce);
            if (OpenidReturnTo != null)
                opBuilder.SetOpenidReturnTo((string)OpenidReturnTo);
            if (OpenidSig != null)
                opBuilder.SetOpenidSig((string)OpenidSig);
            if (OpenidSigned != null)
                opBuilder.SetOpenidSigned((string)OpenidSigned);




            PlatformAuthenticationV3 operation = opBuilder.Build(
                PlatformId,
                State
            );


            var response = wrapper.PlatformAuthenticationV3(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(response.Data);
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