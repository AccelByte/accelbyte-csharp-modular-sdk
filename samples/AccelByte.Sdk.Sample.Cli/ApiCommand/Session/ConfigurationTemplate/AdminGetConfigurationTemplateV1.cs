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
    [SdkConsoleCommand("session","admingetconfigurationtemplatev1")]
    public class AdminGetConfigurationTemplateV1Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Session"; } }

        public string OperationName{ get { return "AdminGetConfigurationTemplateV1"; } }

        [SdkCommandArgument("name")]
        public string Name { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public AdminGetConfigurationTemplateV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.ConfigurationTemplate wrapper = new AccelByte.Sdk.Api.Session.Wrapper.ConfigurationTemplate(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Session.Operation.AdminGetConfigurationTemplateV1.Builder;





            AdminGetConfigurationTemplateV1 operation = opBuilder.Build(
                Name,
                Namespace
            );


            AccelByte.Sdk.Api.Session.Model.ApimodelsConfigurationTemplateResponse? response = wrapper.AdminGetConfigurationTemplateV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}