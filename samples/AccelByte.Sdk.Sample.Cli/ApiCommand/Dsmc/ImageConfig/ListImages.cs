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
    [SdkConsoleCommand("dsmc","listimages")]
    public class ListImagesCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Dsmc"; } }

        public string OperationName{ get { return "ListImages"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("q")]
        public string? Q { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        [SdkCommandArgument("sortDirection")]
        public string? SortDirection { get; set; }

        [SdkCommandArgument("count")]
        public long Count { get; set; } = 0;

        [SdkCommandArgument("offset")]
        public long Offset { get; set; } = 0;

        public ListImagesCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.ImageConfig wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.ImageConfig(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Dsmc.Operation.ListImages.Builder;

            if (Q != null)
                opBuilder.SetQ((string)Q);
            if (SortBy != null)
                opBuilder.SetSortBy(ListImagesSortBy.NewValue(SortBy));
            if (SortDirection != null)
                opBuilder.SetSortDirection(ListImagesSortDirection.NewValue(SortDirection));




            ListImages operation = opBuilder.Build(
                Namespace,
                Count,
                Offset
            );


            var response = wrapper.ListImages(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (response.Error != null)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}