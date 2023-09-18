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
    [SdkConsoleCommand("iam","platformtokenrequesthandler")]
    public class PlatformTokenRequestHandlerCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "PlatformTokenRequestHandler"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("device_id")]
        public string DeviceId { get; set; } = String.Empty;

        [SdkCommandArgument("macAddress")]
        public string MacAddress { get; set; } = String.Empty;

        [SdkCommandArgument("platform_token")]
        public string PlatformToken { get; set; } = String.Empty;

        public PlatformTokenRequestHandlerCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth(_SDK);

            #pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.PlatformTokenRequestHandler.Builder;



            if (DeviceId != null)
                opBuilder.SetDeviceId((string)DeviceId);
            if (MacAddress != null)
                opBuilder.SetMacAddress((string)MacAddress);
            if (PlatformToken != null)
                opBuilder.SetPlatformToken((string)PlatformToken);


            PlatformTokenRequestHandler operation = opBuilder.Build(
                Namespace,
                PlatformId
            );

            #pragma warning restore ab_deprecated_operation

            #pragma warning disable ab_deprecated_operation_wrapper
            AccelByte.Sdk.Api.Iam.Model.OauthmodelTokenResponse? response = wrapper.PlatformTokenRequestHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
            #pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}