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
    [SdkConsoleCommand("ugc", "rollbackcontentversionv2")]
    public class RollbackContentVersionV2Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Ugc"; } }

        public string OperationName { get { return "RollbackContentVersionV2"; } }

        [SdkCommandArgument("contentId")]
        public string ContentId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("versionId")]
        public string VersionId { get; set; } = String.Empty;

        public RollbackContentVersionV2Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminContentV2 wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminContentV2(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ugc.Operation.RollbackContentVersionV2.Builder;





            RollbackContentVersionV2 operation = opBuilder.Build(
                ContentId,
                Namespace,
                VersionId
            );


            AccelByte.Sdk.Api.Ugc.Model.ModelsContentDownloadResponse? response = wrapper.RollbackContentVersionV2(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}