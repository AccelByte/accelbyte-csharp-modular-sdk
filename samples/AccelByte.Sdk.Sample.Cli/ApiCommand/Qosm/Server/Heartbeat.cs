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
    [SdkConsoleCommand("qosm","heartbeat")]
    public class HeartbeatCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Qosm"; } }

        public string OperationName{ get { return "Heartbeat"; } }

        [SdkCommandData("body")]
        public ModelsHeartbeatRequest Body { get; set; } = new ModelsHeartbeatRequest();
                
        public HeartbeatCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Qosm.Wrapper.Server wrapper = new AccelByte.Sdk.Api.Qosm.Wrapper.Server(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Qosm.Operation.Heartbeat.Builder;





            Heartbeat operation = opBuilder.Build(
                Body
            );

            
            wrapper.Heartbeat(operation);
            return String.Empty;
        }
    }
}