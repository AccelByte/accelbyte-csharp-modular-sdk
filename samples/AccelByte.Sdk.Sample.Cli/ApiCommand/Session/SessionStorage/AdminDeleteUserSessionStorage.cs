// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Session
{
    [SdkConsoleCommand("session","admindeleteusersessionstorage")]
    public class AdminDeleteUserSessionStorageCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Session"; } }

        public string OperationName{ get { return "AdminDeleteUserSessionStorage"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("sessionId")]
        public string SessionId { get; set; } = String.Empty;

        public AdminDeleteUserSessionStorageCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.SessionStorage wrapper = new AccelByte.Sdk.Api.Session.Wrapper.SessionStorage(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Session.Operation.AdminDeleteUserSessionStorage.Builder;





            AdminDeleteUserSessionStorage operation = opBuilder.Build(
                Namespace,
                SessionId
            );


            wrapper.AdminDeleteUserSessionStorage(operation);
            return String.Empty;
        }
    }
}