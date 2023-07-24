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

using AccelByte.Sdk.Api.Gdpr.Wrapper;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Gdpr
{
    [SdkConsoleCommand("gdpr","publicgetmyaccountdeletionstatus")]
    public class PublicGetMyAccountDeletionStatusCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Gdpr"; } }

        public string OperationName{ get { return "PublicGetMyAccountDeletionStatus"; } }

        public PublicGetMyAccountDeletionStatusCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Gdpr.Wrapper.DataDeletion wrapper = new AccelByte.Sdk.Api.Gdpr.Wrapper.DataDeletion(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Gdpr.Operation.PublicGetMyAccountDeletionStatus.Builder;





            PublicGetMyAccountDeletionStatus operation = opBuilder.Build(
            );

            
            AccelByte.Sdk.Api.Gdpr.Model.ModelsDeletionStatus? response = wrapper.PublicGetMyAccountDeletionStatus(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}