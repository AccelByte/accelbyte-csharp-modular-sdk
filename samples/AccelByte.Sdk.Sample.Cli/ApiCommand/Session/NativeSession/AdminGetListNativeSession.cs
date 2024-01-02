// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Session
{
    [SdkConsoleCommand("session", "admingetlistnativesession")]
    public class AdminGetListNativeSessionCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Session"; } }

        public string OperationName { get { return "AdminGetListNativeSession"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("order")]
        public string? Order { get; set; }

        public AdminGetListNativeSessionCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.NativeSession wrapper = new AccelByte.Sdk.Api.Session.Wrapper.NativeSession(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Session.Operation.AdminGetListNativeSession.Builder;

            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (Order != null)
                opBuilder.SetOrder((string)Order);




            AdminGetListNativeSession operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Session.Model.ApimodelsNativeSessionPagingResponse? response = wrapper.AdminGetListNativeSession(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}