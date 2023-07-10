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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// queryCodes
    ///
    /// Query campaign codes.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CAMPAIGN", action=2 (READ) (READ)
    ///   *  Returns : list of codes
    /// </summary>
    public class QueryCodes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryCodesBuilder Builder { get => new QueryCodesBuilder(); }

        public class QueryCodesBuilder
            : OperationBuilder<QueryCodesBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public int? BatchNo { get; set; }

            public string? Code { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }





            internal QueryCodesBuilder() { }

            internal QueryCodesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryCodesBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public QueryCodesBuilder SetBatchNo(int _batchNo)
            {
                BatchNo = _batchNo;
                return this;
            }

            public QueryCodesBuilder SetCode(string _code)
            {
                Code = _code;
                return this;
            }

            public QueryCodesBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryCodesBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public QueryCodes Build(
                string campaignId,
                string namespace_
            )
            {
                QueryCodes op = new QueryCodes(this,
                    campaignId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.CodeInfoPagingSlicedResult? Execute(
                string campaignId,
                string namespace_
            )
            {
                QueryCodes op = Build(
                    campaignId,
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

        private QueryCodes(QueryCodesBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.BatchNo != null) QueryParams["batchNo"] = Convert.ToString(builder.BatchNo)!;
            if (builder.Code is not null) QueryParams["code"] = builder.Code;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryCodes(
            string campaignId,
            string namespace_,
            bool? activeOnly,
            int? batchNo,
            string? code,
            int? limit,
            int? offset
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (batchNo != null) QueryParams["batchNo"] = Convert.ToString(batchNo)!;
            if (code is not null) QueryParams["code"] = code;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.CodeInfoPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CodeInfoPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CodeInfoPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}