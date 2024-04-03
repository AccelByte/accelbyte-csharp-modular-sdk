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
    public class MatchPools
    {
        private readonly IAccelByteSdk _sdk;

        public MatchPools(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public MatchPoolList.MatchPoolListBuilder MatchPoolListOp
        {
            get { return new Operation.MatchPoolList.MatchPoolListBuilder(_sdk); }
        }
        public CreateMatchPool.CreateMatchPoolBuilder CreateMatchPoolOp
        {
            get { return new Operation.CreateMatchPool.CreateMatchPoolBuilder(_sdk); }
        }
        public MatchPoolDetails.MatchPoolDetailsBuilder MatchPoolDetailsOp
        {
            get { return new Operation.MatchPoolDetails.MatchPoolDetailsBuilder(_sdk); }
        }
        public UpdateMatchPool.UpdateMatchPoolBuilder UpdateMatchPoolOp
        {
            get { return new Operation.UpdateMatchPool.UpdateMatchPoolBuilder(_sdk); }
        }
        public DeleteMatchPool.DeleteMatchPoolBuilder DeleteMatchPoolOp
        {
            get { return new Operation.DeleteMatchPool.DeleteMatchPoolBuilder(_sdk); }
        }
        public MatchPoolMetric.MatchPoolMetricBuilder MatchPoolMetricOp
        {
            get { return new Operation.MatchPoolMetric.MatchPoolMetricBuilder(_sdk); }
        }
        public GetPlayerMetric.GetPlayerMetricBuilder GetPlayerMetricOp
        {
            get { return new Operation.GetPlayerMetric.GetPlayerMetricBuilder(_sdk); }
        }
        public AdminGetMatchPoolTickets.AdminGetMatchPoolTicketsBuilder AdminGetMatchPoolTicketsOp
        {
            get { return new Operation.AdminGetMatchPoolTickets.AdminGetMatchPoolTicketsBuilder(_sdk); }
        }
        #endregion

        public Model.ApiListMatchPoolsResponse? MatchPoolList(MatchPoolList input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiListMatchPoolsResponse?> MatchPoolListAsync(MatchPoolList input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void CreateMatchPool(CreateMatchPool input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task CreateMatchPoolAsync(CreateMatchPool input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiMatchPool? MatchPoolDetails(MatchPoolDetails input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiMatchPool?> MatchPoolDetailsAsync(MatchPoolDetails input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiMatchPool? UpdateMatchPool(UpdateMatchPool input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiMatchPool?> UpdateMatchPoolAsync(UpdateMatchPool input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteMatchPool(DeleteMatchPool input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteMatchPoolAsync(DeleteMatchPool input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiTicketMetricResultRecord? MatchPoolMetric(MatchPoolMetric input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiTicketMetricResultRecord?> MatchPoolMetricAsync(MatchPoolMetric input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiPlayerMetricRecord? GetPlayerMetric(GetPlayerMetric input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiPlayerMetricRecord?> GetPlayerMetricAsync(GetPlayerMetric input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiListMatchPoolTicketsResponse? AdminGetMatchPoolTickets(AdminGetMatchPoolTickets input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApiListMatchPoolTicketsResponse?> AdminGetMatchPoolTicketsAsync(AdminGetMatchPoolTickets input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}