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
    [SdkConsoleCommand("iam","adminsearchusersv2")]
    public class AdminSearchUsersV2Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminSearchUsersV2"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("after")]
        public string? After { get; set; }

        [SdkCommandArgument("before")]
        public string? Before { get; set; }

        [SdkCommandArgument("displayName")]
        public string? DisplayName { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("loginId")]
        public string? LoginId { get; set; }

        [SdkCommandArgument("platformUserId")]
        public string? PlatformUserId { get; set; }

        [SdkCommandArgument("roleId")]
        public string? RoleId { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        public AdminSearchUsersV2Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            #pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AdminSearchUsersV2.Builder;

            if (After != null)
                opBuilder.SetAfter((string)After);
            if (Before != null)
                opBuilder.SetBefore((string)Before);
            if (DisplayName != null)
                opBuilder.SetDisplayName((string)DisplayName);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (LoginId != null)
                opBuilder.SetLoginId((string)LoginId);
            if (PlatformUserId != null)
                opBuilder.SetPlatformUserId((string)PlatformUserId);
            if (RoleId != null)
                opBuilder.SetRoleId((string)RoleId);
            if (UserId != null)
                opBuilder.SetUserId((string)UserId);




            AdminSearchUsersV2 operation = opBuilder.Build(
                Namespace,
                PlatformId
            );

            #pragma warning restore ab_deprecated_operation

            #pragma warning disable ab_deprecated_operation_wrapper
            var response = wrapper.AdminSearchUsersV2(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
            #pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}