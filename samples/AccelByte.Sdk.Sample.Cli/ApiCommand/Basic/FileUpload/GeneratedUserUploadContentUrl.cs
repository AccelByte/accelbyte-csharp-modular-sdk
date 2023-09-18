// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Basic
{
    [SdkConsoleCommand("basic", "generateduseruploadcontenturl")]
    public class GeneratedUserUploadContentUrlCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Basic"; } }

        public string OperationName { get { return "GeneratedUserUploadContentUrl"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("category")]
        public string? Category { get; set; }

        [SdkCommandArgument("fileType")]
        public string FileType { get; set; } = String.Empty;

        public GeneratedUserUploadContentUrlCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.FileUpload wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.FileUpload(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Basic.Operation.GeneratedUserUploadContentUrl.Builder;

            if (Category != null)
                opBuilder.SetCategory((string)Category);




            GeneratedUserUploadContentUrl operation = opBuilder.Build(
                Namespace,
                UserId,
                FileType
            );


            AccelByte.Sdk.Api.Basic.Model.FileUploadUrlInfo? response = wrapper.GeneratedUserUploadContentUrl(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}