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

using AccelByte.Sdk.Api.Group.Wrapper;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Group
{
    [SdkConsoleCommand("group","getgrouplistpublicv1")]
    public class GetGroupListPublicV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Group"; } }

        public string OperationName{ get { return "GetGroupListPublicV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("groupName")]
        public string? GroupName { get; set; }

        [SdkCommandArgument("groupRegion")]
        public string? GroupRegion { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        public GetGroupListPublicV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.Group wrapper = new AccelByte.Sdk.Api.Group.Wrapper.Group(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Group.Operation.GetGroupListPublicV1.Builder;

            if (GroupName != null)
                opBuilder.SetGroupName((string)GroupName);
            if (GroupRegion != null)
                opBuilder.SetGroupRegion((string)GroupRegion);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);




            GetGroupListPublicV1 operation = opBuilder.Build(
                Namespace
            );

            
            AccelByte.Sdk.Api.Group.Model.ModelsGetGroupsListResponseV1? response = wrapper.GetGroupListPublicV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}