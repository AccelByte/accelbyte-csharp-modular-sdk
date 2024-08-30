// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform", "updatesection")]
    public class UpdateSectionCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "UpdateSection"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("sectionId")]
        public string SectionId { get; set; } = String.Empty;

        [SdkCommandArgument("storeId")]
        public string StoreId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public SectionUpdate Body { get; set; } = new SectionUpdate();

        public UpdateSectionCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Section wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Section(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.UpdateSection.Builder;





            UpdateSection operation = opBuilder.Build(
                Body,
                Namespace,
                SectionId,
                StoreId
            );


            AccelByte.Sdk.Api.Platform.Model.FullSectionInfo? response = wrapper.UpdateSection(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}