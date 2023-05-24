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
    [SdkConsoleCommand("ugc","searchchannelspecificcontent")]
    public class SearchChannelSpecificContentCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "SearchChannelSpecificContent"; } }

        [SdkCommandArgument("channelId")]
        public string ChannelId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("creator")]
        public string? Creator { get; set; }

        [SdkCommandArgument("isofficial")]
        public string? Isofficial { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("name")]
        public string? Name { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("orderby")]
        public string? Orderby { get; set; }

        [SdkCommandArgument("sortby")]
        public string? Sortby { get; set; }

        [SdkCommandArgument("subtype")]
        public string? Subtype { get; set; }

        [SdkCommandArgument("tags")]
        public List<string>? Tags { get; set; }

        [SdkCommandArgument("type")]
        public string? Type { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public SearchChannelSpecificContentCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.PublicContent wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.PublicContent(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ugc.Operation.SearchChannelSpecificContent.Builder;

            if (Creator != null)
                opBuilder.SetCreator((string)Creator);
            if (Isofficial != null)
                opBuilder.SetIsofficial((string)Isofficial);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Name != null)
                opBuilder.SetName((string)Name);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (Orderby != null)
                opBuilder.SetOrderby((string)Orderby);
            if (Sortby != null)
                opBuilder.SetSortby((string)Sortby);
            if (Subtype != null)
                opBuilder.SetSubtype((string)Subtype);
            if (Tags != null)
                opBuilder.SetTags((List<string>)Tags);
            if (Type != null)
                opBuilder.SetType((string)Type);
            if (UserId != null)
                opBuilder.SetUserId((string)UserId);




            SearchChannelSpecificContent operation = opBuilder.Build(
                ChannelId,
                Namespace
            );

            
            AccelByte.Sdk.Api.Ugc.Model.ModelsPaginatedContentDownloadResponse? response = wrapper.SearchChannelSpecificContent(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}