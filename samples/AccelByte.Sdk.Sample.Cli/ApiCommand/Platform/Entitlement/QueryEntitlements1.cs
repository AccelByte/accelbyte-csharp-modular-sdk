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
    [SdkConsoleCommand("platform","queryentitlements1")]
    public class QueryEntitlements1Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QueryEntitlements1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("activeOnly")]
        public bool? ActiveOnly { get; set; }

        [SdkCommandArgument("appType")]
        public string? AppType { get; set; }

        [SdkCommandArgument("entitlementClazz")]
        public string? EntitlementClazz { get; set; }

        [SdkCommandArgument("entitlementName")]
        public string? EntitlementName { get; set; }

        [SdkCommandArgument("itemId")]
        public List<string>? ItemId { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("origin")]
        public string? Origin { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public QueryEntitlements1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Entitlement wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Entitlement(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.QueryEntitlements1.Builder;

            if (ActiveOnly != null)
                opBuilder.SetActiveOnly((bool)ActiveOnly);
            if (AppType != null)
                opBuilder.SetAppType(QueryEntitlements1AppType.NewValue(AppType));
            if (EntitlementClazz != null)
                opBuilder.SetEntitlementClazz(QueryEntitlements1EntitlementClazz.NewValue(EntitlementClazz));
            if (EntitlementName != null)
                opBuilder.SetEntitlementName((string)EntitlementName);
            if (ItemId != null)
                opBuilder.SetItemId((List<string>)ItemId);
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (Origin != null)
                opBuilder.SetOrigin(QueryEntitlements1Origin.NewValue(Origin));
            if (UserId != null)
                opBuilder.SetUserId((string)UserId);




            QueryEntitlements1 operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.QueryEntitlements1(operation);
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