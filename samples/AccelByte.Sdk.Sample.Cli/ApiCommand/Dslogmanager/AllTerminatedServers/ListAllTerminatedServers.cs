// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Dslogmanager.Wrapper;
using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Api.Dslogmanager.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Dslogmanager
{
    [SdkConsoleCommand("dslogmanager","listallterminatedservers")]
    public class ListAllTerminatedServersCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Dslogmanager"; } }

        public string OperationName{ get { return "ListAllTerminatedServers"; } }

        [SdkCommandArgument("deployment")]
        public string? Deployment { get; set; }

        [SdkCommandArgument("endDate")]
        public string? EndDate { get; set; }

        [SdkCommandArgument("gameMode")]
        public string? GameMode { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("namespace_")]
        public string? Namespace { get; set; }

        [SdkCommandArgument("next")]
        public string? Next { get; set; }

        [SdkCommandArgument("partyId")]
        public string? PartyId { get; set; }

        [SdkCommandArgument("podName")]
        public string? PodName { get; set; }

        [SdkCommandArgument("previous")]
        public string? Previous { get; set; }

        [SdkCommandArgument("provider")]
        public string? Provider { get; set; }

        [SdkCommandArgument("region")]
        public string? Region { get; set; }

        [SdkCommandArgument("sessionId")]
        public string? SessionId { get; set; }

        [SdkCommandArgument("startDate")]
        public string? StartDate { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public ListAllTerminatedServersCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dslogmanager.Wrapper.AllTerminatedServers wrapper = new AccelByte.Sdk.Api.Dslogmanager.Wrapper.AllTerminatedServers(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Dslogmanager.Operation.ListAllTerminatedServers.Builder;

            if (Deployment != null)
                opBuilder.SetDeployment((string)Deployment);
            if (EndDate != null)
                opBuilder.SetEndDate((string)EndDate);
            if (GameMode != null)
                opBuilder.SetGameMode((string)GameMode);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Namespace != null)
                opBuilder.SetNamespace((string)Namespace);
            if (Next != null)
                opBuilder.SetNext((string)Next);
            if (PartyId != null)
                opBuilder.SetPartyId((string)PartyId);
            if (PodName != null)
                opBuilder.SetPodName((string)PodName);
            if (Previous != null)
                opBuilder.SetPrevious((string)Previous);
            if (Provider != null)
                opBuilder.SetProvider((string)Provider);
            if (Region != null)
                opBuilder.SetRegion((string)Region);
            if (SessionId != null)
                opBuilder.SetSessionId((string)SessionId);
            if (StartDate != null)
                opBuilder.SetStartDate((string)StartDate);
            if (Status != null)
                opBuilder.SetStatus((string)Status);
            if (UserId != null)
                opBuilder.SetUserId((string)UserId);




            ListAllTerminatedServers operation = opBuilder.Build(
            );


            AccelByte.Sdk.Api.Dslogmanager.Model.ModelsListTerminatedServersResponse? response = wrapper.ListAllTerminatedServers(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}