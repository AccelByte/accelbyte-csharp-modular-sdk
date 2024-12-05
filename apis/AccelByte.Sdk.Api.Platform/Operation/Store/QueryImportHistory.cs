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
    /// queryImportHistory
    ///
    /// This API is used to query import store history
    /// </summary>
    public class QueryImportHistory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryImportHistoryBuilder Builder { get => new QueryImportHistoryBuilder(); }

        public class QueryImportHistoryBuilder
            : OperationBuilder<QueryImportHistoryBuilder>
        {

            public string? End { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? SortBy { get; set; }

            public string? Start { get; set; }

            public bool? Success { get; set; }





            internal QueryImportHistoryBuilder() { }

            internal QueryImportHistoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryImportHistoryBuilder SetEnd(string _end)
            {
                End = _end;
                return this;
            }

            public QueryImportHistoryBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryImportHistoryBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryImportHistoryBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public QueryImportHistoryBuilder SetStart(string _start)
            {
                Start = _start;
                return this;
            }

            public QueryImportHistoryBuilder SetSuccess(bool _success)
            {
                Success = _success;
                return this;
            }





            public QueryImportHistory Build(
                string namespace_,
                string storeId
            )
            {
                QueryImportHistory op = new QueryImportHistory(this,
                    namespace_,
                    storeId
                );

                op.SetBaseFields<QueryImportHistoryBuilder>(this);
                return op;
            }

            public QueryImportHistory.Response Execute(
                string namespace_,
                string storeId
            )
            {
                QueryImportHistory op = Build(
                    namespace_,
                    storeId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<QueryImportHistory.Response> ExecuteAsync(
                string namespace_,
                string storeId
            )
            {
                QueryImportHistory op = Build(
                    namespace_,
                    storeId
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

        private QueryImportHistory(QueryImportHistoryBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;

            if (builder.End is not null) QueryParams["end"] = builder.End;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.Start is not null) QueryParams["start"] = builder.Start;
            if (builder.Success != null) QueryParams["success"] = Convert.ToString(builder.Success)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ImportStoreHistoryPagingResult>
        {

            public ErrorEntity? Error400 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Store::QueryImportHistory";
        }

        #endregion

        public QueryImportHistory(
            string namespace_,
            string storeId,
            string? end,
            int? limit,
            int? offset,
            string? sortBy,
            string? start,
            bool? success
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;

            if (end is not null) QueryParams["end"] = end;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (start is not null) QueryParams["start"] = start;
            if (success != null) QueryParams["success"] = Convert.ToString(success)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/{storeId}/import/history";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public QueryImportHistory.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new QueryImportHistory.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ImportStoreHistoryPagingResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }

            return response;
        }
    }

}