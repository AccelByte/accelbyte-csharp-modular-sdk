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
    [SdkConsoleCommand("iam","tokengrant")]
    public class TokenGrantCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "TokenGrant"; } }

        [SdkCommandArgument("code")]
        public string Code { get; set; } = String.Empty;

        [SdkCommandArgument("extend_exp")]
        public bool ExtendExp { get; set; } = false;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("password")]
        public string Password { get; set; } = String.Empty;

        [SdkCommandArgument("redirect_uri")]
        public string RedirectUri { get; set; } = String.Empty;

        [SdkCommandArgument("refresh_token")]
        public string RefreshToken { get; set; } = String.Empty;

        [SdkCommandArgument("username")]
        public string Username { get; set; } = String.Empty;

        [SdkCommandArgument("grant_type")]
        public string GrantType { get; set; } = String.Empty;

        public TokenGrantCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth(_SDK);

            #pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.TokenGrant.Builder;



            if (Code != null)
                opBuilder.SetCode((string)Code);
            if (ExtendExp != null)
                opBuilder.SetExtendExp((bool)ExtendExp);
            if (Namespace != null)
                opBuilder.SetNamespace((string)Namespace);
            if (Password != null)
                opBuilder.SetPassword((string)Password);
            if (RedirectUri != null)
                opBuilder.SetRedirectUri((string)RedirectUri);
            if (RefreshToken != null)
                opBuilder.SetRefreshToken((string)RefreshToken);
            if (Username != null)
                opBuilder.SetUsername((string)Username);


            TokenGrant operation = opBuilder.Build(
                GrantType
            );

            #pragma warning restore ab_deprecated_operation

            #pragma warning disable ab_deprecated_operation_wrapper
            var response = wrapper.TokenGrant(operation);
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