// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Basic
{
    [SdkConsoleCommand("basic", "publicgetnamespaces")]
    public class PublicGetNamespacesCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Basic"; } }

        public string OperationName { get { return "PublicGetNamespaces"; } }

        [SdkCommandArgument("activeOnly")]
        public bool? ActiveOnly { get; set; }

        public PublicGetNamespacesCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.Namespace wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.Namespace(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Basic.Operation.PublicGetNamespaces.Builder;

            if (ActiveOnly != null)
                opBuilder.SetActiveOnly((bool)ActiveOnly);




            PublicGetNamespaces operation = opBuilder.Build(
            );


            List<AccelByte.Sdk.Api.Basic.Model.NamespaceInfo>? response = wrapper.PublicGetNamespaces(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}