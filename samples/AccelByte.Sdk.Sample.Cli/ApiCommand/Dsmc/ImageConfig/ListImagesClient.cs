// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Dsmc
{
    [SdkConsoleCommand("dsmc", "listimagesclient")]
    public class ListImagesClientCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Dsmc"; } }

        public string OperationName { get { return "ListImagesClient"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("count")]
        public long? Count { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("q")]
        public string? Q { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        [SdkCommandArgument("sortDirection")]
        public string? SortDirection { get; set; }

        public ListImagesClientCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.ImageConfig wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.ImageConfig(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Dsmc.Operation.ListImagesClient.Builder;

            if (Count != null)
                opBuilder.SetCount((long)Count);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (Q != null)
                opBuilder.SetQ((string)Q);
            if (SortBy != null)
                opBuilder.SetSortBy(ListImagesClientSortBy.NewValue(SortBy));
            if (SortDirection != null)
                opBuilder.SetSortDirection(ListImagesClientSortDirection.NewValue(SortDirection));




            ListImagesClient operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Dsmc.Model.ModelsListImageResponse? response = wrapper.ListImagesClient(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}