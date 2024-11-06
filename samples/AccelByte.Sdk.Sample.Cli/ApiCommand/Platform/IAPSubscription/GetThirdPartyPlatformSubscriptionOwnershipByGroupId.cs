// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","getthirdpartyplatformsubscriptionownershipbygroupid")]
    public class GetThirdPartyPlatformSubscriptionOwnershipByGroupIdCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "GetThirdPartyPlatformSubscriptionOwnershipByGroupId"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platform")]
        public string Platform { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("groupId")]
        public string GroupId { get; set; } = String.Empty;

        public GetThirdPartyPlatformSubscriptionOwnershipByGroupIdCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.IAPSubscription wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.IAPSubscription(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.GetThirdPartyPlatformSubscriptionOwnershipByGroupId.Builder;





            GetThirdPartyPlatformSubscriptionOwnershipByGroupId operation = opBuilder.Build(
                Namespace,
                Platform,
                UserId,
                GroupId
            );


            var response = wrapper.GetThirdPartyPlatformSubscriptionOwnershipByGroupId(operation);
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