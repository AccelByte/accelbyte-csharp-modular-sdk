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
    [SdkConsoleCommand("ugc","adminuploadcontentscreenshot")]
    public class AdminUploadContentScreenshotCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "AdminUploadContentScreenshot"; } }

        [SdkCommandArgument("contentId")]
        public string ContentId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsCreateScreenshotRequest Body { get; set; } = new ModelsCreateScreenshotRequest();

        public AdminUploadContentScreenshotCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminContent wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminContent(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ugc.Operation.AdminUploadContentScreenshot.Builder;





            AdminUploadContentScreenshot operation = opBuilder.Build(
                Body,
                ContentId,
                Namespace
            );


            AccelByte.Sdk.Api.Ugc.Model.ModelsCreateScreenshotResponse? response = wrapper.AdminUploadContentScreenshot(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}