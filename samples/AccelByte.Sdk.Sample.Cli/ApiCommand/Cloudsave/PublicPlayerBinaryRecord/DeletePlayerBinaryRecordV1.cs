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
    [SdkConsoleCommand("cloudsave","deleteplayerbinaryrecordv1")]
    public class DeletePlayerBinaryRecordV1Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Cloudsave"; } }

        public string OperationName{ get { return "DeletePlayerBinaryRecordV1"; } }

        [SdkCommandArgument("key")]
        public string Key { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public DeletePlayerBinaryRecordV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.PublicPlayerBinaryRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.PublicPlayerBinaryRecord(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Cloudsave.Operation.DeletePlayerBinaryRecordV1.Builder;





            DeletePlayerBinaryRecordV1 operation = opBuilder.Build(
                Key,
                Namespace,
                UserId
            );


            var response = wrapper.DeletePlayerBinaryRecordV1(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (response.Error != null)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}