// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Sessionhistory.Model;

namespace AccelByte.Sdk.Api.Sessionhistory.Operation
{
    /// <summary>
    /// adminQueryTicketDetail
    ///
    /// Get all matchmaking ticket.
    /// </summary>
    public class AdminQueryTicketDetail : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminQueryTicketDetailBuilder Builder { get => new AdminQueryTicketDetailBuilder(); }

        public class AdminQueryTicketDetailBuilder
            : OperationBuilder<AdminQueryTicketDetailBuilder>
        {

            public string? EndDate { get; set; }

            public string? GameMode { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Order { get; set; }

            public string? PartyID { get; set; }

            public string? Region { get; set; }

            public string? StartDate { get; set; }

            public string? UserIDs { get; set; }





            internal AdminQueryTicketDetailBuilder() { }

            internal AdminQueryTicketDetailBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminQueryTicketDetailBuilder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public AdminQueryTicketDetailBuilder SetGameMode(string _gameMode)
            {
                GameMode = _gameMode;
                return this;
            }

            public AdminQueryTicketDetailBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminQueryTicketDetailBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminQueryTicketDetailBuilder SetOrder(string _order)
            {
                Order = _order;
                return this;
            }

            public AdminQueryTicketDetailBuilder SetPartyID(string _partyID)
            {
                PartyID = _partyID;
                return this;
            }

            public AdminQueryTicketDetailBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public AdminQueryTicketDetailBuilder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }

            public AdminQueryTicketDetailBuilder SetUserIDs(string _userIDs)
            {
                UserIDs = _userIDs;
                return this;
            }





            public AdminQueryTicketDetail Build(
                string namespace_
            )
            {
                AdminQueryTicketDetail op = new AdminQueryTicketDetail(this,
                    namespace_
                );

                op.SetBaseFields<AdminQueryTicketDetailBuilder>(this);
                return op;
            }

            public Model.ApimodelsTicketDetailQueryResponse? Execute(
                string namespace_
            )
            {
                AdminQueryTicketDetail op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ApimodelsTicketDetailQueryResponse?> ExecuteAsync(
                string namespace_
            )
            {
                AdminQueryTicketDetail op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminQueryTicketDetail(AdminQueryTicketDetailBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.EndDate is not null) QueryParams["endDate"] = builder.EndDate;
            if (builder.GameMode is not null) QueryParams["gameMode"] = builder.GameMode;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Order is not null) QueryParams["order"] = builder.Order;
            if (builder.PartyID is not null) QueryParams["partyID"] = builder.PartyID;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.StartDate is not null) QueryParams["startDate"] = builder.StartDate;
            if (builder.UserIDs is not null) QueryParams["userIDs"] = builder.UserIDs;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminQueryTicketDetail(
            string namespace_,
            string? endDate,
            string? gameMode,
            long? limit,
            long? offset,
            string? order,
            string? partyID,
            string? region,
            string? startDate,
            string? userIDs
        )
        {
            PathParams["namespace"] = namespace_;

            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (gameMode is not null) QueryParams["gameMode"] = gameMode;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (order is not null) QueryParams["order"] = order;
            if (partyID is not null) QueryParams["partyID"] = partyID;
            if (region is not null) QueryParams["region"] = region;
            if (startDate is not null) QueryParams["startDate"] = startDate;
            if (userIDs is not null) QueryParams["userIDs"] = userIDs;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v1/admin/namespaces/{namespace}/tickets";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsTicketDetailQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsTicketDetailQueryResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsTicketDetailQueryResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}