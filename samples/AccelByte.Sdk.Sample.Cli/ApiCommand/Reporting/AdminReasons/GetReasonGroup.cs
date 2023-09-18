// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Reporting.Wrapper;
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Reporting
{
    [SdkConsoleCommand("reporting","getreasongroup")]
    public class GetReasonGroupCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Reporting"; } }

        public string OperationName{ get { return "GetReasonGroup"; } }

        [SdkCommandArgument("groupId")]
        public string GroupId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetReasonGroupCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Reporting.Wrapper.AdminReasons wrapper = new AccelByte.Sdk.Api.Reporting.Wrapper.AdminReasons(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Reporting.Operation.GetReasonGroup.Builder;





            GetReasonGroup operation = opBuilder.Build(
                GroupId,
                Namespace
            );


            AccelByte.Sdk.Api.Reporting.Model.RestapiReasonGroupResponse? response = wrapper.GetReasonGroup(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}