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
    [SdkConsoleCommand("social","publiccreateusernamespaceslot")]
    public class PublicCreateUserNamespaceSlotCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "PublicCreateUserNamespaceSlot"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("label")]
        public string? Label { get; set; }

        [SdkCommandArgument("tags")]
        public List<string>? Tags { get; set; }

        [SdkCommandArgument("checksum")]
        public string Checksum { get; set; } = String.Empty;

        [SdkCommandArgument("customAttribute")]
        public string CustomAttribute { get; set; } = String.Empty;

        [SdkCommandFile("file")]
        public Stream? File { get; set; }

        public PublicCreateUserNamespaceSlotCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.Slot wrapper = new AccelByte.Sdk.Api.Social.Wrapper.Slot(_SDK);

            #pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Social.Operation.PublicCreateUserNamespaceSlot.Builder;

            if (Label != null)
                opBuilder.SetLabel((string)Label);
            if (Tags != null)
                opBuilder.SetTags((List<string>)Tags);


            if (Checksum != null)
                opBuilder.SetChecksum((string)Checksum);
            if (CustomAttribute != null)
                opBuilder.SetCustomAttribute((string)CustomAttribute);
            if (File != null)
                opBuilder.SetFile((Stream)File);


            PublicCreateUserNamespaceSlot operation = opBuilder.Build(
                Namespace,
                UserId
            );

            #pragma warning restore ab_deprecated_operation

            #pragma warning disable ab_deprecated_operation_wrapper
            var response = wrapper.PublicCreateUserNamespaceSlot(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
            #pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}