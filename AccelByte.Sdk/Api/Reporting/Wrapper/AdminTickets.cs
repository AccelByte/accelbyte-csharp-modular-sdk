// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Reporting.Wrapper
{
    public class AdminTickets
    {
        private readonly AccelByteSDK _sdk;

        public AdminTickets(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListTickets.ListTicketsBuilder ListTicketsOp
        {
            get { return Operation.ListTickets.Builder.SetWrapperObject(this); }
        }
        public TicketStatistic.TicketStatisticBuilder TicketStatisticOp
        {
            get { return Operation.TicketStatistic.Builder.SetWrapperObject(this); }
        }
        public GetTicketDetail.GetTicketDetailBuilder GetTicketDetailOp
        {
            get { return Operation.GetTicketDetail.Builder.SetWrapperObject(this); }
        }
        public DeleteTicket.DeleteTicketBuilder DeleteTicketOp
        {
            get { return Operation.DeleteTicket.Builder.SetWrapperObject(this); }
        }
        public GetReportsByTicket.GetReportsByTicketBuilder GetReportsByTicketOp
        {
            get { return Operation.GetReportsByTicket.Builder.SetWrapperObject(this); }
        }
        public UpdateTicketResolutions.UpdateTicketResolutionsBuilder UpdateTicketResolutionsOp
        {
            get { return Operation.UpdateTicketResolutions.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.RestapiTicketListResponse? ListTickets(ListTickets input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiTicketStatisticResponse? TicketStatistic(TicketStatistic input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiTicketResponse? GetTicketDetail(GetTicketDetail input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteTicket(DeleteTicket input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiReportListResponse? GetReportsByTicket(GetReportsByTicket input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiTicketResponse? UpdateTicketResolutions(UpdateTicketResolutions input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}