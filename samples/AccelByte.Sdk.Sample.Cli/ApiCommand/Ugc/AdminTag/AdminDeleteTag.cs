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

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ugc
{
    [SdkConsoleCommand("ugc","admindeletetag")]
    public class AdminDeleteTagCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "AdminDeleteTag"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("tagId")]
        public string TagId { get; set; } = String.Empty;

        public AdminDeleteTagCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminTag wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminTag(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ugc.Operation.AdminDeleteTag.Builder;





            AdminDeleteTag operation = opBuilder.Build(
                Namespace,
                TagId
            );

            
            wrapper.AdminDeleteTag(operation);
            return String.Empty;
        }
    }
}