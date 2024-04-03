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

using AccelByte.Sdk.Api.Sessionhistory.Model;
using AccelByte.Sdk.Api.Sessionhistory.Operation;

namespace AccelByte.Sdk.Api.Sessionhistory.Wrapper
{
    public class GameSessionDetail
    {
        private readonly IAccelByteSdk _sdk;

        public GameSessionDetail(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminQueryGameSessionDetail.AdminQueryGameSessionDetailBuilder AdminQueryGameSessionDetailOp
        {
            get { return new Operation.AdminQueryGameSessionDetail.AdminQueryGameSessionDetailBuilder(_sdk); }
        }
        public GetGameSessionDetail.GetGameSessionDetailBuilder GetGameSessionDetailOp
        {
            get { return new Operation.GetGameSessionDetail.GetGameSessionDetailBuilder(_sdk); }
        }
        public AdminQueryMatchmakingDetail.AdminQueryMatchmakingDetailBuilder AdminQueryMatchmakingDetailOp
        {
            get { return new Operation.AdminQueryMatchmakingDetail.AdminQueryMatchmakingDetailBuilder(_sdk); }
        }
        public AdminGetMatchmakingDetailBySessionID.AdminGetMatchmakingDetailBySessionIDBuilder AdminGetMatchmakingDetailBySessionIDOp
        {
            get { return new Operation.AdminGetMatchmakingDetailBySessionID.AdminGetMatchmakingDetailBySessionIDBuilder(_sdk); }
        }
        public AdminGetMatchmakingDetailByTicketID.AdminGetMatchmakingDetailByTicketIDBuilder AdminGetMatchmakingDetailByTicketIDOp
        {
            get { return new Operation.AdminGetMatchmakingDetailByTicketID.AdminGetMatchmakingDetailByTicketIDBuilder(_sdk); }
        }
        public AdminQueryPartyDetail.AdminQueryPartyDetailBuilder AdminQueryPartyDetailOp
        {
            get { return new Operation.AdminQueryPartyDetail.AdminQueryPartyDetailBuilder(_sdk); }
        }
        public GetPartyDetail.GetPartyDetailBuilder GetPartyDetailOp
        {
            get { return new Operation.GetPartyDetail.GetPartyDetailBuilder(_sdk); }
        }
        public AdminQueryTicketDetail.AdminQueryTicketDetailBuilder AdminQueryTicketDetailOp
        {
            get { return new Operation.AdminQueryTicketDetail.AdminQueryTicketDetailBuilder(_sdk); }
        }
        public AdminTicketDetailGetByTicketID.AdminTicketDetailGetByTicketIDBuilder AdminTicketDetailGetByTicketIDOp
        {
            get { return new Operation.AdminTicketDetailGetByTicketID.AdminTicketDetailGetByTicketIDBuilder(_sdk); }
        }
        #endregion

        public Model.ApimodelsGameSessionDetailQueryResponse? AdminQueryGameSessionDetail(AdminQueryGameSessionDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsGameSessionDetailQueryResponse?> AdminQueryGameSessionDetailAsync(AdminQueryGameSessionDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGameSessionDetail? GetGameSessionDetail(GetGameSessionDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsGameSessionDetail?> GetGameSessionDetailAsync(GetGameSessionDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsMatchmakingDetailQueryResponse? AdminQueryMatchmakingDetail(AdminQueryMatchmakingDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsMatchmakingDetailQueryResponse?> AdminQueryMatchmakingDetailAsync(AdminQueryMatchmakingDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsMatchmakingDetail? AdminGetMatchmakingDetailBySessionID(AdminGetMatchmakingDetailBySessionID input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsMatchmakingDetail?> AdminGetMatchmakingDetailBySessionIDAsync(AdminGetMatchmakingDetailBySessionID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsMatchmakingDetail? AdminGetMatchmakingDetailByTicketID(AdminGetMatchmakingDetailByTicketID input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsMatchmakingDetail?> AdminGetMatchmakingDetailByTicketIDAsync(AdminGetMatchmakingDetailByTicketID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPartyDetailQueryResponse? AdminQueryPartyDetail(AdminQueryPartyDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsPartyDetailQueryResponse?> AdminQueryPartyDetailAsync(AdminQueryPartyDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsPartyDetail? GetPartyDetail(GetPartyDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsPartyDetail?> GetPartyDetailAsync(GetPartyDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsTicketDetailQueryResponse? AdminQueryTicketDetail(AdminQueryTicketDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsTicketDetailQueryResponse?> AdminQueryTicketDetailAsync(AdminQueryTicketDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsTicketObservabilityDetail? AdminTicketDetailGetByTicketID(AdminTicketDetailGetByTicketID input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsTicketObservabilityDetail?> AdminTicketDetailGetByTicketIDAsync(AdminTicketDetailGetByTicketID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}