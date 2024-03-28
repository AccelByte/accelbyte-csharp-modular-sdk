// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Sessionhistory.Wrapper;
using AccelByte.Sdk.Api.Sessionhistory.Model;
using AccelByte.Sdk.Api.Sessionhistory.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Sessionhistory
{
    [SdkConsoleCommand("sessionhistory", "querymatchlengthdurationp99")]
    public class QueryMatchLengthDurationp99Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Sessionhistory"; } }

        public string OperationName { get { return "QueryMatchLengthDurationp99"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("endDate")]
        public string EndDate { get; set; } = String.Empty;

        [SdkCommandArgument("startDate")]
        public string StartDate { get; set; } = String.Empty;

        public QueryMatchLengthDurationp99Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Sessionhistory.Wrapper.XRay wrapper = new AccelByte.Sdk.Api.Sessionhistory.Wrapper.XRay(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Sessionhistory.Operation.QueryMatchLengthDurationp99.Builder;





            QueryMatchLengthDurationp99 operation = opBuilder.Build(
                Namespace,
                EndDate,
                StartDate
            );


            AccelByte.Sdk.Api.Sessionhistory.Model.ApimodelsXRayMatchLengthDurationQueryResponse? response = wrapper.QueryMatchLengthDurationp99(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}