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
    /// queryCodes
    ///
    /// Query campaign codes.
    /// Other detail info:
    /// 
    ///   * Returns : list of codes
    ///   * The batchName field in the codes response will be present only when the withBatchName parameter is true , or when the batchName filter is not blank.
    /// </summary>
    public class QueryCodes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryCodesBuilder Builder { get => new QueryCodesBuilder(); }

        public class QueryCodesBuilder
            : OperationBuilder<QueryCodesBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public string? BatchName { get; set; }

            public List<int>? BatchNo { get; set; }

            public string? Code { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public bool? WithBatchName { get; set; }





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

            public QueryCodesBuilder SetBatchName(string _batchName)
            {
                BatchName = _batchName;
                return this;
            }

            public QueryCodesBuilder SetBatchNo(List<int> _batchNo)
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

            public QueryCodesBuilder SetWithBatchName(bool _withBatchName)
            {
                WithBatchName = _withBatchName;
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

                op.SetBaseFields<QueryCodesBuilder>(this);
                return op;
            }

            public QueryCodes.Response Execute(
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
            public async Task<QueryCodes.Response> ExecuteAsync(
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

                var response = await _Sdk.RunRequestAsync(op);
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
            if (builder.BatchName is not null) QueryParams["batchName"] = builder.BatchName;
            if (builder.BatchNo is not null) QueryParams["batchNo"] = builder.BatchNo;
            if (builder.Code is not null) QueryParams["code"] = builder.Code;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.WithBatchName != null) QueryParams["withBatchName"] = Convert.ToString(builder.WithBatchName)!;
            

            
            CollectionFormatMap["batchNo"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.CodeInfoPagingSlicedResult>
        {


            protected override string GetFullOperationId() => "Platform::Campaign::QueryCodes";
        }

        #endregion

        public QueryCodes(
            string campaignId,            
            string namespace_,            
            bool? activeOnly,            
            string? batchName,            
            List<int>? batchNo,            
            string? code,            
            int? limit,            
            int? offset,            
            bool? withBatchName            
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (batchName is not null) QueryParams["batchName"] = batchName;
            if (batchNo is not null) QueryParams["batchNo"] = batchNo;
            if (code is not null) QueryParams["code"] = code;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (withBatchName != null) QueryParams["withBatchName"] = Convert.ToString(withBatchName)!;
            

            
            CollectionFormatMap["batchNo"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public QueryCodes.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new QueryCodes.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.CodeInfoPagingSlicedResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}