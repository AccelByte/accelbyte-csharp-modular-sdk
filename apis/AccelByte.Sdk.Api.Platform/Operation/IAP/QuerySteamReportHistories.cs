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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// querySteamReportHistories
    /// </summary>
    public class QuerySteamReportHistories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QuerySteamReportHistoriesBuilder Builder { get => new QuerySteamReportHistoriesBuilder(); }

        public class QuerySteamReportHistoriesBuilder
            : OperationBuilder<QuerySteamReportHistoriesBuilder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? OrderId { get; set; }

            public QuerySteamReportHistoriesProcessStatus? ProcessStatus { get; set; }

            public string? SteamId { get; set; }





            internal QuerySteamReportHistoriesBuilder() { }

            internal QuerySteamReportHistoriesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QuerySteamReportHistoriesBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QuerySteamReportHistoriesBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QuerySteamReportHistoriesBuilder SetOrderId(string _orderId)
            {
                OrderId = _orderId;
                return this;
            }

            public QuerySteamReportHistoriesBuilder SetProcessStatus(QuerySteamReportHistoriesProcessStatus _processStatus)
            {
                ProcessStatus = _processStatus;
                return this;
            }

            public QuerySteamReportHistoriesBuilder SetSteamId(string _steamId)
            {
                SteamId = _steamId;
                return this;
            }





            public QuerySteamReportHistories Build(
                string namespace_
            )
            {
                QuerySteamReportHistories op = new QuerySteamReportHistories(this,
                    namespace_                    
                );

                op.SetBaseFields<QuerySteamReportHistoriesBuilder>(this);
                return op;
            }

            public QuerySteamReportHistories.Response Execute(
                string namespace_
            )
            {
                QuerySteamReportHistories op = Build(
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
            public async Task<QuerySteamReportHistories.Response> ExecuteAsync(
                string namespace_
            )
            {
                QuerySteamReportHistories op = Build(
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

        private QuerySteamReportHistories(QuerySteamReportHistoriesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.OrderId is not null) QueryParams["orderId"] = builder.OrderId;
            if (builder.ProcessStatus is not null) QueryParams["processStatus"] = builder.ProcessStatus.Value;
            if (builder.SteamId is not null) QueryParams["steamId"] = builder.SteamId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.SteamReportInfoPagingSlicedResult>
        {


            protected override string GetFullOperationId() => "Platform::IAP::QuerySteamReportHistories";
        }

        #endregion

        public QuerySteamReportHistories(
            string namespace_,            
            int? limit,            
            int? offset,            
            string? orderId,            
            QuerySteamReportHistoriesProcessStatus? processStatus,            
            string? steamId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (orderId is not null) QueryParams["orderId"] = orderId;
            if (processStatus is not null) QueryParams["processStatus"] = processStatus.Value;
            if (steamId is not null) QueryParams["steamId"] = steamId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/steam/report/histories";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public QuerySteamReportHistories.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new QuerySteamReportHistories.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.SteamReportInfoPagingSlicedResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

    public class QuerySteamReportHistoriesProcessStatus : StringEnum<QuerySteamReportHistoriesProcessStatus>
    {
        public static readonly QuerySteamReportHistoriesProcessStatus ERROR
            = new QuerySteamReportHistoriesProcessStatus("ERROR");

        public static readonly QuerySteamReportHistoriesProcessStatus IGNORED
            = new QuerySteamReportHistoriesProcessStatus("IGNORED");

        public static readonly QuerySteamReportHistoriesProcessStatus PROCESSED
            = new QuerySteamReportHistoriesProcessStatus("PROCESSED");


        public static implicit operator QuerySteamReportHistoriesProcessStatus(string value)
        {
            return NewValue(value);
        }

        public QuerySteamReportHistoriesProcessStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}