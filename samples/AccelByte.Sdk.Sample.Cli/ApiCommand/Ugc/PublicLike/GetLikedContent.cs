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
    [SdkConsoleCommand("ugc","getlikedcontent")]
    public class GetLikedContentCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "GetLikedContent"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("isofficial")]
        public bool? Isofficial { get; set; }

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

        public GetLikedContentCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.PublicLike wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.PublicLike(_SDK);

            GetLikedContent operation = new GetLikedContent(
                Namespace,                
                Isofficial,                
                Limit,                
                Name,                
                Offset,                
                Orderby,                
                Sortby,                
                Subtype,                
                Tags,                
                Type                
            );            
            
            AccelByte.Sdk.Api.Ugc.Model.ModelsPaginatedContentDownloadResponse? response = wrapper.GetLikedContent(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}