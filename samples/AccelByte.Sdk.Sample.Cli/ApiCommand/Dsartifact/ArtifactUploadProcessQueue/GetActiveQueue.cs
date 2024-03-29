// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Dsartifact.Wrapper;
using AccelByte.Sdk.Api.Dsartifact.Model;
using AccelByte.Sdk.Api.Dsartifact.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Dsartifact
{
    [SdkConsoleCommand("dsartifact", "getactivequeue")]
    public class GetActiveQueueCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Dsartifact"; } }

        public string OperationName { get { return "GetActiveQueue"; } }

        [SdkCommandArgument("nodeIP")]
        public string NodeIP { get; set; } = String.Empty;

        public GetActiveQueueCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsartifact.Wrapper.ArtifactUploadProcessQueue wrapper = new AccelByte.Sdk.Api.Dsartifact.Wrapper.ArtifactUploadProcessQueue(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Dsartifact.Operation.GetActiveQueue.Builder;





            GetActiveQueue operation = opBuilder.Build(
                NodeIP
            );


            AccelByte.Sdk.Api.Dsartifact.Model.ModelsQueue? response = wrapper.GetActiveQueue(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}