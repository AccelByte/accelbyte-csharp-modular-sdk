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

using AccelByte.Sdk.Api.Ams.Wrapper;
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Api.Ams.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ams
{
    [SdkConsoleCommand("ams","portalhealthcheck")]
    public class PortalHealthCheckCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ams"; } }

        public string OperationName{ get { return "PortalHealthCheck"; } }

        public PortalHealthCheckCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ams.Wrapper.Operations wrapper = new AccelByte.Sdk.Api.Ams.Wrapper.Operations(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ams.Operation.PortalHealthCheck.Builder;





            PortalHealthCheck operation = opBuilder.Build(
            );

            
            wrapper.PortalHealthCheck(operation);
            return String.Empty;
        }
    }
}