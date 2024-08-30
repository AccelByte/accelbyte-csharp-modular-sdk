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
    [SdkConsoleCommand("platform", "publicreconcileplaystationstorewithmultipleservicelabels")]
    public class PublicReconcilePlayStationStoreWithMultipleServiceLabelsCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "PublicReconcilePlayStationStoreWithMultipleServiceLabels"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public PlayStationMultiServiceLabelsReconcileRequest Body { get; set; } = new PlayStationMultiServiceLabelsReconcileRequest();

        public PublicReconcilePlayStationStoreWithMultipleServiceLabelsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.IAP wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.IAP(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.PublicReconcilePlayStationStoreWithMultipleServiceLabels.Builder;





            PublicReconcilePlayStationStoreWithMultipleServiceLabels operation = opBuilder.Build(
                Body,
                Namespace,
                UserId
            );


            List<AccelByte.Sdk.Api.Platform.Model.PlayStationReconcileResult>? response = wrapper.PublicReconcilePlayStationStoreWithMultipleServiceLabels(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}