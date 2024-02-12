// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam", "publicdownloadmybackupcodesv4")]
    public class PublicDownloadMyBackupCodesV4Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "PublicDownloadMyBackupCodesV4"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public PublicDownloadMyBackupCodesV4Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.UsersV4 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.UsersV4(_SDK);

#pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.PublicDownloadMyBackupCodesV4.Builder;





            PublicDownloadMyBackupCodesV4 operation = opBuilder.Build(
                Namespace
            );

#pragma warning restore ab_deprecated_operation

#pragma warning disable ab_deprecated_operation_wrapper
            Stream? response = wrapper.PublicDownloadMyBackupCodesV4(operation);
            if (response == null)
                return "No response from server.";

            return response.ReadToString();
#pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}