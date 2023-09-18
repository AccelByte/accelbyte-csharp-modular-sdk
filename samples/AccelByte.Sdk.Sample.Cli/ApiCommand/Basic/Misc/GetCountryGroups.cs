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
    [SdkConsoleCommand("basic", "getcountrygroups")]
    public class GetCountryGroupsCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Basic"; } }

        public string OperationName { get { return "GetCountryGroups"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("groupCode")]
        public string? GroupCode { get; set; }

        public GetCountryGroupsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.Misc wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.Misc(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Basic.Operation.GetCountryGroups.Builder;

            if (GroupCode != null)
                opBuilder.SetGroupCode((string)GroupCode);




            GetCountryGroups operation = opBuilder.Build(
                Namespace
            );


            List<AccelByte.Sdk.Api.Basic.Model.RetrieveCountryGroupResponse>? response = wrapper.GetCountryGroups(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}