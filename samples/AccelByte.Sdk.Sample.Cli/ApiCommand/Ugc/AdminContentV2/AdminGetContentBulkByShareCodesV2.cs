// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ugc
{
    [SdkConsoleCommand("ugc", "admingetcontentbulkbysharecodesv2")]
    public class AdminGetContentBulkByShareCodesV2Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Ugc"; } }

        public string OperationName { get { return "AdminGetContentBulkByShareCodesV2"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsGetContentBulkByShareCodesRequest Body { get; set; } = new ModelsGetContentBulkByShareCodesRequest();

        public AdminGetContentBulkByShareCodesV2Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminContentV2 wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminContentV2(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ugc.Operation.AdminGetContentBulkByShareCodesV2.Builder;





            AdminGetContentBulkByShareCodesV2 operation = opBuilder.Build(
                Body,
                Namespace
            );


            List<AccelByte.Sdk.Api.Ugc.Model.ModelsContentDownloadResponseV2>? response = wrapper.AdminGetContentBulkByShareCodesV2(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}