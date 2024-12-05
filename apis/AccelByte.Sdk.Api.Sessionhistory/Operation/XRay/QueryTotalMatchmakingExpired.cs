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
    /// queryTotalMatchmakingExpired
    ///
    /// Query total ticket expired.
    /// </summary>
    public class QueryTotalMatchmakingExpired : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryTotalMatchmakingExpiredBuilder Builder { get => new QueryTotalMatchmakingExpiredBuilder(); }

        public class QueryTotalMatchmakingExpiredBuilder
            : OperationBuilder<QueryTotalMatchmakingExpiredBuilder>
        {

            public List<string>? MatchPool { get; set; }





            internal QueryTotalMatchmakingExpiredBuilder() { }

            internal QueryTotalMatchmakingExpiredBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryTotalMatchmakingExpiredBuilder SetMatchPool(List<string> _matchPool)
            {
                MatchPool = _matchPool;
                return this;
            }





            public QueryTotalMatchmakingExpired Build(
                string namespace_,
                string endDate,
                string startDate
            )
            {
                QueryTotalMatchmakingExpired op = new QueryTotalMatchmakingExpired(this,
                    namespace_,
                    endDate,
                    startDate
                );

                op.SetBaseFields<QueryTotalMatchmakingExpiredBuilder>(this);
                return op;
            }

            public QueryTotalMatchmakingExpired.Response Execute(
                string namespace_,
                string endDate,
                string startDate
            )
            {
                QueryTotalMatchmakingExpired op = Build(
                    namespace_,
                    endDate,
                    startDate
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<QueryTotalMatchmakingExpired.Response> ExecuteAsync(
                string namespace_,
                string endDate,
                string startDate
            )
            {
                QueryTotalMatchmakingExpired op = Build(
                    namespace_,
                    endDate,
                    startDate
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

        private QueryTotalMatchmakingExpired(QueryTotalMatchmakingExpiredBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.MatchPool is not null) QueryParams["matchPool"] = builder.MatchPool;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;



            CollectionFormatMap["matchPool"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsXRayExpiredMatchmakingTicketQueryResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Sessionhistory::XRay::QueryTotalMatchmakingExpired";
        }

        #endregion

        public QueryTotalMatchmakingExpired(
            string namespace_,
            List<string>? matchPool,
            string endDate,
            string startDate
        )
        {
            PathParams["namespace"] = namespace_;

            if (matchPool is not null) QueryParams["matchPool"] = matchPool;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;



            CollectionFormatMap["matchPool"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v2/admin/namespaces/{namespace}/xray/metrics/total-ticket-expired";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public QueryTotalMatchmakingExpired.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new QueryTotalMatchmakingExpired.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsXRayExpiredMatchmakingTicketQueryResponse>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
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