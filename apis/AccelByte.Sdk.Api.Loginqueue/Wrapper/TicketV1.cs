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

using AccelByte.Sdk.Api.Loginqueue.Model;
using AccelByte.Sdk.Api.Loginqueue.Operation;

namespace AccelByte.Sdk.Api.Loginqueue.Wrapper
{
    public class TicketV1
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public TicketV1(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public TicketV1(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public RefreshTicket.RefreshTicketBuilder RefreshTicketOp
        {
            get
            {
                var opBuilder = new Operation.RefreshTicket.RefreshTicketBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CancelTicket.CancelTicketBuilder CancelTicketOp
        {
            get
            {
                var opBuilder = new Operation.CancelTicket.CancelTicketBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public RefreshTicket.Response RefreshTicket(RefreshTicket input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<RefreshTicket.Response> RefreshTicketAsync(RefreshTicket input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CancelTicket.Response CancelTicket(CancelTicket input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CancelTicket.Response> CancelTicketAsync(CancelTicket input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}