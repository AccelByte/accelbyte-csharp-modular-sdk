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
    /// querySections
    ///
    /// This API is used to query sections.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : paginated sections
    /// </summary>
    public class QuerySections : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QuerySectionsBuilder Builder { get => new QuerySectionsBuilder(); }

        public class QuerySectionsBuilder
            : OperationBuilder<QuerySectionsBuilder>
        {

            public string? End { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? Start { get; set; }

            public string? StoreId { get; set; }

            public string? ViewId { get; set; }





            internal QuerySectionsBuilder() { }

            internal QuerySectionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QuerySectionsBuilder SetEnd(string _end)
            {
                End = _end;
                return this;
            }

            public QuerySectionsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QuerySectionsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QuerySectionsBuilder SetStart(string _start)
            {
                Start = _start;
                return this;
            }

            public QuerySectionsBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }

            public QuerySectionsBuilder SetViewId(string _viewId)
            {
                ViewId = _viewId;
                return this;
            }





            public QuerySections Build(
                string namespace_
            )
            {
                QuerySections op = new QuerySections(this,
                    namespace_
                );

                op.SetBaseFields<QuerySectionsBuilder>(this);
                return op;
            }

            public Model.SectionPagingSlicedResult? Execute(
                string namespace_
            )
            {
                QuerySections op = Build(
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
            public async Task<Model.SectionPagingSlicedResult?> ExecuteAsync(
                string namespace_
            )
            {
                QuerySections op = Build(
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

        private QuerySections(QuerySectionsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.End is not null) QueryParams["end"] = builder.End;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Start is not null) QueryParams["start"] = builder.Start;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            if (builder.ViewId is not null) QueryParams["viewId"] = builder.ViewId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QuerySections(
            string namespace_,
            string? end,
            int? limit,
            int? offset,
            string? start,
            string? storeId,
            string? viewId
        )
        {
            PathParams["namespace"] = namespace_;

            if (end is not null) QueryParams["end"] = end;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (start is not null) QueryParams["start"] = start;
            if (storeId is not null) QueryParams["storeId"] = storeId;
            if (viewId is not null) QueryParams["viewId"] = viewId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/sections";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.SectionPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.SectionPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SectionPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}