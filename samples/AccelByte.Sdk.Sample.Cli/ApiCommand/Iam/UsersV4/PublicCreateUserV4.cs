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
    [SdkConsoleCommand("iam","publiccreateuserv4")]
    public class PublicCreateUserV4Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "PublicCreateUserV4"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public AccountCreateUserRequestV4 Body { get; set; } = new AccountCreateUserRequestV4();

        public PublicCreateUserV4Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.UsersV4 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.UsersV4(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.PublicCreateUserV4.Builder;





            PublicCreateUserV4 operation = opBuilder.Build(
                Body,
                Namespace
            );


            AccelByte.Sdk.Api.Iam.Model.AccountCreateUserResponseV4? response = wrapper.PublicCreateUserV4(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}