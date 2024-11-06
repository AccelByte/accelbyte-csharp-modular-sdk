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
    [SdkConsoleCommand("cloudsave","adminputadminplayerrecordconcurrenthandlerv1")]
    public class AdminPutAdminPlayerRecordConcurrentHandlerV1Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Cloudsave"; } }

        public string OperationName{ get { return "AdminPutAdminPlayerRecordConcurrentHandlerV1"; } }

        [SdkCommandArgument("key")]
        public string Key { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("responseBody")]
        public bool? ResponseBody { get; set; }

        [SdkCommandData("body")]
        public ModelsAdminPlayerConcurrentRecordRequest Body { get; set; } = new ModelsAdminPlayerConcurrentRecordRequest();

        public AdminPutAdminPlayerRecordConcurrentHandlerV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminConcurrentRecord wrapper = new AccelByte.Sdk.Api.Cloudsave.Wrapper.AdminConcurrentRecord(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Cloudsave.Operation.AdminPutAdminPlayerRecordConcurrentHandlerV1.Builder;

            if (ResponseBody != null)
                opBuilder.SetResponseBody((bool)ResponseBody);




            AdminPutAdminPlayerRecordConcurrentHandlerV1 operation = opBuilder.Build(
                Body,
                Key,
                Namespace,
                UserId
            );


            var response = wrapper.AdminPutAdminPlayerRecordConcurrentHandlerV1(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (response.Error != null)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}