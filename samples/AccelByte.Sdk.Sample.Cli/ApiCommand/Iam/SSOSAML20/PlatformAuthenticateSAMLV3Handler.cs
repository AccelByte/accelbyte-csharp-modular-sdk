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
    [SdkConsoleCommand("iam","platformauthenticatesamlv3handler")]
    public class PlatformAuthenticateSAMLV3HandlerCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "PlatformAuthenticateSAMLV3Handler"; } }

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("code")]
        public string? Code { get; set; }

        [SdkCommandArgument("error")]
        public string? Error { get; set; }

        [SdkCommandArgument("state")]
        public string State { get; set; } = String.Empty;

        public PlatformAuthenticateSAMLV3HandlerCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.SSOSAML20 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.SSOSAML20(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.PlatformAuthenticateSAMLV3Handler.Builder;

            if (Code != null)
                opBuilder.SetCode((string)Code);
            if (Error != null)
                opBuilder.SetError((string)Error);




            PlatformAuthenticateSAMLV3Handler operation = opBuilder.Build(
                PlatformId,
                State
            );


            var response = wrapper.PlatformAuthenticateSAMLV3Handler(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(response.Data);
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}