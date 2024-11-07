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
    [SdkConsoleCommand("iam","authorization")]
    public class AuthorizationCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "Authorization"; } }

        [SdkCommandArgument("login")]
        public string Login { get; set; } = String.Empty;

        [SdkCommandArgument("password")]
        public string Password { get; set; } = String.Empty;

        [SdkCommandArgument("scope")]
        public string Scope { get; set; } = String.Empty;

        [SdkCommandArgument("state")]
        public string State { get; set; } = String.Empty;

        [SdkCommandArgument("client_id")]
        public string ClientId { get; set; } = String.Empty;

        [SdkCommandArgument("redirect_uri")]
        public string RedirectUri { get; set; } = String.Empty;

        [SdkCommandArgument("response_type")]
        public string ResponseType { get; set; } = String.Empty;

        public AuthorizationCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth(_SDK);

            #pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.Authorization.Builder;



            if (Login != null)
                opBuilder.SetLogin((string)Login);
            if (Password != null)
                opBuilder.SetPassword((string)Password);
            if (Scope != null)
                opBuilder.SetScope((string)Scope);
            if (State != null)
                opBuilder.SetState((string)State);


            Authorization operation = opBuilder.Build(
                ClientId,
                RedirectUri,
                ResponseType
            );

            #pragma warning restore ab_deprecated_operation

            #pragma warning disable ab_deprecated_operation_wrapper
            var response = wrapper.Authorization(operation);
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
            #pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}