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
    [SdkConsoleCommand("iam","adminenablemyauthenticatorv4")]
    public class AdminEnableMyAuthenticatorV4Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminEnableMyAuthenticatorV4"; } }

        [SdkCommandArgument("code")]
        public string Code { get; set; } = String.Empty;

        public AdminEnableMyAuthenticatorV4Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.UsersV4 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.UsersV4(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AdminEnableMyAuthenticatorV4.Builder;



            if (Code != null)
                opBuilder.SetCode((string)Code);


            AdminEnableMyAuthenticatorV4 operation = opBuilder.Build(
            );


            wrapper.AdminEnableMyAuthenticatorV4(operation);
            return String.Empty;
        }
    }
}