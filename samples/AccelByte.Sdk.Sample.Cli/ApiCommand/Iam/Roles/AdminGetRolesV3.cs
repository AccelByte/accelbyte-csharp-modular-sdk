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
    [SdkConsoleCommand("iam","admingetrolesv3")]
    public class AdminGetRolesV3Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminGetRolesV3"; } }

        [SdkCommandArgument("after")]
        public string? After { get; set; }

        [SdkCommandArgument("before")]
        public string? Before { get; set; }

        [SdkCommandArgument("isWildcard")]
        public bool? IsWildcard { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        public AdminGetRolesV3Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Roles wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Roles(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AdminGetRolesV3.Builder;

            if (After != null)
                opBuilder.SetAfter((string)After);
            if (Before != null)
                opBuilder.SetBefore((string)Before);
            if (IsWildcard != null)
                opBuilder.SetIsWildcard((bool)IsWildcard);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);




            AdminGetRolesV3 operation = opBuilder.Build(
            );


            var response = wrapper.AdminGetRolesV3(operation);
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