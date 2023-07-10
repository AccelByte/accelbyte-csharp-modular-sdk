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
    [SdkConsoleCommand("social","bulkincuserstatitemvalue2")]
    public class BulkIncUserStatItemValue2Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "BulkIncUserStatItemValue2"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public List<BulkStatItemInc> Body { get; set; } = new List<BulkStatItemInc>();
                
        public BulkIncUserStatItemValue2Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.UserStatistic wrapper = new AccelByte.Sdk.Api.Social.Wrapper.UserStatistic(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Social.Operation.BulkIncUserStatItemValue2.Builder;


            if (Body != null)
                opBuilder.SetBody((List<AccelByte.Sdk.Api.Social.Model.BulkStatItemInc>)Body);



            BulkIncUserStatItemValue2 operation = opBuilder.Build(
                Namespace,
                UserId
            );

            
            List<AccelByte.Sdk.Api.Social.Model.BulkStatOperationResult>? response = wrapper.BulkIncUserStatItemValue2(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}