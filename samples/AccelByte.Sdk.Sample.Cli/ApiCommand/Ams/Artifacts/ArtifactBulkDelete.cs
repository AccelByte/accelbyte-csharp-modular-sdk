// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Ams.Wrapper;
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Api.Ams.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ams
{
    [SdkConsoleCommand("ams", "artifactbulkdelete")]
    public class ArtifactBulkDeleteCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Ams"; } }

        public string OperationName { get { return "ArtifactBulkDelete"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("artifactType")]
        public string? ArtifactType { get; set; }

        [SdkCommandArgument("fleetId")]
        public string? FleetId { get; set; }

        [SdkCommandArgument("uploadedBefore")]
        public DateTime? UploadedBefore { get; set; }

        public ArtifactBulkDeleteCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Ams.Wrapper.Artifacts wrapper = new AccelByte.Sdk.Api.Ams.Wrapper.Artifacts(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ams.Operation.ArtifactBulkDelete.Builder;

            if (ArtifactType != null)
                opBuilder.SetArtifactType((string)ArtifactType);
            if (FleetId != null)
                opBuilder.SetFleetId((string)FleetId);
            if (UploadedBefore != null)
                opBuilder.SetUploadedBefore((DateTime)UploadedBefore);




            ArtifactBulkDelete operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.ArtifactBulkDelete(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}