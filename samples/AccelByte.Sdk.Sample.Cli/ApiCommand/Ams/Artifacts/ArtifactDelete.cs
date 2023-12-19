// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("ams", "artifactdelete")]
    public class ArtifactDeleteCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Ams"; } }

        public string OperationName { get { return "ArtifactDelete"; } }

        [SdkCommandArgument("artifactID")]
        public string ArtifactID { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public ArtifactDeleteCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ams.Wrapper.Artifacts wrapper = new AccelByte.Sdk.Api.Ams.Wrapper.Artifacts(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ams.Operation.ArtifactDelete.Builder;





            ArtifactDelete operation = opBuilder.Build(
                ArtifactID,
                Namespace
            );


            wrapper.ArtifactDelete(operation);
            return String.Empty;
        }
    }
}