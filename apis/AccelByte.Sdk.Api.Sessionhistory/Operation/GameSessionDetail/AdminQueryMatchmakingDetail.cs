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
    /// adminQueryMatchmakingDetail
    ///
    /// Get all matchmaking.
    /// </summary>
    public class AdminQueryMatchmakingDetail : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminQueryMatchmakingDetailBuilder Builder { get => new AdminQueryMatchmakingDetailBuilder(); }

        public class AdminQueryMatchmakingDetailBuilder
            : OperationBuilder<AdminQueryMatchmakingDetailBuilder>
        {

            public string? GameSessionID { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Order { get; set; }

            public string? OrderBy { get; set; }

            public string? TicketID { get; set; }

            public string? UserID { get; set; }





            internal AdminQueryMatchmakingDetailBuilder() { }

            internal AdminQueryMatchmakingDetailBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminQueryMatchmakingDetailBuilder SetGameSessionID(string _gameSessionID)
            {
                GameSessionID = _gameSessionID;
                return this;
            }

            public AdminQueryMatchmakingDetailBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminQueryMatchmakingDetailBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminQueryMatchmakingDetailBuilder SetOrder(string _order)
            {
                Order = _order;
                return this;
            }

            public AdminQueryMatchmakingDetailBuilder SetOrderBy(string _orderBy)
            {
                OrderBy = _orderBy;
                return this;
            }

            public AdminQueryMatchmakingDetailBuilder SetTicketID(string _ticketID)
            {
                TicketID = _ticketID;
                return this;
            }

            public AdminQueryMatchmakingDetailBuilder SetUserID(string _userID)
            {
                UserID = _userID;
                return this;
            }





            public AdminQueryMatchmakingDetail Build(
                string namespace_
            )
            {
                AdminQueryMatchmakingDetail op = new AdminQueryMatchmakingDetail(this,
                    namespace_
                );

                op.SetBaseFields<AdminQueryMatchmakingDetailBuilder>(this);
                return op;
            }

            public AdminQueryMatchmakingDetail.Response Execute(
                string namespace_
            )
            {
                AdminQueryMatchmakingDetail op = Build(
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
            public async Task<AdminQueryMatchmakingDetail.Response> ExecuteAsync(
                string namespace_
            )
            {
                AdminQueryMatchmakingDetail op = Build(
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

        private AdminQueryMatchmakingDetail(AdminQueryMatchmakingDetailBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.GameSessionID is not null) QueryParams["gameSessionID"] = builder.GameSessionID;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Order is not null) QueryParams["order"] = builder.Order;
            if (builder.OrderBy is not null) QueryParams["orderBy"] = builder.OrderBy;
            if (builder.TicketID is not null) QueryParams["ticketID"] = builder.TicketID;
            if (builder.UserID is not null) QueryParams["userID"] = builder.UserID;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsMatchmakingDetailQueryResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Sessionhistory::GameSessionDetail::AdminQueryMatchmakingDetail";
        }

        #endregion

        public AdminQueryMatchmakingDetail(
            string namespace_,
            string? gameSessionID,
            long? limit,
            long? offset,
            string? order,
            string? orderBy,
            string? ticketID,
            string? userID
        )
        {
            PathParams["namespace"] = namespace_;

            if (gameSessionID is not null) QueryParams["gameSessionID"] = gameSessionID;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (order is not null) QueryParams["order"] = order;
            if (orderBy is not null) QueryParams["orderBy"] = orderBy;
            if (ticketID is not null) QueryParams["ticketID"] = ticketID;
            if (userID is not null) QueryParams["userID"] = userID;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v1/admin/namespaces/{namespace}/matchmaking";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminQueryMatchmakingDetail.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminQueryMatchmakingDetail.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsMatchmakingDetailQueryResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}