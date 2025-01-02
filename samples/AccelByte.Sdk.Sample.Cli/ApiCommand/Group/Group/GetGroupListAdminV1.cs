// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("group", "getgrouplistadminv1")]
    public class GetGroupListAdminV1Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Group"; } }

        public string OperationName { get { return "GetGroupListAdminV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("configurationCode")]
        public string? ConfigurationCode { get; set; }

        [SdkCommandArgument("groupName")]
        public string? GroupName { get; set; }

        [SdkCommandArgument("groupRegion")]
        public string? GroupRegion { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        public GetGroupListAdminV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.Group wrapper = new AccelByte.Sdk.Api.Group.Wrapper.Group(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Group.Operation.GetGroupListAdminV1.Builder;

            if (ConfigurationCode != null)
                opBuilder.SetConfigurationCode((string)ConfigurationCode);
            if (GroupName != null)
                opBuilder.SetGroupName((string)GroupName);
            if (GroupRegion != null)
                opBuilder.SetGroupRegion((string)GroupRegion);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);




            GetGroupListAdminV1 operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.GetGroupListAdminV1(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-", "response data is null.");
            }
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}