// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;

namespace AccelByte.Sdk.Api.Match2.Wrapper
{
    public class MatchTickets
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public MatchTickets(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public MatchTickets(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public CreateMatchTicket.CreateMatchTicketBuilder CreateMatchTicketOp
        {
            get
            {
                var opBuilder = new Operation.CreateMatchTicket.CreateMatchTicketBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetMyMatchTickets.GetMyMatchTicketsBuilder GetMyMatchTicketsOp
        {
            get
            {
                var opBuilder = new Operation.GetMyMatchTickets.GetMyMatchTicketsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public MatchTicketDetails.MatchTicketDetailsBuilder MatchTicketDetailsOp
        {
            get
            {
                var opBuilder = new Operation.MatchTicketDetails.MatchTicketDetailsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteMatchTicket.DeleteMatchTicketBuilder DeleteMatchTicketOp
        {
            get
            {
                var opBuilder = new Operation.DeleteMatchTicket.DeleteMatchTicketBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Model.ApiMatchTicketResponse? CreateMatchTicket(CreateMatchTicket input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiMatchTicketResponse?> CreateMatchTicketAsync(CreateMatchTicket input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiMatchTicketStatuses? GetMyMatchTickets(GetMyMatchTickets input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiMatchTicketStatuses?> GetMyMatchTicketsAsync(GetMyMatchTickets input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiMatchTicketStatus? MatchTicketDetails(MatchTicketDetails input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiMatchTicketStatus?> MatchTicketDetailsAsync(MatchTicketDetails input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteMatchTicket(DeleteMatchTicket input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteMatchTicketAsync(DeleteMatchTicket input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}