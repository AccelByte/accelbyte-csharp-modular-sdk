// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam","admingetrolesv4")]
    public class AdminGetRolesV4Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminGetRolesV4"; } }

        [SdkCommandArgument("adminRole")]
        public bool? AdminRole { get; set; }

        [SdkCommandArgument("isWildcard")]
        public bool? IsWildcard { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        public AdminGetRolesV4Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Roles wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Roles(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AdminGetRolesV4.Builder;

            if (AdminRole != null)
                opBuilder.SetAdminRole((bool)AdminRole);
            if (IsWildcard != null)
                opBuilder.SetIsWildcard((bool)IsWildcard);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);




            AdminGetRolesV4 operation = opBuilder.Build(
            );


            AccelByte.Sdk.Api.Iam.Model.ModelListRoleV4Response? response = wrapper.AdminGetRolesV4(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}