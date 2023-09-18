// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Dsmc
{
    [SdkConsoleCommand("dsmc", "getlowestinstancespec")]
    public class GetLowestInstanceSpecCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Dsmc"; } }

        public string OperationName { get { return "GetLowestInstanceSpec"; } }

        public GetLowestInstanceSpecCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.PodConfig wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.PodConfig(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Dsmc.Operation.GetLowestInstanceSpec.Builder;





            GetLowestInstanceSpec operation = opBuilder.Build(
            );


            AccelByte.Sdk.Api.Dsmc.Model.ModelsInstanceSpec? response = wrapper.GetLowestInstanceSpec(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}