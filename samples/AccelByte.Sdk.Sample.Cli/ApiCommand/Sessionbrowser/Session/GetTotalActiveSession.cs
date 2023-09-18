// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Sessionbrowser.Wrapper;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Api.Sessionbrowser.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Sessionbrowser
{
    [SdkConsoleCommand("sessionbrowser", "gettotalactivesession")]
    public class GetTotalActiveSessionCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Sessionbrowser"; } }

        public string OperationName { get { return "GetTotalActiveSession"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("sessionType")]
        public string? SessionType { get; set; }

        public GetTotalActiveSessionCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session wrapper = new AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Sessionbrowser.Operation.GetTotalActiveSession.Builder;

            if (SessionType != null)
                opBuilder.SetSessionType((string)SessionType);




            GetTotalActiveSession operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Sessionbrowser.Model.ModelsCountActiveSessionResponse? response = wrapper.GetTotalActiveSession(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}