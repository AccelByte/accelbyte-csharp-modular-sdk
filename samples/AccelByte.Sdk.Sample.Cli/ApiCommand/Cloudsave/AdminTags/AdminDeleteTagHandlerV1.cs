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
    [SdkConsoleCommand("cloudsave", "admindeletetaghandlerv1")]
    public class AdminDeleteTagHandlerV1Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Cloudsave"; } }

        public string OperationName { get { return "AdminDeleteTagHandlerV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("tag")]
        public string Tag { get; set; } = String.Empty;

        public AdminDeleteTagHandlerV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminTags wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminTags(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Cloudsave.Operation.AdminDeleteTagHandlerV1.Builder;





            AdminDeleteTagHandlerV1 operation = opBuilder.Build(
                Namespace,
                Tag
            );


            wrapper.AdminDeleteTagHandlerV1(operation);
            return String.Empty;
        }
    }
}