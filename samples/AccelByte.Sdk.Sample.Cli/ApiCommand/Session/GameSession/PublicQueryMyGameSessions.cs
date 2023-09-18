// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Session
{
    [SdkConsoleCommand("session","publicquerymygamesessions")]
    public class PublicQueryMyGameSessionsCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Session"; } }

        public string OperationName{ get { return "PublicQueryMyGameSessions"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("order")]
        public string? Order { get; set; }

        [SdkCommandArgument("orderBy")]
        public string? OrderBy { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        public PublicQueryMyGameSessionsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.GameSession wrapper = new AccelByte.Sdk.Api.Session.Wrapper.GameSession(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Session.Operation.PublicQueryMyGameSessions.Builder;

            if (Order != null)
                opBuilder.SetOrder((string)Order);
            if (OrderBy != null)
                opBuilder.SetOrderBy((string)OrderBy);
            if (Status != null)
                opBuilder.SetStatus((string)Status);




            PublicQueryMyGameSessions operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Session.Model.ApimodelsGameSessionQueryResponse? response = wrapper.PublicQueryMyGameSessions(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}