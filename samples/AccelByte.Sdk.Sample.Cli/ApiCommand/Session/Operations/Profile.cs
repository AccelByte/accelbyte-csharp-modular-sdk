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
    [SdkConsoleCommand("session", "profile")]
    public class ProfileCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Session"; } }

        public string OperationName { get { return "Profile"; } }

        public ProfileCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.Operations wrapper = new AccelByte.Sdk.Api.Session.Wrapper.Operations(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Session.Operation.Profile.Builder;





            Profile operation = opBuilder.Build(
            );


            wrapper.Profile(operation);
            return String.Empty;
        }
    }
}