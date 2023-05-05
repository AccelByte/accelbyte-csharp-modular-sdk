// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Reporting.Model;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// getReportsByTicket
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:TICKET [READ]
    /// List reports ordered by createdAt in descending order.
    /// </summary>
    public class GetReportsByTicket : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetReportsByTicketBuilder Builder { get => new GetReportsByTicketBuilder(); }

        public class GetReportsByTicketBuilder
            : OperationBuilder<GetReportsByTicketBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetReportsByTicketBuilder() { }

            internal GetReportsByTicketBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetReportsByTicketBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetReportsByTicketBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetReportsByTicket Build(
                string namespace_,
                string ticketId
            )
            {
                GetReportsByTicket op = new GetReportsByTicket(this,
                    namespace_,                    
                    ticketId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.RestapiReportListResponse? Execute(
                string namespace_,
                string ticketId
            )
            {
                GetReportsByTicket op = Build(
                    namespace_,
                    ticketId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private GetReportsByTicket(GetReportsByTicketBuilder builder,
            string namespace_,
            string ticketId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketId"] = ticketId;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetReportsByTicket(
            string namespace_,            
            string ticketId,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketId"] = ticketId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/tickets/{ticketId}/reports";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.RestapiReportListResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RestapiReportListResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RestapiReportListResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}