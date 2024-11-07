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
    [SdkConsoleCommand("iam","requesttokenexchangecodev3")]
    public class RequestTokenExchangeCodeV3Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "RequestTokenExchangeCodeV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("codeChallenge")]
        public string? CodeChallenge { get; set; }

        [SdkCommandArgument("codeChallengeMethod")]
        public string? CodeChallengeMethod { get; set; }

        [SdkCommandArgument("client_id")]
        public string ClientId { get; set; } = String.Empty;

        public RequestTokenExchangeCodeV3Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20Extension wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20Extension(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.RequestTokenExchangeCodeV3.Builder;

            if (CodeChallenge != null)
                opBuilder.SetCodeChallenge((string)CodeChallenge);
            if (CodeChallengeMethod != null)
                opBuilder.SetCodeChallengeMethod(RequestTokenExchangeCodeV3CodeChallengeMethod.NewValue(CodeChallengeMethod));




            RequestTokenExchangeCodeV3 operation = opBuilder.Build(
                ClientId,
                Namespace
            );


            var response = wrapper.RequestTokenExchangeCodeV3(operation);
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
        }
    }
}