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
    [SdkConsoleCommand("platform","getuserentitlementbyitemid")]
    public class GetUserEntitlementByItemIdCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "GetUserEntitlementByItemId"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("activeOnly")]
        public bool? ActiveOnly { get; set; }

        [SdkCommandArgument("entitlementClazz")]
        public string? EntitlementClazz { get; set; }

        [SdkCommandArgument("platform")]
        public string? Platform { get; set; }

        [SdkCommandArgument("itemId")]
        public string ItemId { get; set; } = String.Empty;

        public GetUserEntitlementByItemIdCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Entitlement wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Entitlement(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.GetUserEntitlementByItemId.Builder;

            if (ActiveOnly != null)
                opBuilder.SetActiveOnly((bool)ActiveOnly);
            if (EntitlementClazz != null)
                opBuilder.SetEntitlementClazz(GetUserEntitlementByItemIdEntitlementClazz.NewValue(EntitlementClazz));
            if (Platform != null)
                opBuilder.SetPlatform((string)Platform);




            GetUserEntitlementByItemId operation = opBuilder.Build(
                Namespace,
                UserId,
                ItemId
            );


            var response = wrapper.GetUserEntitlementByItemId(operation);
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
        }
    }
}