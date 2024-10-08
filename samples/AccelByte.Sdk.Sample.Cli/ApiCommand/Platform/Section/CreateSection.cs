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
    [SdkConsoleCommand("platform", "createsection")]
    public class CreateSectionCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "CreateSection"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("storeId")]
        public string StoreId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public SectionCreate Body { get; set; } = new SectionCreate();

        public CreateSectionCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Section wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Section(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.CreateSection.Builder;





            CreateSection operation = opBuilder.Build(
                Body,
                Namespace,
                StoreId
            );


            AccelByte.Sdk.Api.Platform.Model.FullSectionInfo? response = wrapper.CreateSection(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}