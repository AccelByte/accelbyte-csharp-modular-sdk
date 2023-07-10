// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam","authorizev3")]
    public class AuthorizeV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AuthorizeV3"; } }

        [SdkCommandArgument("codeChallenge")]
        public string? CodeChallenge { get; set; }

        [SdkCommandArgument("codeChallengeMethod")]
        public string? CodeChallengeMethod { get; set; }

        [SdkCommandArgument("createHeadless")]
        public bool? CreateHeadless { get; set; }

        [SdkCommandArgument("oneTimeLinkCode")]
        public string? OneTimeLinkCode { get; set; }

        [SdkCommandArgument("redirectUri")]
        public string? RedirectUri { get; set; }

        [SdkCommandArgument("scope")]
        public string? Scope { get; set; }

        [SdkCommandArgument("state")]
        public string? State { get; set; }

        [SdkCommandArgument("targetAuthPage")]
        public string? TargetAuthPage { get; set; }

        [SdkCommandArgument("useRedirectUriAsLoginUrlWhenLocked")]
        public bool? UseRedirectUriAsLoginUrlWhenLocked { get; set; }

        [SdkCommandArgument("clientId")]
        public string ClientId { get; set; } = String.Empty;

        [SdkCommandArgument("responseType")]
        public string ResponseType { get; set; } = String.Empty;

        public AuthorizeV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AuthorizeV3.Builder;

            if (CodeChallenge != null)
                opBuilder.SetCodeChallenge((string)CodeChallenge);
            if (CodeChallengeMethod != null)
                opBuilder.SetCodeChallengeMethod(AuthorizeV3CodeChallengeMethod.NewValue(CodeChallengeMethod));
            if (CreateHeadless != null)
                opBuilder.SetCreateHeadless((bool)CreateHeadless);
            if (OneTimeLinkCode != null)
                opBuilder.SetOneTimeLinkCode((string)OneTimeLinkCode);
            if (RedirectUri != null)
                opBuilder.SetRedirectUri((string)RedirectUri);
            if (Scope != null)
                opBuilder.SetScope((string)Scope);
            if (State != null)
                opBuilder.SetState((string)State);
            if (TargetAuthPage != null)
                opBuilder.SetTargetAuthPage((string)TargetAuthPage);
            if (UseRedirectUriAsLoginUrlWhenLocked != null)
                opBuilder.SetUseRedirectUriAsLoginUrlWhenLocked((bool)UseRedirectUriAsLoginUrlWhenLocked);




            AuthorizeV3 operation = opBuilder.Build(
                ClientId,
                ResponseType
            );

            
            string? response = wrapper.AuthorizeV3(operation);
            if (response == null)
                return "No response from server.";
            return response!;            
        }
    }
}