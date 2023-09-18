// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Lobby
{
    [SdkConsoleCommand("lobby","adminimportconfigv1")]
    public class AdminImportConfigV1Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "AdminImportConfigV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandFile("file")]
        public Stream? File { get; set; }

        public AdminImportConfigV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Config wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Config(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Lobby.Operation.AdminImportConfigV1.Builder;



            if (File != null)
                opBuilder.SetFile((Stream)File);


            AdminImportConfigV1 operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Lobby.Model.ModelsImportConfigResponse? response = wrapper.AdminImportConfigV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}