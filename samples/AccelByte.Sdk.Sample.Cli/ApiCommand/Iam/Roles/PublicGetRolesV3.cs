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
    [SdkConsoleCommand("iam","publicgetrolesv3")]
    public class PublicGetRolesV3Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "PublicGetRolesV3"; } }

        [SdkCommandArgument("after")]
        public string? After { get; set; }

        [SdkCommandArgument("before")]
        public string? Before { get; set; }

        [SdkCommandArgument("isWildcard")]
        public bool? IsWildcard { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        public PublicGetRolesV3Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Roles wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Roles(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.PublicGetRolesV3.Builder;

            if (After != null)
                opBuilder.SetAfter((string)After);
            if (Before != null)
                opBuilder.SetBefore((string)Before);
            if (IsWildcard != null)
                opBuilder.SetIsWildcard((bool)IsWildcard);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);




            PublicGetRolesV3 operation = opBuilder.Build(
            );


            AccelByte.Sdk.Api.Iam.Model.ModelRoleNamesResponseV3? response = wrapper.PublicGetRolesV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}