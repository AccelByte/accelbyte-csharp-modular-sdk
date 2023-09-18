// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Sessionbrowser.Wrapper;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Api.Sessionbrowser.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Sessionbrowser
{
    [SdkConsoleCommand("sessionbrowser", "adminsearchsessionsv2")]
    public class AdminSearchSessionsV2Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Sessionbrowser"; } }

        public string OperationName { get { return "AdminSearchSessionsV2"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("channel")]
        public string? Channel { get; set; }

        [SdkCommandArgument("deleted")]
        public bool? Deleted { get; set; }

        [SdkCommandArgument("matchID")]
        public string? MatchID { get; set; }

        [SdkCommandArgument("partyID")]
        public string? PartyID { get; set; }

        [SdkCommandArgument("sessionType")]
        public string? SessionType { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        [SdkCommandArgument("userID")]
        public string? UserID { get; set; }

        [SdkCommandArgument("limit")]
        public long Limit { get; set; } = 0;

        [SdkCommandArgument("offset")]
        public long Offset { get; set; } = 0;

        public AdminSearchSessionsV2Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session wrapper = new AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Sessionbrowser.Operation.AdminSearchSessionsV2.Builder;

            if (Channel != null)
                opBuilder.SetChannel((string)Channel);
            if (Deleted != null)
                opBuilder.SetDeleted((bool)Deleted);
            if (MatchID != null)
                opBuilder.SetMatchID((string)MatchID);
            if (PartyID != null)
                opBuilder.SetPartyID((string)PartyID);
            if (SessionType != null)
                opBuilder.SetSessionType((string)SessionType);
            if (Status != null)
                opBuilder.SetStatus((string)Status);
            if (UserID != null)
                opBuilder.SetUserID((string)UserID);




            AdminSearchSessionsV2 operation = opBuilder.Build(
                Namespace,
                Limit,
                Offset
            );


            AccelByte.Sdk.Api.Sessionbrowser.Model.ModelsGetSessionHistorySearchResponseV2? response = wrapper.AdminSearchSessionsV2(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}