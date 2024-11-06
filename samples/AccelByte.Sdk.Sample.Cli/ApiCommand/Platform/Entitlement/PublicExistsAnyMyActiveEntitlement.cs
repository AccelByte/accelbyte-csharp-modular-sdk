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
    [SdkConsoleCommand("platform","publicexistsanymyactiveentitlement")]
    public class PublicExistsAnyMyActiveEntitlementCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicExistsAnyMyActiveEntitlement"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("appIds")]
        public List<string>? AppIds { get; set; }

        [SdkCommandArgument("itemIds")]
        public List<string>? ItemIds { get; set; }

        [SdkCommandArgument("skus")]
        public List<string>? Skus { get; set; }

        public PublicExistsAnyMyActiveEntitlementCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Entitlement wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Entitlement(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.PublicExistsAnyMyActiveEntitlement.Builder;

            if (AppIds != null)
                opBuilder.SetAppIds((List<string>)AppIds);
            if (ItemIds != null)
                opBuilder.SetItemIds((List<string>)ItemIds);
            if (Skus != null)
                opBuilder.SetSkus((List<string>)Skus);




            PublicExistsAnyMyActiveEntitlement operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.PublicExistsAnyMyActiveEntitlement(operation);
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