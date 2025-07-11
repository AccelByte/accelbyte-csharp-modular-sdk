// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ugc
{
    [SdkConsoleCommand("ugc","publicbulkgetcontentbyidv2")]
    public class PublicBulkGetContentByIDV2Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "PublicBulkGetContentByIDV2"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsPublicGetContentBulkRequest Body { get; set; } = new ModelsPublicGetContentBulkRequest();

        public PublicBulkGetContentByIDV2Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.PublicContentV2 wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.PublicContentV2(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ugc.Operation.PublicBulkGetContentByIDV2.Builder;





            PublicBulkGetContentByIDV2 operation = opBuilder.Build(
                Body,
                Namespace
            );


            var response = wrapper.PublicBulkGetContentByIDV2(operation);
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