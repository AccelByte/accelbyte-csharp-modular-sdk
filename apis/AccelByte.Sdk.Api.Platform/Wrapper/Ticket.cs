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

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Ticket
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Ticket(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Ticket(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public GetTicketDynamic.GetTicketDynamicBuilder GetTicketDynamicOp
        {
            get
            {
                var opBuilder = new Operation.GetTicketDynamic.GetTicketDynamicBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DecreaseTicketSale.DecreaseTicketSaleBuilder DecreaseTicketSaleOp
        {
            get
            {
                var opBuilder = new Operation.DecreaseTicketSale.DecreaseTicketSaleBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetTicketBoothID.GetTicketBoothIDBuilder GetTicketBoothIDOp
        {
            get
            {
                var opBuilder = new Operation.GetTicketBoothID.GetTicketBoothIDBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public IncreaseTicketSale.IncreaseTicketSaleBuilder IncreaseTicketSaleOp
        {
            get
            {
                var opBuilder = new Operation.IncreaseTicketSale.IncreaseTicketSaleBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AcquireUserTicket.AcquireUserTicketBuilder AcquireUserTicketOp
        {
            get
            {
                var opBuilder = new Operation.AcquireUserTicket.AcquireUserTicketBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public GetTicketDynamic.Response GetTicketDynamic(GetTicketDynamic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetTicketDynamic.Response> GetTicketDynamicAsync(GetTicketDynamic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DecreaseTicketSale.Response DecreaseTicketSale(DecreaseTicketSale input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DecreaseTicketSale.Response> DecreaseTicketSaleAsync(DecreaseTicketSale input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetTicketBoothID.Response GetTicketBoothID(GetTicketBoothID input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetTicketBoothID.Response> GetTicketBoothIDAsync(GetTicketBoothID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public IncreaseTicketSale.Response IncreaseTicketSale(IncreaseTicketSale input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<IncreaseTicketSale.Response> IncreaseTicketSaleAsync(IncreaseTicketSale input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AcquireUserTicket.Response AcquireUserTicket(AcquireUserTicket input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AcquireUserTicket.Response> AcquireUserTicketAsync(AcquireUserTicket input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}