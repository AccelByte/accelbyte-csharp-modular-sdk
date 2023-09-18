// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Social
{
    [SdkConsoleCommand("social", "deletetiedstat")]
    public class DeleteTiedStatCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Social"; } }

        public string OperationName { get { return "DeleteTiedStat"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("statCode")]
        public string StatCode { get; set; } = String.Empty;

        public DeleteTiedStatCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.StatConfiguration wrapper = new AccelByte.Sdk.Api.Social.Wrapper.StatConfiguration(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Social.Operation.DeleteTiedStat.Builder;





            DeleteTiedStat operation = opBuilder.Build(
                Namespace,
                StatCode
            );


            wrapper.DeleteTiedStat(operation);
            return String.Empty;
        }
    }
}