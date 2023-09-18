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
    [SdkConsoleCommand("cloudsave","adminputadminplayerrecordv1")]
    public class AdminPutAdminPlayerRecordV1Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Cloudsave"; } }

        public string OperationName{ get { return "AdminPutAdminPlayerRecordV1"; } }

        [SdkCommandArgument("key")]
        public string Key { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsAdminPlayerRecordRequest Body { get; set; } = new ModelsAdminPlayerRecordRequest();

        public AdminPutAdminPlayerRecordV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminRecord(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Cloudsave.Operation.AdminPutAdminPlayerRecordV1.Builder;





            AdminPutAdminPlayerRecordV1 operation = opBuilder.Build(
                Body,
                Key,
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Cloudsave.Model.ModelsAdminPlayerRecordResponse? response = wrapper.AdminPutAdminPlayerRecordV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}