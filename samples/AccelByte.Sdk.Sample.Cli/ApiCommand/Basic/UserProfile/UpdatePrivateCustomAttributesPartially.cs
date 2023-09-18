// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Basic
{
    [SdkConsoleCommand("basic","updateprivatecustomattributespartially")]
    public class UpdatePrivateCustomAttributesPartiallyCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Basic"; } }

        public string OperationName{ get { return "UpdatePrivateCustomAttributesPartially"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public Dictionary<string, object> Body { get; set; } = new Dictionary<string, object>();

        public UpdatePrivateCustomAttributesPartiallyCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.UserProfile wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.UserProfile(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Basic.Operation.UpdatePrivateCustomAttributesPartially.Builder;


            if (Body != null)
                opBuilder.SetBody((Dictionary<string, object>)Body);



            UpdatePrivateCustomAttributesPartially operation = opBuilder.Build(
                Namespace,
                UserId
            );


            Dictionary<string, object>? response = wrapper.UpdatePrivateCustomAttributesPartially(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}