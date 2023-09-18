// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Basic
{
    [SdkConsoleCommand("basic","addcountrygroup")]
    public class AddCountryGroupCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Basic"; } }

        public string OperationName{ get { return "AddCountryGroup"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public AddCountryGroupRequest Body { get; set; } = new AddCountryGroupRequest();

        public AddCountryGroupCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.Misc wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.Misc(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Basic.Operation.AddCountryGroup.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Basic.Model.AddCountryGroupRequest)Body);



            AddCountryGroup operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Basic.Model.AddCountryGroupResponse? response = wrapper.AddCountryGroup(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}