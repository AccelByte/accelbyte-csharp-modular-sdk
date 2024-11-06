// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Match2.Wrapper;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Match2
{
    [SdkConsoleCommand("match2","updateruleset")]
    public class UpdateRuleSetCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Match2"; } }

        public string OperationName{ get { return "UpdateRuleSet"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("ruleset")]
        public string Ruleset { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApiRuleSetPayload Body { get; set; } = new ApiRuleSetPayload();

        public UpdateRuleSetCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Match2.Wrapper.RuleSets wrapper = new AccelByte.Sdk.Api.Match2.Wrapper.RuleSets(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Match2.Operation.UpdateRuleSet.Builder;





            UpdateRuleSet operation = opBuilder.Build(
                Body,
                Namespace,
                Ruleset
            );


            var response = wrapper.UpdateRuleSet(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (response.Error != null)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}