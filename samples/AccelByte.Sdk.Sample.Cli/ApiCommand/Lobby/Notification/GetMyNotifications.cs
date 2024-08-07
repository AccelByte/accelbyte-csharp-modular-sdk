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
    [SdkConsoleCommand("lobby", "getmynotifications")]
    public class GetMyNotificationsCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Lobby"; } }

        public string OperationName { get { return "GetMyNotifications"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("endTime")]
        public long? EndTime { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("startTime")]
        public long? StartTime { get; set; }

        public GetMyNotificationsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Notification wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Notification(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Lobby.Operation.GetMyNotifications.Builder;

            if (EndTime != null)
                opBuilder.SetEndTime((long)EndTime);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (StartTime != null)
                opBuilder.SetStartTime((long)StartTime);




            GetMyNotifications operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Lobby.Model.ModelNotificationResponse? response = wrapper.GetMyNotifications(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}