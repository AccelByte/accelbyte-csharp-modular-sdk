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
    [SdkConsoleCommand("group","getsinglememberroleadminv1")]
    public class GetSingleMemberRoleAdminV1Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Group"; } }

        public string OperationName{ get { return "GetSingleMemberRoleAdminV1"; } }

        [SdkCommandArgument("memberRoleId")]
        public string MemberRoleId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetSingleMemberRoleAdminV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.GroupRoles wrapper = new AccelByte.Sdk.Api.Group.Wrapper.GroupRoles(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Group.Operation.GetSingleMemberRoleAdminV1.Builder;





            GetSingleMemberRoleAdminV1 operation = opBuilder.Build(
                MemberRoleId,
                Namespace
            );


            AccelByte.Sdk.Api.Group.Model.ModelsMemberRoleResponseV1? response = wrapper.GetSingleMemberRoleAdminV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}