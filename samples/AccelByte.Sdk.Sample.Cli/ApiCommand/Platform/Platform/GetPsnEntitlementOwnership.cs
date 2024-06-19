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
    [SdkConsoleCommand("platform", "getpsnentitlementownership")]
    public class GetPsnEntitlementOwnershipCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "GetPsnEntitlementOwnership"; } }

        [SdkCommandArgument("entitlementLabel")]
        public string EntitlementLabel { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public PsnEntitlementOwnershipRequest Body { get; set; } = new PsnEntitlementOwnershipRequest();

        public GetPsnEntitlementOwnershipCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Platform wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Platform(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.GetPsnEntitlementOwnership.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Platform.Model.PsnEntitlementOwnershipRequest)Body);



            GetPsnEntitlementOwnership operation = opBuilder.Build(
                EntitlementLabel,
                Namespace
            );


            AccelByte.Sdk.Api.Platform.Model.Ownership? response = wrapper.GetPsnEntitlementOwnership(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}