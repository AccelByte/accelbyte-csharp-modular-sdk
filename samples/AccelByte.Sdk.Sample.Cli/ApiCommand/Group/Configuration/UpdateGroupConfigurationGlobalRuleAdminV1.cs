// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Group.Wrapper;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Group
{
    [SdkConsoleCommand("group","updategroupconfigurationglobalruleadminv1")]
    public class UpdateGroupConfigurationGlobalRuleAdminV1Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Group"; } }

        public string OperationName{ get { return "UpdateGroupConfigurationGlobalRuleAdminV1"; } }

        [SdkCommandArgument("allowedAction")]
        public string AllowedAction { get; set; } = String.Empty;

        [SdkCommandArgument("configurationCode")]
        public string ConfigurationCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUpdateGroupConfigurationGlobalRulesRequestV1 Body { get; set; } = new ModelsUpdateGroupConfigurationGlobalRulesRequestV1();

        public UpdateGroupConfigurationGlobalRuleAdminV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.Configuration wrapper = new AccelByte.Sdk.Api.Group.Wrapper.Configuration(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Group.Operation.UpdateGroupConfigurationGlobalRuleAdminV1.Builder;





            UpdateGroupConfigurationGlobalRuleAdminV1 operation = opBuilder.Build(
                Body,
                AllowedAction,
                ConfigurationCode,
                Namespace
            );


            AccelByte.Sdk.Api.Group.Model.ModelsUpdateGroupConfigurationResponseV1? response = wrapper.UpdateGroupConfigurationGlobalRuleAdminV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}