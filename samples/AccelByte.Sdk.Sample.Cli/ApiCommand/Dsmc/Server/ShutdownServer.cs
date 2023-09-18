// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Dsmc
{
    [SdkConsoleCommand("dsmc", "shutdownserver")]
    public class ShutdownServerCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Dsmc"; } }

        public string OperationName { get { return "ShutdownServer"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsShutdownServerRequest Body { get; set; } = new ModelsShutdownServerRequest();

        public ShutdownServerCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.Server wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.Server(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Dsmc.Operation.ShutdownServer.Builder;





            ShutdownServer operation = opBuilder.Build(
                Body,
                Namespace
            );


            wrapper.ShutdownServer(operation);
            return String.Empty;
        }
    }
}