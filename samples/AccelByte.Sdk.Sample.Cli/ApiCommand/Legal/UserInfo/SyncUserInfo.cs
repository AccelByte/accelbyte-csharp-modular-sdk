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
    [SdkConsoleCommand("legal","syncuserinfo")]
    public class SyncUserInfoCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "SyncUserInfo"; } }

        [SdkCommandArgument("namespace_")]
        public string Namespace { get; set; } = String.Empty;

        public SyncUserInfoCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.UserInfo wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.UserInfo(_SDK);

            #pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.SyncUserInfo.Builder;





            SyncUserInfo operation = opBuilder.Build(
                Namespace
            );

            #pragma warning restore ab_deprecated_operation

            #pragma warning disable ab_deprecated_operation_wrapper
            wrapper.SyncUserInfo(operation);
            return String.Empty;
            #pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}