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
    /// listReports
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:TICKET [READ]
    /// Reports list can be ordered by:
    /// - createdAt
    /// - updatedAt
    /// </summary>
    public class ListReports : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListReportsBuilder Builder { get => new ListReportsBuilder(); }

        public class ListReportsBuilder
            : OperationBuilder<ListReportsBuilder>
        {

            public string? Category { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? ReportedUserId { get; set; }

            public string? SortBy { get; set; }





            internal ListReportsBuilder() { }

            internal ListReportsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ListReportsBuilder SetCategory(string _category)
            {
                Category = _category;
                return this;
            }

            public ListReportsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public ListReportsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public ListReportsBuilder SetReportedUserId(string _reportedUserId)
            {
                ReportedUserId = _reportedUserId;
                return this;
            }

            public ListReportsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public ListReports Build(
                string namespace_
            )
            {
                ListReports op = new ListReports(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.RestapiReportListResponse? Execute(
                string namespace_
            )
            {
                ListReports op = Build(
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
        }

        private ListReports(ListReportsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Category is not null) QueryParams["category"] = builder.Category;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.ReportedUserId is not null) QueryParams["reportedUserId"] = builder.ReportedUserId;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListReports(
            string namespace_,
            string? category,
            long? limit,
            long? offset,
            string? reportedUserId,
            string? sortBy
        )
        {
            PathParams["namespace"] = namespace_;

            if (category is not null) QueryParams["category"] = category;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (reportedUserId is not null) QueryParams["reportedUserId"] = reportedUserId;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/reports";

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