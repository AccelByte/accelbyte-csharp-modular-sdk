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
    /// queryXrayTimelineByUserID
    ///
    /// Query xray timeline by userID or ticketID
    /// </summary>
    public class QueryXrayTimelineByUserID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryXrayTimelineByUserIDBuilder Builder { get => new QueryXrayTimelineByUserIDBuilder(); }

        public class QueryXrayTimelineByUserIDBuilder
            : OperationBuilder<QueryXrayTimelineByUserIDBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal QueryXrayTimelineByUserIDBuilder() { }

            internal QueryXrayTimelineByUserIDBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryXrayTimelineByUserIDBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryXrayTimelineByUserIDBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public QueryXrayTimelineByUserID Build(
                string namespace_,
                string userId,
                string endDate,
                string startDate
            )
            {
                QueryXrayTimelineByUserID op = new QueryXrayTimelineByUserID(this,
                    namespace_,                    
                    userId,                    
                    endDate,                    
                    startDate                    
                );

                op.SetBaseFields<QueryXrayTimelineByUserIDBuilder>(this);
                return op;
            }

            public QueryXrayTimelineByUserID.Response Execute(
                string namespace_,
                string userId,
                string endDate,
                string startDate
            )
            {
                QueryXrayTimelineByUserID op = Build(
                    namespace_,
                    userId,
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
            public async Task<QueryXrayTimelineByUserID.Response> ExecuteAsync(
                string namespace_,
                string userId,
                string endDate,
                string startDate
            )
            {
                QueryXrayTimelineByUserID op = Build(
                    namespace_,
                    userId,
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

        private QueryXrayTimelineByUserID(QueryXrayTimelineByUserIDBuilder builder,
            string namespace_,
            string userId,
            string endDate,
            string startDate
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsXRayTicketQueryResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Sessionhistory::XRay::QueryXrayTimelineByUserID";
        }

        #endregion

        public QueryXrayTimelineByUserID(
            string namespace_,            
            string userId,            
            long? limit,            
            long? offset,            
            string endDate,            
            string startDate            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v2/admin/namespaces/{namespace}/xray/users/{userId}/tickets";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public QueryXrayTimelineByUserID.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new QueryXrayTimelineByUserID.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsXRayTicketQueryResponse>(payload, ResponseJsonOptions);
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