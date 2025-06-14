// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("gametelemetry","geteventsgametelemetryv1adminnamespacesnamespaceeventsget")]
    public class GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Gametelemetry"; } }

        public string OperationName{ get { return "GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("deviceType")]
        public string? DeviceType { get; set; }

        [SdkCommandArgument("endTime")]
        public string? EndTime { get; set; }

        [SdkCommandArgument("eventId")]
        public string? EventId { get; set; }

        [SdkCommandArgument("eventName")]
        public string? EventName { get; set; }

        [SdkCommandArgument("eventPayload")]
        public string? EventPayload { get; set; }

        [SdkCommandArgument("flightId")]
        public string? FlightId { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("startTime")]
        public string? StartTime { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Gametelemetry.Wrapper.Telemetry wrapper = new AccelByte.Sdk.Api.Gametelemetry.Wrapper.Telemetry(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Gametelemetry.Operation.GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet.Builder;

            if (DeviceType != null)
                opBuilder.SetDeviceType((string)DeviceType);
            if (EndTime != null)
                opBuilder.SetEndTime((string)EndTime);
            if (EventId != null)
                opBuilder.SetEventId((string)EventId);
            if (EventName != null)
                opBuilder.SetEventName((string)EventName);
            if (EventPayload != null)
                opBuilder.SetEventPayload((string)EventPayload);
            if (FlightId != null)
                opBuilder.SetFlightId((string)FlightId);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (StartTime != null)
                opBuilder.SetStartTime((string)StartTime);
            if (UserId != null)
                opBuilder.SetUserId((string)UserId);




            GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}