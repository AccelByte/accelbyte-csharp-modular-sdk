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
    [SdkConsoleCommand("session","adminqueryplayerattributes")]
    public class AdminQueryPlayerAttributesCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Session"; } }

        public string OperationName{ get { return "AdminQueryPlayerAttributes"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("users")]
        public string? Users { get; set; }

        public AdminQueryPlayerAttributesCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.Player wrapper = new AccelByte.Sdk.Api.Session.Wrapper.Player(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Session.Operation.AdminQueryPlayerAttributes.Builder;

            if (Users != null)
                opBuilder.SetUsers((string)Users);




            AdminQueryPlayerAttributes operation = opBuilder.Build(
                Namespace
            );


            List<AccelByte.Sdk.Api.Session.Model.ApimodelsPlayerAttributesResponseBody>? response = wrapper.AdminQueryPlayerAttributes(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}