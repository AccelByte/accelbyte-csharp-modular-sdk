// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Eventlog.Wrapper;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Eventlog
{
    [SdkConsoleCommand("eventlog","getregisteredeventsbyeventtypehandler")]
    public class GetRegisteredEventsByEventTypeHandlerCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "GetRegisteredEventsByEventTypeHandler"; } }

        [SdkCommandArgument("eventType")]
        public string EventType { get; set; } = String.Empty;

        public GetRegisteredEventsByEventTypeHandlerCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.EventRegistry wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.EventRegistry(_SDK);

            #pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Eventlog.Operation.GetRegisteredEventsByEventTypeHandler.Builder;





            GetRegisteredEventsByEventTypeHandler operation = opBuilder.Build(
                EventType
            );

            #pragma warning restore ab_deprecated_operation

            #pragma warning disable ab_deprecated_operation_wrapper
            AccelByte.Sdk.Api.Eventlog.Model.ModelsEventRegistry? response = wrapper.GetRegisteredEventsByEventTypeHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
            #pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}