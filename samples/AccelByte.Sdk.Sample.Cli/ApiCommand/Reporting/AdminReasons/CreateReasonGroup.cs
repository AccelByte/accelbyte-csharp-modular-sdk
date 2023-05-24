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

using AccelByte.Sdk.Api.Reporting.Wrapper;
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Reporting
{
    [SdkConsoleCommand("reporting","createreasongroup")]
    public class CreateReasonGroupCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Reporting"; } }

        public string OperationName{ get { return "CreateReasonGroup"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public RestapiCreateReasonGroupRequest Body { get; set; } = new RestapiCreateReasonGroupRequest();
                
        public CreateReasonGroupCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Reporting.Wrapper.AdminReasons wrapper = new AccelByte.Sdk.Api.Reporting.Wrapper.AdminReasons(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Reporting.Operation.CreateReasonGroup.Builder;





            CreateReasonGroup operation = opBuilder.Build(
                Body,
                Namespace
            );

            
            AccelByte.Sdk.Api.Reporting.Model.RestapiReasonGroupResponse? response = wrapper.CreateReasonGroup(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}