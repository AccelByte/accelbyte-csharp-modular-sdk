// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Social
{
    [SdkConsoleCommand("social", "publicupdateusernamespaceslotmetadata")]
    public class PublicUpdateUserNamespaceSlotMetadataCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Social"; } }

        public string OperationName { get { return "PublicUpdateUserNamespaceSlotMetadata"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("slotId")]
        public string SlotId { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public SlotMetadataUpdate Body { get; set; } = new SlotMetadataUpdate();

        public PublicUpdateUserNamespaceSlotMetadataCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.Slot wrapper = new AccelByte.Sdk.Api.Social.Wrapper.Slot(_SDK);

#pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Social.Operation.PublicUpdateUserNamespaceSlotMetadata.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Social.Model.SlotMetadataUpdate)Body);



            PublicUpdateUserNamespaceSlotMetadata operation = opBuilder.Build(
                Namespace,
                SlotId,
                UserId
            );

#pragma warning restore ab_deprecated_operation

#pragma warning disable ab_deprecated_operation_wrapper
            AccelByte.Sdk.Api.Social.Model.SlotInfo? response = wrapper.PublicUpdateUserNamespaceSlotMetadata(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
#pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}