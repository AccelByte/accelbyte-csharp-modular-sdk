// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Ams.Wrapper;
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Api.Ams.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ams
{
    [SdkConsoleCommand("ams","imageget")]
    public class ImageGetCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ams"; } }

        public string OperationName{ get { return "ImageGet"; } }

        [SdkCommandArgument("imageID")]
        public string ImageID { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public ImageGetCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ams.Wrapper.Images wrapper = new AccelByte.Sdk.Api.Ams.Wrapper.Images(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ams.Operation.ImageGet.Builder;





            ImageGet operation = opBuilder.Build(
                ImageID,
                Namespace
            );

            
            AccelByte.Sdk.Api.Ams.Model.ApiImageDetails? response = wrapper.ImageGet(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}