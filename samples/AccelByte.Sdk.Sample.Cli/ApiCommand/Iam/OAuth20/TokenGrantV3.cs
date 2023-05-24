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
    [SdkConsoleCommand("iam","tokengrantv3")]
    public class TokenGrantV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "TokenGrantV3"; } }

        [SdkCommandArgument("client_id")]
        public string ClientId { get; set; } = String.Empty;
                    
        [SdkCommandArgument("code")]
        public string Code { get; set; } = String.Empty;
                    
        [SdkCommandArgument("code_verifier")]
        public string CodeVerifier { get; set; } = String.Empty;
                    
        [SdkCommandArgument("extend_exp")]
        public bool ExtendExp { get; set; } = false;
                    
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
                    
        public TokenGrantV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.TokenGrantV3.Builder;



            if (ClientId != null)
                opBuilder.SetClientId((string)ClientId);
            if (Code != null)
                opBuilder.SetCode((string)Code);
            if (CodeVerifier != null)
                opBuilder.SetCodeVerifier((string)CodeVerifier);
            if (ExtendExp != null)
                opBuilder.SetExtendExp((bool)ExtendExp);
            if (Password != null)
                opBuilder.SetPassword((string)Password);
            if (RedirectUri != null)
                opBuilder.SetRedirectUri((string)RedirectUri);
            if (RefreshToken != null)
                opBuilder.SetRefreshToken((string)RefreshToken);
            if (Username != null)
                opBuilder.SetUsername((string)Username);


            TokenGrantV3 operation = opBuilder.Build(
                GrantType
            );

            
            AccelByte.Sdk.Api.Iam.Model.OauthmodelTokenWithDeviceCookieResponseV3? response = wrapper.TokenGrantV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}