// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Legal
{
    [SdkConsoleCommand("legal","setdefaultpolicy1")]
    public class SetDefaultPolicy1Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "SetDefaultPolicy1"; } }

        [SdkCommandArgument("localizedPolicyVersionId")]
        public string LocalizedPolicyVersionId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public SetDefaultPolicy1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersionsWithNamespace wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersionsWithNamespace(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.SetDefaultPolicy1.Builder;





            SetDefaultPolicy1 operation = opBuilder.Build(
                LocalizedPolicyVersionId,
                Namespace
            );


            wrapper.SetDefaultPolicy1(operation);
            return String.Empty;
        }
    }
}