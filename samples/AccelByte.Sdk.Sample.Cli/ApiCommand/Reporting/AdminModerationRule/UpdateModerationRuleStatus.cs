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

using AccelByte.Sdk.Api.Reporting.Wrapper;
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Reporting
{
    [SdkConsoleCommand("reporting","updatemoderationrulestatus")]
    public class UpdateModerationRuleStatusCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Reporting"; } }

        public string OperationName{ get { return "UpdateModerationRuleStatus"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("ruleId")]
        public string RuleId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public RestapiModerationRuleActiveRequest Body { get; set; } = new RestapiModerationRuleActiveRequest();
                
        public UpdateModerationRuleStatusCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Reporting.Wrapper.AdminModerationRule wrapper = new AccelByte.Sdk.Api.Reporting.Wrapper.AdminModerationRule(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Reporting.Operation.UpdateModerationRuleStatus.Builder;





            UpdateModerationRuleStatus operation = opBuilder.Build(
                Body,
                Namespace,
                RuleId
            );

            
            wrapper.UpdateModerationRuleStatus(operation);
            return String.Empty;
        }
    }
}