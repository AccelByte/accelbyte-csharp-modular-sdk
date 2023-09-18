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
    [SdkConsoleCommand("session","admingetconfigurationalertv1")]
    public class AdminGetConfigurationAlertV1Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Session"; } }

        public string OperationName{ get { return "AdminGetConfigurationAlertV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public AdminGetConfigurationAlertV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.ConfigurationTemplate wrapper = new AccelByte.Sdk.Api.Session.Wrapper.ConfigurationTemplate(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Session.Operation.AdminGetConfigurationAlertV1.Builder;





            AdminGetConfigurationAlertV1 operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Session.Model.ApimodelsConfigAlertResponse? response = wrapper.AdminGetConfigurationAlertV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}