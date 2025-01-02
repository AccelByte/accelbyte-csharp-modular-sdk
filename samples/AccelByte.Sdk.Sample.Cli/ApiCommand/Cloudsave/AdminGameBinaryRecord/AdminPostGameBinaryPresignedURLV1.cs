// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("cloudsave", "adminpostgamebinarypresignedurlv1")]
    public class AdminPostGameBinaryPresignedURLV1Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Cloudsave"; } }

        public string OperationName { get { return "AdminPostGameBinaryPresignedURLV1"; } }

        [SdkCommandArgument("key")]
        public string Key { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUploadBinaryRecordRequest Body { get; set; } = new ModelsUploadBinaryRecordRequest();

        public AdminPostGameBinaryPresignedURLV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminGameBinaryRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminGameBinaryRecord(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Cloudsave.Operation.AdminPostGameBinaryPresignedURLV1.Builder;





            AdminPostGameBinaryPresignedURLV1 operation = opBuilder.Build(
                Body,
                Key,
                Namespace
            );


            var response = wrapper.AdminPostGameBinaryPresignedURLV1(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-", "response data is null.");
            }
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}