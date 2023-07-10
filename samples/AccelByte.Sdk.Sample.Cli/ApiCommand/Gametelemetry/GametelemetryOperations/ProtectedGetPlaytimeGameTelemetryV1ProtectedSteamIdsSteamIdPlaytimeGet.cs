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

using AccelByte.Sdk.Api.Gametelemetry.Wrapper;
using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Api.Gametelemetry.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Gametelemetry
{
    [SdkConsoleCommand("gametelemetry","protectedgetplaytimegametelemetryv1protectedsteamidssteamidplaytimeget")]
    public class ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGetCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Gametelemetry"; } }

        public string OperationName{ get { return "ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet"; } }

        [SdkCommandArgument("steamId")]
        public string SteamId { get; set; } = String.Empty;

        [SdkCommandArgument("access_token")]
        public string AccessToken { get; set; } = String.Empty;

        public ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGetCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Gametelemetry.Wrapper.GametelemetryOperations wrapper = new AccelByte.Sdk.Api.Gametelemetry.Wrapper.GametelemetryOperations(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Gametelemetry.Operation.ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet.Builder;





            ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet operation = opBuilder.Build(
                SteamId

            );

            
            Dictionary<string, object>? response = wrapper.ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}