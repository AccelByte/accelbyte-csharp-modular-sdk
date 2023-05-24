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

using AccelByte.Sdk.Api.Achievement.Wrapper;
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Achievement.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Achievement
{
    [SdkConsoleCommand("achievement","publiclistuserachievements")]
    public class PublicListUserAchievementsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Achievement"; } }

        public string OperationName{ get { return "PublicListUserAchievements"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("preferUnlocked")]
        public bool? PreferUnlocked { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        [SdkCommandArgument("tags")]
        public List<string>? Tags { get; set; }

        public PublicListUserAchievementsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Achievement.Wrapper.UserAchievements wrapper = new AccelByte.Sdk.Api.Achievement.Wrapper.UserAchievements(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Achievement.Operation.PublicListUserAchievements.Builder;

            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (PreferUnlocked != null)
                opBuilder.SetPreferUnlocked((bool)PreferUnlocked);
            if (SortBy != null)
                opBuilder.SetSortBy((string)SortBy);
            if (Tags != null)
                opBuilder.SetTags((List<string>)Tags);




            PublicListUserAchievements operation = opBuilder.Build(
                Namespace,
                UserId
            );

            
            AccelByte.Sdk.Api.Achievement.Model.ModelsPaginatedUserAchievementResponse? response = wrapper.PublicListUserAchievements(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}