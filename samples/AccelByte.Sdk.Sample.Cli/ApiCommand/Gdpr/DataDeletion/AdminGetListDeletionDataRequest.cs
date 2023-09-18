// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Gdpr.Wrapper;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Gdpr
{
    [SdkConsoleCommand("gdpr", "admingetlistdeletiondatarequest")]
    public class AdminGetListDeletionDataRequestCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Gdpr"; } }

        public string OperationName { get { return "AdminGetListDeletionDataRequest"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("after")]
        public string? After { get; set; }

        [SdkCommandArgument("before")]
        public string? Before { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("requestDate")]
        public string? RequestDate { get; set; }

        public AdminGetListDeletionDataRequestCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Gdpr.Wrapper.DataDeletion wrapper = new AccelByte.Sdk.Api.Gdpr.Wrapper.DataDeletion(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Gdpr.Operation.AdminGetListDeletionDataRequest.Builder;

            if (After != null)
                opBuilder.SetAfter((string)After);
            if (Before != null)
                opBuilder.SetBefore((string)Before);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (RequestDate != null)
                opBuilder.SetRequestDate((string)RequestDate);




            AdminGetListDeletionDataRequest operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Gdpr.Model.ModelsListDeletionDataResponse? response = wrapper.AdminGetListDeletionDataRequest(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}