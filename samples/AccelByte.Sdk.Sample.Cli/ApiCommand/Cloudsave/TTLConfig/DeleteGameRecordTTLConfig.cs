// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Cloudsave.Wrapper;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Cloudsave
{
    [SdkConsoleCommand("cloudsave", "deletegamerecordttlconfig")]
    public class DeleteGameRecordTTLConfigCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Cloudsave"; } }

        public string OperationName { get { return "DeleteGameRecordTTLConfig"; } }

        [SdkCommandArgument("key")]
        public string Key { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public DeleteGameRecordTTLConfigCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.TTLConfig wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.TTLConfig(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Cloudsave.Operation.DeleteGameRecordTTLConfig.Builder;





            DeleteGameRecordTTLConfig operation = opBuilder.Build(
                Key,
                Namespace
            );


            wrapper.DeleteGameRecordTTLConfig(operation);
            return String.Empty;
        }
    }
}