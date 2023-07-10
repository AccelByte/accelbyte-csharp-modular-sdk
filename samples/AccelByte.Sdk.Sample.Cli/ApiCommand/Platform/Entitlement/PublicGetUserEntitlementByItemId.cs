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

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","publicgetuserentitlementbyitemid")]
    public class PublicGetUserEntitlementByItemIdCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicGetUserEntitlementByItemId"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("entitlementClazz")]
        public string? EntitlementClazz { get; set; }

        [SdkCommandArgument("itemId")]
        public string ItemId { get; set; } = String.Empty;

        public PublicGetUserEntitlementByItemIdCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Entitlement wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Entitlement(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.PublicGetUserEntitlementByItemId.Builder;

            if (EntitlementClazz != null)
                opBuilder.SetEntitlementClazz(PublicGetUserEntitlementByItemIdEntitlementClazz.NewValue(EntitlementClazz));




            PublicGetUserEntitlementByItemId operation = opBuilder.Build(
                Namespace,
                UserId,
                ItemId
            );

            
            AccelByte.Sdk.Api.Platform.Model.EntitlementInfo? response = wrapper.PublicGetUserEntitlementByItemId(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}