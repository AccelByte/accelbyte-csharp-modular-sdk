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
    /// queryEntitlements
    ///
    /// Query entitlements by Item Ids.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : entitlement list
    /// </summary>
    public class QueryEntitlements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryEntitlementsBuilder Builder { get => new QueryEntitlementsBuilder(); }

        public class QueryEntitlementsBuilder
            : OperationBuilder<QueryEntitlementsBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public List<string>? ItemIds { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }





            internal QueryEntitlementsBuilder() { }

            internal QueryEntitlementsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryEntitlementsBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public QueryEntitlementsBuilder SetItemIds(List<string> _itemIds)
            {
                ItemIds = _itemIds;
                return this;
            }

            public QueryEntitlementsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryEntitlementsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public QueryEntitlements Build(
                string namespace_
            )
            {
                QueryEntitlements op = new QueryEntitlements(this,
                    namespace_
                );

                op.SetBaseFields<QueryEntitlementsBuilder>(this);
                return op;
            }

            public QueryEntitlements.Response Execute(
                string namespace_
            )
            {
                QueryEntitlements op = Build(
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
            public async Task<QueryEntitlements.Response> ExecuteAsync(
                string namespace_
            )
            {
                QueryEntitlements op = Build(
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

        private QueryEntitlements(QueryEntitlementsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.ItemIds is not null) QueryParams["itemIds"] = builder.ItemIds;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;



            CollectionFormatMap["itemIds"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.EntitlementPagingSlicedResult>
        {


            protected override string GetFullOperationId() => "Platform::Entitlement::QueryEntitlements";
        }

        #endregion

        public QueryEntitlements(
            string namespace_,
            bool? activeOnly,
            List<string>? itemIds,
            int? limit,
            int? offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (itemIds is not null) QueryParams["itemIds"] = itemIds;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;



            CollectionFormatMap["itemIds"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/entitlements/byItemIds";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public QueryEntitlements.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new QueryEntitlements.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.EntitlementPagingSlicedResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}