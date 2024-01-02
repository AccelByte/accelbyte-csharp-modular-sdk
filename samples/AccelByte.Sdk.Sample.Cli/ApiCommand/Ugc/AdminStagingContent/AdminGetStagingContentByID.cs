// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ugc
{
    [SdkConsoleCommand("ugc", "admingetstagingcontentbyid")]
    public class AdminGetStagingContentByIDCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Ugc"; } }

        public string OperationName { get { return "AdminGetStagingContentByID"; } }

        [SdkCommandArgument("contentId")]
        public string ContentId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public AdminGetStagingContentByIDCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminStagingContent wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminStagingContent(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ugc.Operation.AdminGetStagingContentByID.Builder;





            AdminGetStagingContentByID operation = opBuilder.Build(
                ContentId,
                Namespace
            );


            AccelByte.Sdk.Api.Ugc.Model.ModelsStagingContentResponse? response = wrapper.AdminGetStagingContentByID(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}