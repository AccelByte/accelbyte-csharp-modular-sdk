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

        private string _CustomBasePath = String.Empty;

        public GameSessionDetail(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public GameSessionDetail(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminQueryGameSessionDetail.AdminQueryGameSessionDetailBuilder AdminQueryGameSessionDetailOp
        {
            get
            {
                var opBuilder = new Operation.AdminQueryGameSessionDetail.AdminQueryGameSessionDetailBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetGameSessionDetail.GetGameSessionDetailBuilder GetGameSessionDetailOp
        {
            get
            {
                var opBuilder = new Operation.GetGameSessionDetail.GetGameSessionDetailBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminQueryMatchmakingDetail.AdminQueryMatchmakingDetailBuilder AdminQueryMatchmakingDetailOp
        {
            get
            {
                var opBuilder = new Operation.AdminQueryMatchmakingDetail.AdminQueryMatchmakingDetailBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetMatchmakingDetailBySessionID.AdminGetMatchmakingDetailBySessionIDBuilder AdminGetMatchmakingDetailBySessionIDOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetMatchmakingDetailBySessionID.AdminGetMatchmakingDetailBySessionIDBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetMatchmakingDetailByTicketID.AdminGetMatchmakingDetailByTicketIDBuilder AdminGetMatchmakingDetailByTicketIDOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetMatchmakingDetailByTicketID.AdminGetMatchmakingDetailByTicketIDBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminQueryPartyDetail.AdminQueryPartyDetailBuilder AdminQueryPartyDetailOp
        {
            get
            {
                var opBuilder = new Operation.AdminQueryPartyDetail.AdminQueryPartyDetailBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetPartyDetail.GetPartyDetailBuilder GetPartyDetailOp
        {
            get
            {
                var opBuilder = new Operation.GetPartyDetail.GetPartyDetailBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminQueryTicketDetail.AdminQueryTicketDetailBuilder AdminQueryTicketDetailOp
        {
            get
            {
                var opBuilder = new Operation.AdminQueryTicketDetail.AdminQueryTicketDetailBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminTicketDetailGetByTicketID.AdminTicketDetailGetByTicketIDBuilder AdminTicketDetailGetByTicketIDOp
        {
            get
            {
                var opBuilder = new Operation.AdminTicketDetailGetByTicketID.AdminTicketDetailGetByTicketIDBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicQueryGameSessionMe.PublicQueryGameSessionMeBuilder PublicQueryGameSessionMeOp
        {
            get
            {
                var opBuilder = new Operation.PublicQueryGameSessionMe.PublicQueryGameSessionMeBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public AdminQueryGameSessionDetail.Response AdminQueryGameSessionDetail(AdminQueryGameSessionDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminQueryGameSessionDetail.Response> AdminQueryGameSessionDetailAsync(AdminQueryGameSessionDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetGameSessionDetail.Response GetGameSessionDetail(GetGameSessionDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetGameSessionDetail.Response> GetGameSessionDetailAsync(GetGameSessionDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminQueryMatchmakingDetail.Response AdminQueryMatchmakingDetail(AdminQueryMatchmakingDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminQueryMatchmakingDetail.Response> AdminQueryMatchmakingDetailAsync(AdminQueryMatchmakingDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetMatchmakingDetailBySessionID.Response AdminGetMatchmakingDetailBySessionID(AdminGetMatchmakingDetailBySessionID input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetMatchmakingDetailBySessionID.Response> AdminGetMatchmakingDetailBySessionIDAsync(AdminGetMatchmakingDetailBySessionID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminGetMatchmakingDetailBySessionID.Response<T1> AdminGetMatchmakingDetailBySessionID<T1>(AdminGetMatchmakingDetailBySessionID input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetMatchmakingDetailBySessionID.Response<T1>> AdminGetMatchmakingDetailBySessionIDAsync<T1>(AdminGetMatchmakingDetailBySessionID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetMatchmakingDetailByTicketID.Response AdminGetMatchmakingDetailByTicketID(AdminGetMatchmakingDetailByTicketID input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetMatchmakingDetailByTicketID.Response> AdminGetMatchmakingDetailByTicketIDAsync(AdminGetMatchmakingDetailByTicketID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminGetMatchmakingDetailByTicketID.Response<T1> AdminGetMatchmakingDetailByTicketID<T1>(AdminGetMatchmakingDetailByTicketID input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetMatchmakingDetailByTicketID.Response<T1>> AdminGetMatchmakingDetailByTicketIDAsync<T1>(AdminGetMatchmakingDetailByTicketID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminQueryPartyDetail.Response AdminQueryPartyDetail(AdminQueryPartyDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminQueryPartyDetail.Response> AdminQueryPartyDetailAsync(AdminQueryPartyDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetPartyDetail.Response GetPartyDetail(GetPartyDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetPartyDetail.Response> GetPartyDetailAsync(GetPartyDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminQueryTicketDetail.Response AdminQueryTicketDetail(AdminQueryTicketDetail input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminQueryTicketDetail.Response> AdminQueryTicketDetailAsync(AdminQueryTicketDetail input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminTicketDetailGetByTicketID.Response AdminTicketDetailGetByTicketID(AdminTicketDetailGetByTicketID input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminTicketDetailGetByTicketID.Response> AdminTicketDetailGetByTicketIDAsync(AdminTicketDetailGetByTicketID input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicQueryGameSessionMe.Response PublicQueryGameSessionMe(PublicQueryGameSessionMe input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicQueryGameSessionMe.Response> PublicQueryGameSessionMeAsync(PublicQueryGameSessionMe input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}