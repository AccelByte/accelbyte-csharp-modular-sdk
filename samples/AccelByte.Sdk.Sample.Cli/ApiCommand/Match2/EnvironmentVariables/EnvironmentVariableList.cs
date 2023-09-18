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
    [SdkConsoleCommand("match2","environmentvariablelist")]
    public class EnvironmentVariableListCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Match2"; } }

        public string OperationName{ get { return "EnvironmentVariableList"; } }

        public EnvironmentVariableListCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Match2.Wrapper.EnvironmentVariables wrapper = new AccelByte.Sdk.Api.Match2.Wrapper.EnvironmentVariables(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Match2.Operation.EnvironmentVariableList.Builder;





            EnvironmentVariableList operation = opBuilder.Build(
            );


            AccelByte.Sdk.Api.Match2.Model.ApiListEnvironmentVariablesResponse? response = wrapper.EnvironmentVariableList(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}