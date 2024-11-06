// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Reporting.Wrapper;
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Reporting
{
    [SdkConsoleCommand("reporting","getticketdetail")]
    public class GetTicketDetailCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Reporting"; } }

        public string OperationName{ get { return "GetTicketDetail"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("ticketId")]
        public string TicketId { get; set; } = String.Empty;

        public GetTicketDetailCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Reporting.Wrapper.AdminTickets wrapper = new AccelByte.Sdk.Api.Reporting.Wrapper.AdminTickets(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Reporting.Operation.GetTicketDetail.Builder;





            GetTicketDetail operation = opBuilder.Build(
                Namespace,
                TicketId
            );


            var response = wrapper.GetTicketDetail(operation);
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