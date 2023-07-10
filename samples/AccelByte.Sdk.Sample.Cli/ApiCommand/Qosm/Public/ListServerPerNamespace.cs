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

using AccelByte.Sdk.Api.Qosm.Wrapper;
using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Api.Qosm.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Qosm
{
    [SdkConsoleCommand("qosm","listserverpernamespace")]
    public class ListServerPerNamespaceCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Qosm"; } }

        public string OperationName{ get { return "ListServerPerNamespace"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        public ListServerPerNamespaceCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Qosm.Wrapper.Public wrapper = new AccelByte.Sdk.Api.Qosm.Wrapper.Public(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Qosm.Operation.ListServerPerNamespace.Builder;

            if (Status != null)
                opBuilder.SetStatus((string)Status);




            ListServerPerNamespace operation = opBuilder.Build(
                Namespace
            );

            
            AccelByte.Sdk.Api.Qosm.Model.ModelsListServerResponse? response = wrapper.ListServerPerNamespace(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}