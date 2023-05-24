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

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Social
{
    [SdkConsoleCommand("social","publicbulkcreateuserstatitems")]
    public class PublicBulkCreateUserStatItemsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "PublicBulkCreateUserStatItems"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public List<BulkStatItemCreate> Body { get; set; } = new List<BulkStatItemCreate>();
                
        public PublicBulkCreateUserStatItemsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.UserStatistic wrapper = new AccelByte.Sdk.Api.Social.Wrapper.UserStatistic(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Social.Operation.PublicBulkCreateUserStatItems.Builder;


            if (Body != null)
                opBuilder.SetBody((List<AccelByte.Sdk.Api.Social.Model.BulkStatItemCreate>)Body);



            PublicBulkCreateUserStatItems operation = opBuilder.Build(
                Namespace,
                UserId
            );

            
            List<AccelByte.Sdk.Api.Social.Model.BulkStatOperationResult>? response = wrapper.PublicBulkCreateUserStatItems(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}