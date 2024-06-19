// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Gdpr.Wrapper;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Gdpr
{
    [SdkConsoleCommand("gdpr", "s2ssubmituseraccountdeletionrequest")]
    public class S2SSubmitUserAccountDeletionRequestCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Gdpr"; } }

        public string OperationName { get { return "S2SSubmitUserAccountDeletionRequest"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public S2SSubmitUserAccountDeletionRequestCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Gdpr.Wrapper.DataDeletionS2S wrapper = new AccelByte.Sdk.Api.Gdpr.Wrapper.DataDeletionS2S(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Gdpr.Operation.S2SSubmitUserAccountDeletionRequest.Builder;





            S2SSubmitUserAccountDeletionRequest operation = opBuilder.Build(
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Gdpr.Model.ModelsS2SRequestDeleteResponse? response = wrapper.S2SSubmitUserAccountDeletionRequest(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}