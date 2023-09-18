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
    [SdkConsoleCommand("match2", "createruleset")]
    public class CreateRuleSetCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Match2"; } }

        public string OperationName { get { return "CreateRuleSet"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApiRuleSetPayload Body { get; set; } = new ApiRuleSetPayload();

        public CreateRuleSetCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Match2.Wrapper.RuleSets wrapper = new AccelByte.Sdk.Api.Match2.Wrapper.RuleSets(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Match2.Operation.CreateRuleSet.Builder;





            CreateRuleSet operation = opBuilder.Build(
                Body,
                Namespace
            );


            wrapper.CreateRuleSet(operation);
            return String.Empty;
        }
    }
}