// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Gametelemetry.Wrapper;
using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Api.Gametelemetry.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Gametelemetry
{
    [SdkConsoleCommand("gametelemetry","protectedsaveeventsgametelemetryv1protectedeventspost")]
    public class ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Gametelemetry"; } }

        public string OperationName{ get { return "ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost"; } }

        [SdkCommandData("body")]
        public List<TelemetryBody> Body { get; set; } = new List<TelemetryBody>();

        [SdkCommandArgument("access_token")]
        public string AccessToken { get; set; } = String.Empty;

        public ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Gametelemetry.Wrapper.GametelemetryOperations wrapper = new AccelByte.Sdk.Api.Gametelemetry.Wrapper.GametelemetryOperations(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Gametelemetry.Operation.ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost.Builder;





            ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost operation = opBuilder.Build(
                Body

            );


            var response = wrapper.ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (response.Error != null)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}