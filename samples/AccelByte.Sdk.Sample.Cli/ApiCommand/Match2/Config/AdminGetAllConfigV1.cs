// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Match2.Wrapper;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Match2
{
    [SdkConsoleCommand("match2","admingetallconfigv1")]
    public class AdminGetAllConfigV1Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Match2"; } }

        public string OperationName{ get { return "AdminGetAllConfigV1"; } }

        public AdminGetAllConfigV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Match2.Wrapper.Config wrapper = new AccelByte.Sdk.Api.Match2.Wrapper.Config(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Match2.Operation.AdminGetAllConfigV1.Builder;





            AdminGetAllConfigV1 operation = opBuilder.Build(
            );


            var response = wrapper.AdminGetAllConfigV1(operation);
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