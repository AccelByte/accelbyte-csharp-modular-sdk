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
    [SdkConsoleCommand("social","publicqueryuserstatitems1")]
    public class PublicQueryUserStatItems1Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "PublicQueryUserStatItems1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("additionalKey")]
        public string? AdditionalKey { get; set; }

        [SdkCommandArgument("statCodes")]
        public List<string>? StatCodes { get; set; }

        [SdkCommandArgument("tags")]
        public List<string>? Tags { get; set; }

        public PublicQueryUserStatItems1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.UserStatistic wrapper = new AccelByte.Sdk.Api.Social.Wrapper.UserStatistic(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Social.Operation.PublicQueryUserStatItems1.Builder;

            if (AdditionalKey != null)
                opBuilder.SetAdditionalKey((string)AdditionalKey);
            if (StatCodes != null)
                opBuilder.SetStatCodes((List<string>)StatCodes);
            if (Tags != null)
                opBuilder.SetTags((List<string>)Tags);




            PublicQueryUserStatItems1 operation = opBuilder.Build(
                Namespace,
                UserId
            );


            var response = wrapper.PublicQueryUserStatItems1(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}